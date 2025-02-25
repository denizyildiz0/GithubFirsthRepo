namespace GithubFirsthRepo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Deniz Yýldýz";

            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Hata");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
