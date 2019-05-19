using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form Addition = new AddForm();
            Addition.Show();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Form Deletion = new DeleteForm();
            Deletion.Show();
        }

        private void editingButton_Click(object sender, EventArgs e)
        {
            Form Edition = new EditForm();
            Edition.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form Searching = new SearchForm();
            Searching.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            BDList.Items.Clear();
        }

        private void BDList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BDList.SelectedIndex != -1)
            {
                Form DefenitionWin = new DefenitionForm(BDList.SelectedIndex);
                DefenitionWin.Show();
            }
        }

        private void BDOutputButton_Click(object sender, EventArgs e)
        {

        }
    }
}
