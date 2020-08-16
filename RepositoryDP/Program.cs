using System;
using System.Collections.Generic;

namespace RepositoryDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating New Rebo");
            Repository repository = new Repository(new DBContext());

            Console.WriteLine("Displaying list elements");
            repository.Display();

            Console.WriteLine("Adding 6");
            repository.Add(6);

            Console.WriteLine("Displaying list elements");
            repository.Display();

            Console.WriteLine("Removing 1");
            repository.Remove(1);

            Console.WriteLine("Displaying list elements");
            repository.Display();

            Console.ReadLine();

        }
    }
        
    class DBContext
    {
        public List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
    }
    public interface IRebository
    {
        void Add(int num);
        void Remove(int num);
        void Display();
    }

    class Repository : IRebository
    {
        DBContext context;
        public Repository(DBContext _context)
        {
            context = _context;       
        }
        public void Add(int num)
        {
            context.list.Add(num);
        }

        public void Remove(int num)
        {
            context.list.Remove(num);
        }
        public void Display()
        {
            foreach (var item in context.list)
                Console.Write($"{item}, ");
            Console.WriteLine();
        }
    }
}
