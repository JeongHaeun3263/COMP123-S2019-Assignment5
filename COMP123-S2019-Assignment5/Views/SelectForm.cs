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
/*
 * STUDENT NAME: Haeun Jeong
 * STUDENT NUMBER: 301004579
 * Description: This is a select form to select product from database
 * Date: 16th August
 */
namespace COMP123_S2019_Assignment5.Views
{
    public partial class SelectForm : Form
    {
        int rowIndex;
        int columnCount;
        DataGridViewRow currentRow;
        DataGridViewCellCollection cells;
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);
            NextButton.Enabled = false;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {           
            Program.productInfoForm.Show();
            Program.productInfoForm.LoadData(cells);
            this.Hide();
        }

        /// <summary>
        /// This is a method that show the product information that use choose 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ProductsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //var currentCell = ProductsDataGridView.CurrentCell;
            rowIndex = ProductsDataGridView.CurrentCell.RowIndex; 
            currentRow = ProductsDataGridView.Rows[rowIndex];
            columnCount = ProductsDataGridView.ColumnCount;
            cells = currentRow.Cells;

            currentRow.Selected = true;

            string outputString = string.Empty;

            for (int index = 0; index < columnCount; index++)
            {
                outputString += cells[index].Value + " ";
            }

            SelectTextBox.Text = outputString;

            if (double.TryParse(cells[1].Value.ToString(), out double cost))
            {
                SelectTextBox.Text = cells[2].Value + "  " + cells[3].Value + "  " + cost.ToString("C");
            }
            else
            {
                SelectTextBox.Text = cells[2].Value + "  " + cells[3].Value + "  " + cells[1].Value;
            }

            NextButton.Enabled = true;
            
        }

        private void SelectTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
