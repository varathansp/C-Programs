using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    class GuidIdentifier
    {
        public void printGuid(int no) {

            for (int i = 0; i < no; i++)
            {
                Console.WriteLine(Guid.NewGuid().ToString());
            }
        }
    }
}
