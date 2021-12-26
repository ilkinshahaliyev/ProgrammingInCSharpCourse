﻿using System;
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
        string path = @"C:\Users\ilkin\Documents\Students\";

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
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                Nationality = txtNationality.Text,
                Gender = txtGender.Text,
                Adress = txtAdress.Text
            };

            path += $"{txtId.Text}.txt";

            var content = student.ToString();

            File.AppendAllText(path, content);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                Nationality = txtNationality.Text,
                Gender = txtGender.Text,
                Adress = txtAdress.Text
            };

            path += $"{txtId.Text}.txt";

            var content = student.ToString();

            File.WriteAllText(path, content);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            path += $"{txtIdDelete.Text}.txt";

            File.Delete(path);
        }
    }
}
