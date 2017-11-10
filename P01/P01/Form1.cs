using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnHello = new Button();
            btnHello.Location = new Point(20, 20);
            btnHello.Text = "Hello";
            this.Controls.Add(btnHello);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
