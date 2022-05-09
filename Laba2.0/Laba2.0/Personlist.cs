using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2._0
{
    public partial class PersonListForm : Form
    {
        public PersonListForm()
        {
            InitializeComponent();
            //button2.Enabled;
            //button3.Enabled;
        }

        private void PersonListForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet.Persons". При необходимости она может быть перемещена или удалена.
            this.personsTableAdapter.Fill(this.notebookDataSet.Persons);
            ButtonCheck();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                personsBindingSource.RemoveCurrent();
                personsTableAdapter.Update(notebookDataSet.Persons);
            ButtonCheck();

        }

        public  void ButtonCheck()
        {
            if(dataGridView1.Rows.Count <= 1)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {

                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PersonEditForm form = new PersonEditForm();
            form.ShowDialog();
            this.personsTableAdapter.Fill(this.notebookDataSet.Persons);
            ButtonCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonEditForm form = new PersonEditForm(personsBindingSource.Position);
                form.ShowDialog();
                this.personsTableAdapter.Fill(this.notebookDataSet.Persons);
            ButtonCheck();
        }
    }
}
