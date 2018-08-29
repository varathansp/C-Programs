using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows.Forms;

namespace Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTypeDetails_Click(object sender, EventArgs e)
        {
            string typeName = txtTypeName.Text;
            Type type = Type.GetType(typeName);
            MethodList.Items.Clear();
            ConstructorList.Items.Clear();
            PropertyList.Items.Clear();

            MethodInfo[] methods= type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                MethodList.Items.Add(method.ReturnType.Name + " "+ method.Name);
            }

            ConstructorInfo[] Constructors = type.GetConstructors();
            foreach (ConstructorInfo Constructor in Constructors)
            {
                ConstructorList.Items.Add(Constructor.ToString());
            }

            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo propertie in properties)
            {
                PropertyList.Items.Add(propertie.Name);
            }
        }
    }
}
