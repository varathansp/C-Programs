using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_and_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double countChar()
        {
            double count = 0;
            using (StreamReader reader = new StreamReader("C:\\data\\data.txt"))
            {
                string charr = reader.ReadToEnd();
                count = charr.Length;
                Thread.Sleep(5000);
            }
            return count; 
        }
        private async void btnCount_Click(object sender, EventArgs e)
        {
            Task<double> taskCount = new Task<double>(countChar);
            taskCount.Start();
            lblMessage.Text = "Count is on Process..please wait..";
            double count = await taskCount;
            lblMessage.Text = "Character count is "+count;
        }
    }
}
