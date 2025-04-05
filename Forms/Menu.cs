using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowManager.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowManager
{
    public partial class Menu : Form
    {
        public string windowName;

        public Menu(string windowName)
        {
            InitializeComponent();
            this.Text = "Выберите действие окна";
            this.windowName = windowName;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveWindowForm moveWindowForm = new MoveWindowForm(windowName);
            moveWindowForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = DllImports.FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                DllImports.ShowWindow(hWnd, 1);
            }
            else
            {
                MessageBox.Show("Окно не найдено.");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            IntPtr hWnd = DllImports.FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                DllImports.ShowWindow(hWnd, 2);
            }
            else
            {
                MessageBox.Show("Окно не найдено.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            const uint WM_CLOSE = 0x0010;
            IntPtr hWnd = DllImports.FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                DllImports.PostMessage(hWnd, 0x0010, IntPtr.Zero, IntPtr.Zero);
            }
            else
            {
                MessageBox.Show("Окно не найдено.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeNameWindow changeWindowForm = new ChangeNameWindow(windowName);
            changeWindowForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MainWindow menu = new MainWindow();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.Show();

            this.Hide();
            menu.FormClosed += (s, args) => this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
