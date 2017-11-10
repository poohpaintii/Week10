using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P1
{
    public partial class Form1 : Form
    {
        Button BtnHello;
        Color Btnbackcolor;
        public Form1()
        {
           
            InitializeComponent();
            BtnHello = new Button();
            BtnHello.Location = new Point(20, 20);
            BtnHello.Text = "Hello";
            this.Controls.Add(BtnHello);
            BtnHello.Click += BtnHello_Click;
            Btnbackcolor = BtnHello.BackColor;
            BtnHello.MouseEnter += BtnHello_MouseEnter;
            BtnHello.MouseLeave += BtnHello_MouseLeave;
        }

        private void BtnHello_MouseLeave(object sender, EventArgs e)
        {
            BtnHello.BackColor = Btnbackcolor;
        }

        private void BtnHello_MouseEnter(object sender, EventArgs e)
        {
            BtnHello.BackColor = Color.Green;
        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
