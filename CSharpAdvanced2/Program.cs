using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

#region

// Generics provide type safety, code reusability, performance optimization, and flexibility

//33:46 - Benefits of Generics in C#
//35:49 - Benefits of Generics
//37:56 - Using Generics for Type Safety
//39:59 - Understanding Generic Types in C#
//42:14 - Limitations of Generic Types in C#
//44:11 - Understanding Generic Parameters in C#
//namespace CSharpAdvanced2
//{
//    class Stuff<TKey>
//    {
//        public void Method(TKey key)
//        {
//            var blegh = new Stuff<TKey>();
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var stuff = new Stuff<string>();
//            stuff.Method("Hey!");

//            Console.ReadKey();
//        }
//    }
//}

#endregion

#region
//48:30 - Creating a Generic Linked List Class Stub
//50:39 - Implementing a Generic Linked List

//namespace CSharpAdvanced2
//{
//    class LinkedList<T>
//    {
//        class Node
//        {
//            T Value;
//            Node Next;
//        }

//        private LinkedList<T>.Node _first;
//        public int Count { get, private set; }

//        public void Add(T item) { }
//        public void Remove(T item) { }
//        public T Get(int index) { return default(T); }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {

//            Console.ReadKey();
//        }
//    }
//}

#endregion

#region
//1:18:00 - Combining Generics for Static Typing
//1:20:22 - Working with Generic Types
//1:22:35 - Creating a Person Class and Filtering Names
//1:25:13 - Rewriting Nasty Code with Filter Method
//1:27:00 - Using a Generic Method, Delegate, and Iterator Blocks
//1:30:14 - Understanding Deferred Execution in C#
//1:32:00 - Deferred Execution and IEnumerables
//1:34:00 - Exploring IEnumerables and Sequences
//1:37:00 - Breaking Down a Generic Method
//1:39:00 - Using Projection to Create a Graphing Program
//1:41:19 - Understanding Implicit Typing and Generic Type Inference

//namespace CSharpAdvanced2
//{
//    class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public Person(string firstName, string lastName)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            List<Person> people = new List<Person> { new Person("Aaron", "p2"), new Person("Andrew", "a2"), new Person("Nelson", "b2") };
//            IEnumerable<Person> people2 = Filter(people, p => p.FirstName.StartsWith("A", StringComparison.CurrentCultureIgnoreCase));
//            // As shown above, people and people2 represent different data types

//            //people.Add(new Person("AFace", "person"));

//            //Console.WriteLine("First Iteration: ");
//            //foreach (var person in people2)
//            //    Console.WriteLine(person.FirstName);

//            //people.Add(new Person("AFace", "person"));

//            //Console.WriteLine("Second Iteration: ");
//            //foreach (var person in people2)
//            //    Console.WriteLine(person.FirstName);

//            IEnumerable<string> firstNames = Map<Person, string>(people2, p => p.FirstName);
//            var firstNames2 = Map(people2, p => p.FirstName);
//            // Those lines above represent exactly the same thing
//            foreach (string name in firstNames2)
//                Console.WriteLine(name);

//            //var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
//            //var odd = Filter<int>(list, i => i % 3 == 0);
//            //var even = Filter(list, i => i % 5 == 0);

//            //Console.WriteLine("ODD: ");
//            //foreach (var item in odd)
//            //    Console.WriteLine(item);

//            //Console.WriteLine("EVEN: ");
//            //foreach (var item in even)
//            //    Console.WriteLine(item);

//            Console.ReadKey();
//        }

//        static IEnumerable<TResult> Map<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> projection)
//        {
//            foreach (var item in source)
//            {
//                yield return projection(item);
//            }
//        }

//        static IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> predicate)
//        {
//            foreach (var item in source)
//                if (predicate(item))
//                    yield return item;
//        }
//    }
//}

#endregion

#region

//1:43:42 - LINQ: A Collection of Techniques
//1:45:51 - Chaining Extension Methods with LINQ

//namespace CSharpAdvanced2
//{
//    class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public Person(string firstName, string lastName)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//        }
//    }

//    static class EnumerableExtensions
//    {
//        public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> projection)
//        {
//            foreach (var item in source)
//                yield return projection(item);
//        }

//        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
//        {
//            foreach (var item in source)
//                if (predicate(item))
//                    yield return item;
//        }
//    }
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var people = new List<Person> { new Person("Aaron", "p2"), new Person("Andrew", "a2"), new Person("Nelson", "b2") };
//            var firstNames = people
//                .Filter(i => i.FirstName.StartsWith("a", StringComparison.CurrentCultureIgnoreCase))
//                .Map(p => p.FirstName);

//            // We can chain methods (.Filter().Map()) if they are extensible like LINQ; this is more readable
//            // They are invocable on IEnumerables

//            foreach (var name in firstNames)
//            {
//                Console.WriteLine(name);
//            }

//            Console.ReadKey();
//        }
//    }
//}
#endregion

#region
// LINQ

namespace CSharpAdvanced2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    static class EnumerableExtensions
    {
        public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> projection)
        {
            foreach (var item in source)
                yield return projection(item);
        }
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
                if (predicate(item))
                    yield return item;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new List<Person> { new Person("Aaron", "p2"), new Person("Andrew", "a2"), new Person("Nelson", "b2") };
            var firstNames = people
                .Where(i => i.FirstName.StartsWith("a", StringComparison.CurrentCultureIgnoreCase)) // LINQ
                .Select(p => p.FirstName); // LINQ

            // QUERY SYNTAX is also a valid syntax in C#
            // var firstNames = people
            //      from p in people
            //      where p.FirstName.StartsWith("a", StringComparison.CurrentCultureIgnoreCase))
            //  .   select p.FirstName;

            foreach (var name in firstNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
#endregion

#endregion

#region
//1:48:00 - Exploring the LINQ Namespace in C#
//1:50:12 - Exploring LINQ Methods
//1:52:00 - Combining First and Default with Predicates
//1:54:31 - Exploring the Query Syntax of LINQ
//1:56:38 - Exploring the IEnumerable Class in LINQ
//1:58:00 - Understanding Enumerables in C#
//2:00:43 - Understanding Functionality and Types
//2:02:49 - How the For Each Loop Works with the IEnumerable Interface
//2:05:13 - Exploring the IQueryable Extension in C#
//2:07:00 - Bridging the Gap Between LINQ and Databases
//2:09:25 - Exploring LINQ Methods
//2:11:21 - Writing the Signatures for Select, Where, First, and All
//2:14:23 - Understanding Deferred Execution in Programming
//2:17:00 - Re - Implementing LINQ Methods
//2:19:09 - Understanding Generics and Iterator Blocks
#endregion