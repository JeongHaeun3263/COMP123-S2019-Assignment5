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
 * Description: This is a splash screen
 * Date: 16th August
 */
namespace COMP123_S2019_Assignment5
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = true;
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }
    }
}
