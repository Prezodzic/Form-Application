using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrmGiris
{
    public partial class ogrenci_detay : Form
    {
        private string numara;
        private SqlConnection baglanti;

        public string Numara
        {
            get { return numara; }
            set { numara = value; }
        }

        public ogrenci_detay()
        {
            InitializeComponent();
            numara = string.Empty; // Initialize numara to avoid CS8618
            baglanti = new SqlConnection(@"Data Source=LAPTOP-84GEUI6J\SQLEXPRESS;Initial Catalog=Ogrenciler;Integrated Security=True");
        }

        public ogrenci_detay(string numara)
        {
            InitializeComponent();
            this.numara = numara; // Initialize numara to avoid CS8618
            baglanti = new SqlConnection(@"Data Source=LAPTOP-84GEUI6J\SQLEXPRESS;Initial Catalog=Ogrenciler;Integrated Security=True");
        }

        private void ogrenci_detay_Load(object sender, EventArgs e)
        {
            label9.Text = Numara;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            // label9 tıklama olayı için kod buraya gelecek
        }
    }
}