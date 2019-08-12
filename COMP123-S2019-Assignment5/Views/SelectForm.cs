using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5.Views
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.Show();
            this.Hide();
        }

        
        private void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var currentCell = ProductsDataGridView.CurrentCell;
            int rowIndex = ProductsDataGridView.CurrentCell.RowIndex; 
            var currentRow = ProductsDataGridView.Rows[rowIndex];
            var columnCount = ProductsDataGridView.ColumnCount;
            var cells = currentRow.Cells;

            //currentRow.Selected = true;

            string outputString = string.Empty;

            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value + " ";
            }

            SelectTextBox.Text = outputString;


        }
        
    }
}
