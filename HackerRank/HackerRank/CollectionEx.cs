using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HackerRank
{
    class CollectionEx
    {
        //Non Generic
        ArrayList arrayList1 = new ArrayList();
        BitArray bitArray1 = new BitArray(5);
        SortedList sortedList1 = new SortedList();
        Hashtable ht = new Hashtable();
        Stack myStack = new Stack();
        Queue queue = new Queue();

        public void NonGenericItems()
        {
            arrayList1.Add(1);
            sortedList1.Add(3, "Three");
            sortedList1.Add(4, "Four");
            ht.Add(1, "One");
            ht.Add(2, "Two");
            myStack.Push("Hello!!");
            myStack.Push(null);
            myStack.Push(1);
            queue.Enqueue(3);
            queue.Enqueue(2);
        }
        
        //Generic
        List<int> intList = new List<int>() { 1,2,3,7,8,9,4,5,6};
        Dictionary<int, string> dict = new Dictionary<int, string>();
        SortedList<int, string> mySortedList = new SortedList<int, string>();
        HashSet<int> hash = new HashSet<int>();
        Stack<int> myStack1 = new Stack<int>();
        Queue<int> queue1 = new Queue<int>();
        List<Employee> EmployeeList = new List<Employee>();

        public void GenericItems()
        {
            var sds = EmployeeList.Where(x => x.ID > 1).Select(x => x.ID).ToList();
            var asa = (from data in EmployeeList where data.ID > 2 select data).ToList();
           Dictionary<int,int> Dic= intList.Where(x => x > 5).OrderBy(x=>x).ToDictionary(x=>x,x=>x);
        }
    }
}
