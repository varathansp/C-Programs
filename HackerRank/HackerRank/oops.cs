using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    interface IA
    {
        
        string FN { get; set; }
        string SN { get; set; }
        void print();
    }
    interface IB
    {
        int ID { get; set; }
        void print();
    }
    public abstract class AC
    {
        public void printNormal()
        {
            Console.WriteLine("Abstract Class Print Normal Method");
        }
        public abstract void printAbstract();
        public abstract void print();
    }

    class oops :AC, IA, IB
    {

        public string FN { get; set; }
        public string SN { get; set; }
        public int ID { get; set; }
        void IA.print()
        {
            Console.WriteLine("IA Method : " + this.ID + " - " + this.FN + " " + this.SN);
        }
        void IB.print()
        {
            Console.WriteLine("IB Method : " + this.ID + " - " + this.FN + " " + this.SN);
        }
        public override void printAbstract()
        {
            Console.WriteLine("AC Abstract Method : " + this.ID + " - " + this.FN + " " + this.SN);
        }
        public override void print()
        {
            Console.WriteLine("AC abstract with same name Method : " + this.ID + " - " + this.FN + " " + this.SN);
        }
    }
}
