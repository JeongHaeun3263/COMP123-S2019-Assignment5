using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    public partial class OrderForm : Form
    {
        DataGridViewCellCollection cells;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void SystemComponentsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your order will be processed in 7 - 10 business days", "notice", MessageBoxButtons.OK);
            Application.Exit();
        }

        internal void LoadData(DataGridViewCellCollection cells)
        {
            this.cells = cells;

            this.ConditionButton.Text = cells[14].Value.ToString();
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

            PriceButton.Text = cells[1].Value.ToString();

            if (double.TryParse(cells[1].Value.ToString(), out double cost))
            {
                PriceButton.Text = cost.ToString("C");
                SalesTaxButton.Text = (cost*0.13).ToString("C");
                TotalButton.Text = (cost + (cost * 0.13)).ToString("C");
            }
            

            //double.TryParse(cells[1].Value.ToString(), out double cost);
            

        }

        //private void LoadProductInfo()
        //{
        //    throw new NotImplementedException();

        //}

        //private void LoadProductInfo(DataGridViewCellCollection cells)
        //{

        //}

        private void MessageBoxButtons_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You selected printing information", "notice", MessageBoxButtons.OK);
        }
    }
}
