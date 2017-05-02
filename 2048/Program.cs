using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Drawing;

namespace _2048
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
        public static void setTheme(Form form)
        {
            string theme = Properties.Settings.Default.theme;
            if (theme.Equals("aqua"))
            {
                foreach (Control ctrl in form.Controls)
                {
                    if (ctrl is Button)
                    {
                        (ctrl as Button).FlatAppearance.MouseDownBackColor = Color.Aqua;
                    }
                }
                form.BackgroundImage = Properties.Resources.back_aqua;
            }
            else
            {
                foreach (Control ctrl in form.Controls)
                {
                    if (ctrl is Button)
                    {
                        (ctrl as Button).FlatAppearance.MouseDownBackColor = Color.Chocolate;
                    }
                }
                form.BackgroundImage = Properties.Resources.back_wood;
            }
        }
    }
}
