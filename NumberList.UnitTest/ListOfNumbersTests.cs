using NumberList.ConApp;

namespace NumberList.UnitTest
{
    [TestClass]
    public class ListOfNumbersTests
    {
        static Random random = new Random(DateTime.Now.Millisecond);

        [TestMethod()]
        public void T01_EmptyList_Expected_Count_Zero()
        {
            int expected = 0;
            ListOfNumbers list = new ListOfNumbers();
            Assert.AreEqual(expected, list.Count, $"Leere Liste sollte {expected} Elemente enthalten");
        }
        [TestMethod()]
        public void T02_InsertOneElement_Expected_Count_One()
        {
            int expected = 1;
            int n = 10;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n);
            Assert.AreEqual(expected, list.Count, $"Liste sollte {expected} Elemente enthalten");
        }
        [TestMethod()]
        public void T03_InsertTwoElements_Expected_Count_Two()
        {
            int expected = 2;
            int n1 = 10, n2 = 5;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n1);
            list.Insert(n2);
            Assert.AreEqual(expected, list.Count, $"Liste sollte {expected} Elemente enthalten");
        }
        [TestMethod()]
        public void T04_InsertTenElements_Expected_Count_Ten()
        {
            int expected = 10;
            ListOfNumbers list = new ListOfNumbers();

            for (int i = 0; i < expected; i++)
            {
                list.Insert(random.Next(1, 100));
            }
            Assert.AreEqual(expected, list.Count, $"Liste sollte {expected} Elemente enthalten");
        }

        [TestMethod()]
        public void T05_InsertOneElement_GetAt_0_ReturnsTheSame()
        {
            int expected = 10;
            int n = expected;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n);
            Assert.AreEqual(expected, list.GetAt(0), $"Ungültiges Element an der Position 0 - {list.GetAt(0)}");
        }
        [TestMethod()]
        public void T06_InsertTwoElements_GetAt_1_ReturnsTheHighestElement()
        {
            int n1 = 10, n2 = 5;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n1);
            list.Insert(n2);
            Assert.AreEqual(Math.Max(n1, n2), list.GetAt(1), $"Ungültiges Element an der Position 1 - {list.GetAt(1)}");
        }
        [TestMethod()]
        public void T07_InsertTwoElements_GetAt_0_ReturnsTheLowestElement()
        {
            int n1 = 10, n2 = 5;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n1);
            list.Insert(n2);
            Assert.AreEqual(Math.Min(n1, n2), list.GetAt(0), $"Ungültiges Element an der Position 0 - {list.GetAt(0)}");
        }
        [TestMethod()]
        public void T08_InsertTenElements_Expected_Sorted_Order()
        {
            List<int> expectedList = new List<int>();
            ListOfNumbers list = new ListOfNumbers();

            for (int i = 0; i < 10; i++)
            {
                int rndVal = random.Next(1, 100);

                list.Insert(rndVal);
                expectedList.Add(rndVal);
            }
            expectedList.Sort();
            for (int i = 0; i < expectedList.Count; i++)
            {
                Assert.AreEqual(expectedList[i], list.GetAt(i));
            }
        }

        [TestMethod()]
        public void T08_InsertOneElement_RemoveAt_Zero()
        {
            int expected = 0;
            int n = 10;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n);
            Assert.AreEqual(1, list.Count, $"Leere Liste sollte {1} Elemente enthalten");
            list.RemoveAt(0);
            Assert.AreEqual(expected, list.Count, $"Leere Liste sollte {expected} Elemente enthalten");
        }
        [TestMethod()]
        public void T08_InsertTwoElement_RemoveAt_One()
        {
            int expected = 1;
            int n1 = 10, n2 = 5; 
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n1);
            list.Insert(n2);
            Assert.AreEqual(2, list.Count, $"Leere Liste sollte {2} Elemente enthalten");
            list.RemoveAt(1);
            Assert.AreEqual(expected, list.Count, $"Liste sollte {expected} Elemente enthalten");

            Assert.AreEqual(n2, list.GetAt(0));
        }

        [TestMethod()]
        public void T09_InsertTenElements_RemoveAt_All()
        {
            int elements = 10;
            int expected = 10;
            ListOfNumbers list = new ListOfNumbers();

            for (int i = elements; i > 0; i--)
            {
                list.Insert(i);
            }
            Assert.AreEqual(expected, list.Count, $"Liste sollte {expected} Elemente enthalten");

            for (int i = 0; i < elements; i++)
            {
                list.RemoveAt(0);
            }
            Assert.AreEqual(0, list.Count, $"Leere Liste sollte {0} Elemente enthalten");
        }

        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void T10_InsertOneElement_RemoveAt_One()
        {
            int n = 10;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n);
            Assert.AreEqual(1, list.Count, $"Leere Liste sollte {1} Elemente enthalten");
            list.RemoveAt(1);
        }
        [TestMethod()]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void T11_InsertOneElement_RemoveAt_MinusOne()
        {
            int n = 10;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n);
            Assert.AreEqual(1, list.Count, $"Leere Liste sollte {1} Elemente enthalten");
            list.RemoveAt(-1);
        }

        [TestMethod()]
        public void T12_InsertTwoIdenticalElements_RemoveDuplicates()
        {
            int expected = 1;
            int n1 = 10, n2 = 10;
            ListOfNumbers list = new ListOfNumbers();

            list.Insert(n1);
            list.Insert(n2);
            Assert.AreEqual(2, list.Count, $"Leere Liste sollte {2} Elemente enthalten");
            list.RemoveDuplicates();
            Assert.AreEqual(expected, list.Count, $"Liste sollte {expected} Elemente enthalten");

            Assert.AreEqual(n2, list.GetAt(0));
        }

        [TestMethod()]
        public void T13_InsertIdenticalElements_RemoveDuplicates()
        {
            int[] expected = new[] { 5, 12, 16 };
            int[] insertElems = new[] { 5, 12, 16, 5, 12, 16 }; 
            ListOfNumbers list = new ListOfNumbers();

            for (int i = 0; i < insertElems.Length; i++)
            {
                list.Insert(insertElems[i]);
            }
            Assert.AreEqual(insertElems.Length, list.Count, $"Liste sollte {insertElems.Length} Elemente enthalten");
            list.RemoveDuplicates();
            Assert.AreEqual(expected.Length, list.Count, $"Liste sollte {expected.Length} Elemente enthalten");

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], list.GetAt(i));
            }
        }

        [TestMethod()]
        public void T14_EmptyList_To_EmptyArray()
        {
            int[] expected = Array.Empty<int>();
            ListOfNumbers list = new ListOfNumbers();

            CollectionAssert.AreEqual(expected, list.ToArray());
        }

        [TestMethod()]
        public void T15_List_With3Value_ToArray()
        {
            int[] expected = new[] { 5, 12, 16 };
            int[] insertElems = new[] { 12, 5, 16 };
            ListOfNumbers list = new ListOfNumbers();

            for (int i = 0; i < insertElems.Length; i++)
            {
                list.Insert(insertElems[i]);
            }
            CollectionAssert.AreEqual(expected, list.ToArray());
        }
    }
}