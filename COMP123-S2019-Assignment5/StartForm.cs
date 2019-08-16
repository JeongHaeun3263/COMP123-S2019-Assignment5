using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * STUDENT NAME: Haeun Jeong
 * STUDENT NUMBER: 301004579
 * Description: This is a start form that allows a user to choose the menu
 * Date: 16th August
 */
namespace COMP123_S2019_Assignment5
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }

        private void LoadOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();

            

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
