


namespace FrmGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenci_detay frm = new ogrenci_detay();
            frm.Numara = maskedTextBox1.Text; // �nce maskedTextBox'taki de�eri Numara �zelli�ine ata, sonra formu g�ster
            frm.Show();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
