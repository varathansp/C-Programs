using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class MyGenericClass<T>
    {
        private T genericMemberVariable;
        public T genericProperty { get; set; }

        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

            return genericMemberVariable;
        }

        
    }
    class GenericMethodClass 
    {
        public void ConcatPrint<tem>(tem value1, tem value2) {

            Console.WriteLine(value1.ToString() + value2.ToString());
        }
    }
}
