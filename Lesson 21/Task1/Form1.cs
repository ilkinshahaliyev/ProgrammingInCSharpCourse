using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class frmStudentManagement : Form
    {
        StudentManager _studentManager = new StudentManager();

        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = (int)numericUpDownId.Value;
            student.Name = tbxName.Text;
            student.Surname = tbxSurname.Text;
            student.DateOfBirth = dtpDateOfBirth.Value;
            student.Nationality = tbxNationality.Text;
            student.Adress = tbxAdress.Text;

            if (radioButtonMale.Checked == true)
            {
                student.Gender = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked == true)
            {
                student.Gender = radioButtonFemale.Text;
            }

            _studentManager.Add(student);

            LoadStudents();

            MessageBox.Show("Student added successfully!");
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = _studentManager.GetAll();
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDownIdUpdate.Value = (int)dgwStudents.CurrentRow.Cells[0].Value;
            tbxNameUpdate.Text = dgwStudents.CurrentRow.Cells[1].Value.ToString();
            tbxSurnameUpdate.Text = dgwStudents.CurrentRow.Cells[2].Value.ToString();
            dtpDateOfBirthUpdate.Value = Convert.ToDateTime(dgwStudents.CurrentRow.Cells[3].Value.ToString());
            tbxNationalityUpdate.Text = dgwStudents.CurrentRow.Cells[4].Value.ToString();

            if (dgwStudents.CurrentRow.Cells[5].Value.ToString() == "Male")
            {
                radioButtonMaleUpdate.Checked = true;
            }
            else if (dgwStudents.CurrentRow.Cells[5].Value.ToString() == "Female")
            {
                radioButtonFemaleUpdate.Checked = true;
            }

            tbxAdressUpdate.Text = dgwStudents.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student
            {
                Id = (int)numericUpDownIdUpdate.Value,
                Name = tbxNameUpdate.Text,
                Surname = tbxSurnameUpdate.Text,
                DateOfBirth = dtpDateOfBirthUpdate.Value,
                Nationality = tbxNationalityUpdate.Text,
                Adress = tbxAdressUpdate.Text
            };

            if (radioButtonMaleUpdate.Checked == true)
            {
                student.Gender = radioButtonMaleUpdate.Text;
            }
            else if (radioButtonFemaleUpdate.Checked == true)
            {
                student.Gender = radioButtonFemaleUpdate.Text;
            }

            _studentManager.Update(student);

            LoadStudents();

            MessageBox.Show("Student updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Are you sure?", "Delete student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (a == DialogResult.Yes)
            {
                int id = (int)dgwStudents.CurrentRow.Cells[0].Value;
                _studentManager.Delete(id);

                LoadStudents();

                MessageBox.Show("Student deleted successfully!");
            }
            else
            {
                MessageBox.Show("No students were deleted.");
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            numericUpDownId.Value = 0;
            numericUpDownIdUpdate.Value = 0;
            tbxName.Clear();
            tbxSurname.Clear();
            tbxNationality.Clear();
            tbxAdress.Clear();
            tbxNameUpdate.Clear();
            tbxSurnameUpdate.Clear();
            tbxNationalityUpdate.Clear();
            tbxAdressUpdate.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            dtpDateOfBirthUpdate.Value = DateTime.Now;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonMaleUpdate.Checked = false;
            radioButtonFemaleUpdate.Checked = false;
        }

        private void ListStudentByName(string key)
        {
            var listedStudents = _studentManager.GetAll();

            dgwStudents.DataSource = listedStudents.Where(s=>s.Name?.ToLower() == key.ToLower()).ToList();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;

            if (string.IsNullOrEmpty(key))
            {
                LoadStudents();
            }
            else
            {
                ListStudentByName(tbxSearch.Text);
            }
        }
    }
}
