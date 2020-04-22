using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace W2.T3.ClinardMykal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addStudentBttn_Click(object sender, EventArgs e)
        {
            IList<Person> newPerson = new List<Person>();
            newPerson.Add(new Person { 
                FirstName = FNTextBox.Text,
                LastName = LNTextBox.Text,
                age = AGETextBox.Text, 
                DateofBirth = DOBTextBox.Text,
                sSN = SSNTextBox.Text,
                PhoneNumber1 = PN1TextBox.Text,
                PhoneNumber2 = PN2TextBox.Text,
                Address1 = AD1TextBox.Text,
                Address2 = AD2TextBox.Text,
                city = CITYTextBox.Text,
                state = STATETextBox.Text,
                zip = ZIPTextBox.Text
            });
                                                                                                                     
            var result = from p in newPerson                                                                         
                         select p;                                                                                   
                                                                                                                     
            foreach (var list in result)                                                                             
            {                                                                                                        
                dataGridView1.Rows.Add(list.FirstName, list.LastName, list.age);                                     
                                                                                                                     
                MessageBox.Show("You added a new Student!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FNTextBox.Text = "";
                LNTextBox.Text = "";
                AGETextBox.Text = "";

            }
        }

        private void dltstdt_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                if (!row.IsNewRow) dataGridView1.Rows.Remove(row);

            MessageBox.Show("You deleted a Student!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}