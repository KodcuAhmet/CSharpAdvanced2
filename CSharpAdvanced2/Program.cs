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

namespace CSharpAdvanced2
{
    class LinkedList<T>
    {
        class Node
        {
            T Value;
            Node Next;
        }

        private LinkedList<T>.Node _first;
        public int Count { get, private set; }

        public void Add(T item) { }
        public void Remove(T item) { }
        public T Get(int index) { return default(T); }
    }

    public class Program
    {
        public static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}

#endregion

#region
//52:47 - Using Generics in Nested Types
//54:51 - Structures and Classes: Understanding the Difference
//56:44 - Why Value Types Cannot Be Null
//58:59 - Understanding Generic Constraints
//1:01:01 - Constraining Generic Type Parameters
//1:03:08 - Enforcing Interface Constraints with C++
//1:05:10 - Understanding the Syntax of Generic Types
//1:07:20 - Generics and Reflection in C#
//1:09:37 - Implementing an Interface with a Linked List
//1:11:52 - Constraining Generic Type Parameters
//1:13:57 - Constraining Generic Parameters
//1:16:01 - Constructing a Generic Method with a Delegate
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
//1:43:42 - LINQ: A Collection of Techniques
//1:45:51 - Chaining Extension Methods with LINQ
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