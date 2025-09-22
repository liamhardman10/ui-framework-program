using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui_framework_program
{
    public partial class FormNewList : Form
    {
        public FormNewList()
        {
            InitializeComponent();
            this.buttonReturnList.Click += new System.EventHandler(this.buttonReturnList_Click);
        }

        DataTable toDoList = new DataTable();
        bool isEditing = false;

        private void TextBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormNewList_Load(object sender, EventArgs e)
        {
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

            //point datagrid to source
            toDoListView.DataSource = toDoList;

        }


        
        #region List page-specific button events
        
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
            textBoxDescription.Text = "";

        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            isEditing = true;
            if (toDoListView.CurrentCell != null)
            {
                textBoxTitle.Text = toDoListView.Rows[toDoListView.CurrentCell.RowIndex].Cells[0].Value?.ToString() ?? "";
                textBoxDescription.Text = toDoListView.Rows[toDoListView.CurrentCell.RowIndex].Cells[1].Value?.ToString() ?? "";
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (toDoListView.CurrentCell != null)
                {
                    toDoList.Rows.RemoveAt(toDoListView.CurrentCell.RowIndex);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = textBoxTitle.Text;
                toDoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = textBoxDescription.Text;
            }
            else
            {
                toDoList.Rows.Add(textBoxTitle.Text, textBoxDescription.Text);
            }
            textBoxTitle.Text = "";
            textBoxDescription.Text = "";
            isEditing = false;
        }

        private void buttonReturnList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
