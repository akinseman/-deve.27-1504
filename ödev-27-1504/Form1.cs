using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ödev_27_1504
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayı = 1;
         while (sayı <= 10)
            {
                listBox1.Items.Add(sayı);
                sayı++;

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int say = 1;
            while(say > 10)
            {
                listBox1.Items.Add(say);
                say++;

            }
        }
    }
}
