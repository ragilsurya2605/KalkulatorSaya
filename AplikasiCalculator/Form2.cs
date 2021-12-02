using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiCalculator
{
    public partial class Form2 : Form
    {
        public delegate void CreateUpdateEventHandler(Calculator cal);
        public event CreateUpdateEventHandler OnCal;
        public Calculator cal;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string tittle)
            : this()
        {
            this.Text = tittle;
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            Double nilai1, nilai2, hasil;
            Calculator cal = new Calculator();
            int a = Convert.ToInt32(NilaiA.Text);
            int b = Convert.ToInt32(NilaiB.Text);
            
            if (this.Operasi.SelectedIndex == -1)
            {
                MessageBox.Show("Operasi Belum Dipilih");
            }
            else if (this.Operasi.SelectedIndex == 0)
            {
                nilai1 = Double.Parse(NilaiA.Text);
                nilai2 = Double.Parse(NilaiB.Text);
                hasil = nilai1 + nilai2;
                Hasil.Text = hasil.ToString();
            }
            else if (this.Operasi.SelectedIndex == 1)
            {
                nilai1 = Double.Parse(NilaiA.Text);
                nilai2 = Double.Parse(NilaiB.Text);
                hasil = nilai1 - nilai2;
                Hasil.Text = hasil.ToString();
            }
            else if (this.Operasi.SelectedIndex == 2)
            {
                nilai1 = Double.Parse(NilaiA.Text);
                nilai2 = Double.Parse(NilaiB.Text);
                hasil = nilai1 / nilai2;
                Hasil.Text = hasil.ToString();
            }
            else if (this.Operasi.SelectedIndex == 3)
            {
                nilai1 = Double.Parse(NilaiA.Text);
                nilai2 = Double.Parse(NilaiB.Text);
                hasil = nilai1 * nilai2;
                Hasil.Text = hasil.ToString();
            }
            if (this.Operasi.SelectedIndex == 0)
                cal.Hasil = string.Format("{0} + {1} = {2}", a, b, a + b);

            if (this.Operasi.SelectedIndex == 1)
                cal.Hasil = string.Format("{0} - {1} = {2}", a, b, a - b);           

            if (this.Operasi.SelectedIndex == 2)
                cal.Hasil = string.Format("{0} / {1} = {2}", a, b, a / b);

            if (this.Operasi.SelectedIndex == 3)
                cal.Hasil = string.Format("{0} x {1} = {2}", a, b, a * b);

            OnCal(cal);            
        }
    }
}
