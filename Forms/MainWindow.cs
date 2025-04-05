using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowManager
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadWindows();
            this.Text = "Выберите нужное окно";
        }

        private void LoadWindows()
        {
            listBox1.Items.Clear();
            DllImports.EnumWindows((hWnd, lParam) =>
            {
                if (DllImports.IsWindowVisible(hWnd))
                {
                    StringBuilder windowText = new StringBuilder(256);
                    DllImports.GetWindowText(hWnd, windowText, windowText.Capacity);
                    string windowName = windowText.ToString();
                    if (!string.IsNullOrEmpty(windowName))
                    {
                        listBox1.Items.Add(windowName);
                    }
                }
                return true;
            }, IntPtr.Zero);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWindowName = listBox1.SelectedItem.ToString();

            Menu menu = new Menu(selectedWindowName);
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
