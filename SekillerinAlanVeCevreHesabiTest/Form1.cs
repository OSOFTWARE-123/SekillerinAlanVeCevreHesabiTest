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
            comboShape.Items.Clear();
            comboShape.Items.Add("��gen");
            comboShape.Items.Add("D�rtgen");
            comboShape.SelectedIndex = 0;

            comboProc.Items.Clear();
            comboProc.Items.Add("Alan Hesapla");
            comboProc.Items.Add("�evre Hesapla");
            comboProc.SelectedIndex = 0;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            
        }
    }
}