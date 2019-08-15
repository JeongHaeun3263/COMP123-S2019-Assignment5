using COMP123_S2019_Assignment5.Data;
using COMP123_S2019_Assignment5.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5
{
    public static class Program
    {
        public static Product product;
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // now we have access container
            product = new Product();
            productInfoForm = new ProductInfoForm();
            splashScreen = new SplashScreen();
            startForm = new StartForm();
            selectForm = new SelectForm();
            orderForm = new OrderForm();

            Application.Run(splashScreen);
        }
    }
}
