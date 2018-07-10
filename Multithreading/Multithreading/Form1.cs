using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Multithreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimeConsumingWork_Click(object sender, EventArgs e)
        {
            btnTimeConsumingWork.Enabled = false;
            btnPrintNumbers.Enabled = false;

            //DoTimeConsumingWork();
            Thread secondThread = new Thread(DoTimeConsumingWork);
            secondThread.Start();

            btnTimeConsumingWork.Enabled = true;
            btnPrintNumbers.Enabled = true;
        }

        public void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void btnPrintNumbers_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBoxNumbers.Items.Add(i);
            }
        }
    }
}
