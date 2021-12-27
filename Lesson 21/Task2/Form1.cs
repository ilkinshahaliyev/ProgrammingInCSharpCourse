using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        const int size = 75;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome. Try to catch me :)");
        }

        private void btnCatch_MouseEnter(object sender, EventArgs e)
        {
            btnCatch.Top = random.Next(0, this.Height - 90);
            btnCatch.Left = random.Next(0, this.Width - 90);
            btnCatch.Width = size;
            btnCatch.Height = size;
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats, you catched me :)");
        }
    }
}
