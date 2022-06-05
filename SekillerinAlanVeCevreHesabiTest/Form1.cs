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
            comboShape.Items.Add("Üçgen");
            comboShape.Items.Add("Dörtgen");
            comboShape.Items.Add("Çember");
            comboShape.SelectedIndex = 0;

            comboProc.Items.Clear();
            comboProc.Items.Add("Alan Hesapla");
            comboProc.Items.Add("Çevre Hesapla");
            comboProc.SelectedIndex = 0;
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            ISekil shape1;
            double tabanLength = (double)numValue1.Value;
            double height = (double)numValue2.Value;

            if (comboShape.SelectedIndex == 0)
            {

                shape1 = new Ucgen(tabanLength, height);

                if (comboProc.SelectedIndex == 0)
                {
                    lbltTot.Text = "Total Alan : " + shape1.AlanHesabi().ToString();
                }

                else if (comboProc.SelectedIndex == 1)
                {
                    lbltTot.Text = "Üçgenin Total Çevresi Hesaplanamamaktadýr.";
                }
            }

            else if (comboShape.SelectedIndex == 1)
            {
                shape1 = new Dortgen(tabanLength, height);

                if (comboProc.SelectedIndex == 0)
                {
                    lbltTot.Text = "Total Alan : " + shape1.AlanHesabi().ToString();
                }

                else if (comboProc.SelectedIndex == 1)
                {
                    lbltTot.Text = "Total Çevre : " + shape1.CevreHesabi().ToString();
                }
            }

            else if (comboShape.SelectedIndex == 2)
            {
                shape1 = new Circle(tabanLength);

                if (comboProc.SelectedIndex == 0)
                {
                    lbltTot.Text = "Total Alan : " + shape1.AlanHesabi().ToString();
                }

                else if (comboProc.SelectedIndex == 1)
                {
                    lbltTot.Text = "Total Çevre : " + shape1.CevreHesabi().ToString();
                }
            }

            else
                throw new NotSupportedException();
        }

        private void comboShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboShape.SelectedIndex == 2)
            {
                label4.Text = "Yarýçap : ";
                label3.Visible = false;
                numValue2.Visible = false;
            }

            else
            {
                label4.Text = "Taban Length : ";
                label3.Visible = true;
                numValue2.Visible = true;
            }
        }
    }
}