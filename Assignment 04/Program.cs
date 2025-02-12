namespace Assignment_04
{
    internal class Program
    {
        public static bool Exists<T>(List<T> list, Predicate<T> match)
        {
            if (list == null || match == null) throw new ArgumentNullException();

            foreach (var item in list)
            {
                if (match(item)) return true;
            }
            return false;
        }

        public static T Find<T>(List<T> list, Predicate<T> match)
        {
            if (list == null || match == null) throw new ArgumentNullException();

            foreach (var item in list)
            {
                if (match(item)) return item;
            }
            return default; 
        }

        public static List<T> FindAll<T>(List<T> list, Predicate<T> match)
        {
            if (list == null || match == null) throw new ArgumentNullException();

            List<T> result = new List<T>();
            foreach (var item in list)
            {
                if (match(item)) result.Add(item);
            }
            return result;
        }

        public static int FindIndex<T>(List<T> list, Predicate<T> match)
        {
            if (list == null || match == null) throw new ArgumentNullException();

            for (int i = 0; i < list.Count; i++)
            {
                if (match(list[i])) return i;
            }
            return -1; 
        }

        public static T FindLast<T>(List<T> list, Predicate<T> match)
        {
            if (list == null || match == null) throw new ArgumentNullException();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i])) return list[i];
            }
            return default; 
        }

        public static int FindLastIndex<T>(List<T> list, Predicate<T> match)
        {
            if (list == null || match == null) throw new ArgumentNullException();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (match(list[i])) return i;
            }
            return -1;
        }

        public static void ForEach<T>(List<T> list, Action<T> action)
        {
            if (list == null || action == null) throw new ArgumentNullException();

            foreach (var item in list)
            {
                action(item);
            }
        }
        static void Main(string[] args)
        {

            #region Part 02: 1-Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:

            //string[] authors = { "A1", "A2" };
            //Book myBook = new Book("123456789", "C# Programming", authors, new DateTime(2023, 5, 10), 29.99m);

            //Console.WriteLine(myBook.ToString());
            //Console.WriteLine("Title: " + BookFunctions.GetTitle(myBook));
            //Console.WriteLine("Authors: " + BookFunctions.GetAuthors(myBook));

            #endregion

            #region Part 03: We need to Implement the List methods from scratch with all overloads

            List<int> numbers = new List<int> { 5, 6, 7, 8, 9 };

            #region Exist
            //bool exists = Exists(numbers, n => n > 3);
            //Console.WriteLine(exists);   
            #endregion

            #region Find
            //int found = Find(numbers, n => n > 3);
            //Console.WriteLine(found);
            #endregion

            #region Find All

            //List<int> foundAll = FindAll(numbers, n => n > 2);
            //Console.WriteLine(string.Join(" , ", foundAll)); 
            #endregion

            #region Find index
            //int index = FindIndex(numbers, n => n > 3);
            //Console.WriteLine(index);
            #endregion

            #region Find Last

            //int lastFound = FindLast(numbers, n => n > 3);
            //Console.WriteLine(lastFound); 
            #endregion

            #region Find Last Index
            //int lastIndex = FindLastIndex(numbers, n => n > 3);
            //Console.WriteLine(lastIndex); 
            #endregion

            #region Foreach
            //ForEach(numbers, n => Console.WriteLine(n * 2));

            #endregion
        
            #endregion

        }
    }
}
