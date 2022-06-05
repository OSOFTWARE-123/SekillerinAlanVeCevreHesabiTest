namespace SekillerinAlanVeCevreHesabiTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cox.Items.Clear();
            cox.Items.Add("Üçgen");
            cox.Items.Add("Dörtgen");
        }
    }
}