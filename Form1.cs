


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
            frm.Numara = maskedTextBox1.Text; // önce maskedTextBox'taki deðeri Numara özelliðine ata, sonra formu göster
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
