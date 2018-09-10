using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAndStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(){ customerID = 1, customerName="varathan"};
            Customer c2 = new Customer() { customerID = 2, customerName = "Sathya" };
            Customer c3 = new Customer() { customerID = 3, customerName = "Prabha" };
            Customer c4 = new Customer() { customerID = 4, customerName = "Sathis" };

            Console.WriteLine("-------------------Queue-----------------------");

            Queue<Customer> queueCustomer = new Queue<Customer>();
            queueCustomer.Enqueue(c1);
            queueCustomer.Enqueue(c2);
            queueCustomer.Enqueue(c3);
            queueCustomer.Enqueue(c4);
            
            Customer selectandRemoveCutomer= queueCustomer.Dequeue();
            Console.WriteLine("CustomerID = {0} Customer Name = {1}", selectandRemoveCutomer.customerID, selectandRemoveCutomer.customerName);

            Customer JustSelectCustomer = queueCustomer.Peek();
            Console.WriteLine("CustomerID = {0} Customer Name = {1}", JustSelectCustomer.customerID, JustSelectCustomer.customerName);

            //bool result = queueCustomer.Contains(c1);

            Console.WriteLine("-------------------Stack-----------------------");
            Stack<Customer> stackCustomer = new Stack<Customer>();
            stackCustomer.Push(c1);
            stackCustomer.Push(c2);
            stackCustomer.Push(c3);
            stackCustomer.Push(c4);

            Customer selectandRemove = stackCustomer.Pop();
            Console.WriteLine("CustomerID = {0} Customer Name = {1}", selectandRemove.customerID, selectandRemove.customerName);

            Customer JustSelect = stackCustomer.Peek();
            Console.WriteLine("CustomerID = {0} Customer Name = {1}", JustSelect.customerID, JustSelect.customerName);

            //bool result = stackCustomer.Contains(c1);

        }
    }
    class Customer
    {
       public int customerID;
       public string customerName;
    }
}
