using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task1
{
    public partial class Form1 : Form
    {
        readonly string path = @"C:\Users\ilkin\Documents\Students\";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to student management system :)");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Id = (int)numericUpDownId.Value,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text),
                Nationality = txtNationality.Text,
                Gender = comboBoxGender.Text,
                Adress = txtAdress.Text
            };

            var content = student.ToString();

            File.AppendAllText(path + $"{numericUpDownId.Value}.txt", content);

            MessageBox.Show("Student creating successfully.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Id = int.Parse(numericUpDownId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                DateOfBirth = Convert.ToDateTime(dtpDateOfBirth.Text),
                Nationality = txtNationality.Text,
                Gender = comboBoxGender.Text,
                Adress = txtAdress.Text
            };

            var content = student.ToString();

            File.WriteAllText(path + $"{numericUpDownId.Text}.txt", content);

            MessageBox.Show("Student updating successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            File.Delete(path + $"{txtIdDelete.Text}.txt");

            MessageBox.Show("Student deleting successfully.");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\ilkin\Documents\Students");

            for (int i = 0; i < files.Length; i++)
            {
                listBox1.Items.Add(File.ReadAllText(files[i]));
            }

            MessageBox.Show("Reading operation successfully.");
        }
    }
}
