namespace NumberList.ConApp
{
    /// <summary>
    /// This class manages a dynamic list of numbers. The added numbers are added to the list in ascending order.
    /// </summary>
    public class ListOfNumbers
    {
        private class Element
        {
            public Element(int data, Element? next)
            {
                Data = data;
                Next = next;
            }
            public int Data { get; set; }
            public Element? Next { get; set; }
        }
        private Element? first = null;

        /// <summary>
        /// Calculates the number of elements in the list.
        /// </summary>
        public int Count
        {
            get
            {
                int result = 0;
                Element? run = first;

                while (run != null)
                {
                    result++;
                    run = run.Next;
                }
                return result;
            }
        }
        /// <summary>
        /// Adds a number to the list (descending by value) in the list.
        /// </summary>
        /// <param name="data">The number who will be added to the list.</param>
        public void Insert(int data)
        {
            if (first == null)  // Case A: the list is empty
            {
                first = new Element(data, first);
            }
            else if (data < first.Data) // Case B: Insert the element before the first element.
            {
                first = new Element(data, first);
            }
            else // Case C and Case D : Insert the item in the list (Case C) or at the end (Case D).
            {
                Element run = first;

                while (run!.Next != null && data > run.Next.Data)
                {
                    run = run.Next;
                }
                run.Next = new Element(data, run.Next);
            }
        }

        /// <summary>
        /// Determines the number at the position. If the position (position < 0 || >= Count) is invalid, an exception 'IndexOutOfRangeException()' is thrown.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>The number at the position.</returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public int GetAt(int position)
        {
            if (position < 0 || position >= Count)
                throw new IndexOutOfRangeException();

            int idx = 0;
            Element? run = first;

            while (run != null && idx != position)
            {
                idx++;
                run = run.Next;
            }
            return run!.Data;
        }

        /// <summary>
        /// Removes an item at the position. If the position (position < 0 || >= Count) is invalid, an exception 'IndexOutOfRangeException()' is thrown.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public void RemoveAt(int position)
        {
            if (position < 0 || position >= Count)
                throw new IndexOutOfRangeException();

            if (position == 0)
            {
                first = first!.Next;
            }
            else
            {
                int idx = 0;
                Element? run = first;

                while (run != null && idx != position - 1)
                {
                    idx++;
                    run = run.Next;
                }
                run!.Next = run.Next!.Next;
            }
        }

        /// <summary>
        /// Removes all duplicates from the list.
        /// </summary>
        public void RemoveDuplicates()
        {
            Element? run = first;

            while (run != null && run.Next != null)
            {
                if (run.Data == run.Next.Data)
                {
                    run.Next = run.Next.Next;
                }
                else
                {
                    run = run.Next;
                }
            }
        }
    }
}
