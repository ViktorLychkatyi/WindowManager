namespace WindowManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");
            //label1.BackColor = Color.Transparent;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterScreen;
            form2.Show();

            this.Hide();
            form2.FormClosed += (s, args) => this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
