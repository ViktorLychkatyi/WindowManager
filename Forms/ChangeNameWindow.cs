using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowManager.Forms
{
    public partial class ChangeNameWindow : Form
    {
        public string windowName;

        public ChangeNameWindow(string windowName)
        {
            InitializeComponent();
            this.Text = "Измените названия окна";
            this.windowName = windowName;
        }

        private void ChangeNameWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr hWnd = DllImports.FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                DllImports.SetWindowText(hWnd, textBox1.Text);
                MessageBox.Show("Название окна изменено.");
            }
            else
            {
                MessageBox.Show("Окно не найдено.");
            }
        }
    }
}
