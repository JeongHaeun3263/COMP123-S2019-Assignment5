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
using System.Web.Script.Serialization;
using System.Diagnostics;
using COMP123_S2019_Assignment5.Data;
using COMP123_S2019_Assignment5.DollarComputersDataSetTableAdapters;
using COMP123_S2019_Assignment5.Properties;
using COMP123_S2019_Assignment5.Views;
/*
 * STUDENT NAME: Haeun Jeong
 * STUDENT NUMBER: 301004579
 * Description: This is a product info form to load the product information that user select
 * Date: 16th August
 */
namespace COMP123_S2019_Assignment5
{
    public partial class ProductInfoForm : Form
    {
        DataGridViewCellCollection cells;

        public object ProductDataGridView { get; private set; }
        public object ProductSaveFileDialog { get; private set; }
        public object ProductOpenFileDialog { get; private set; }
        public string FileName { get; set; }


        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SelectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            Program.orderForm.LoadData(cells);
            Program.selectForm.Hide();
        }

        internal void LoadData(DataGridViewCellCollection cells)
        {
            LoadProductInfo(cells);
        }
        /// <summary>
        /// This is a method that load product information
        /// </summary>
        /// <param name="cells"></param>
        public void LoadProductInfo(DataGridViewCellCollection cells)
        {
            this.cells = cells;
            this.ProductIDButton.Text = cells[0].Value.ToString();
            this.ConditionButton.Text = cells[14].Value.ToString();
            this.CostButton.Text = cells[1].Value.ToString();
            this.PlatformButton.Text = cells[16].Value.ToString();
            this.OSButton.Text = cells[15].Value.ToString();
            this.ManufacturerButton.Text = cells[2].Value.ToString();
            this.ModelButton.Text = cells[3].Value.ToString();
            this.MemoryButton.Text = cells[5].Value.ToString();
            this.LCDSizeButton.Text = cells[7].Value.ToString();
            this.HDDButton.Text = cells[17].Value.ToString();
            this.CPUBrandButton.Text = cells[10].Value.ToString();
            this.CPUNumberButton.Text = cells[12].Value.ToString();
            this.GPUTypeButton.Text = cells[19].Value.ToString();
            this.CPUTypeButton.Text = cells[11].Value.ToString();
            this.CPUSpeedButton.Text = cells[13].Value.ToString();
            this.WebCamButton.Text = cells[30].Value.ToString();

            if (double.TryParse(cells[1].Value.ToString(), out double cost))
            {
                CostButton.Text = cost.ToString("C");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stream myStream;
            //SaveFileDialog ProductOpenFileDialog = new OpenFileDialog();

            //// configure the file dialog
            //ProductOpenFileDialog.FileName = "Product.txt";
            //ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            //ProductOpenFileDialog.Filter = "Text files (*.txt)|*.txt| All Files (*.*)|*.*";

            //// open the file dialog
            //var result = ProductOpenFileDialog.ShowDialog();
            //if (result != DialogResult.Cancel)
            //{
            //    try
            //    {
            //        using (StreamReader inputString = new StreamReader(
            //                       File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
            //        {
            //            //inputString.ReadLine(character.Identity.FirstName);
            //        }
            //    }
            //    catch (IOException exception)
            //    {
            //        Debug.WriteLine("ERROR: " + exception.Message);
            //    }
            //}
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Stream myStream;
            SaveFileDialog ProductSaveFileDialog = new SaveFileDialog();

            // configure the file dialog
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    using (StreamWriter outputString = new StreamWriter(
               File.Open("Product.txt", FileMode.Create)))
                    {
                        outputString.WriteLine(Program.product.productID.ToString());
                        outputString.WriteLine(Program.product.cost);
                        outputString.Close();
                        outputString.Dispose();
                    }

                    MessageBox.Show("File Saved Successfully!", "Saving file...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);
                }

            }
        }
    }
}
