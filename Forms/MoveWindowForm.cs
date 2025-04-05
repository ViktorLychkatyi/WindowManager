using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowManager
{
    public partial class MoveWindowForm : Form
    {
        public string windowName;

        public MoveWindowForm(string windowName)
        {
            InitializeComponent();
            this.Text = "Введите координаты и размеры окна";
            this.windowName = windowName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int width = int.Parse(textBox3.Text);
            int height = int.Parse(textBox4.Text);

            IntPtr hWnd = DllImports.FindWindow(null, windowName);
            if (hWnd != IntPtr.Zero)
            {
                DllImports.MoveWindow(hWnd, x, y, width, height, true);
            }
            else
            {
                MessageBox.Show("Окно не найдено.");
            }
        }

        private void MoveWindowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
