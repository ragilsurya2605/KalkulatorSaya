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
    public partial class Form1 : Form
    {
        private List<Calculator> listofCalculator = new List<Calculator>();

        public Form1()
        {
            InitializeComponent();
            InisialisasiListView();
        }
        private void InisialisasiListView()
        {
            ListPerhitungan.View = View.Details;
            ListPerhitungan.Columns.Add("", 5, HorizontalAlignment.Left);
            ListPerhitungan.Columns.Add("", 150, HorizontalAlignment.Left);
        }

        private void FormView(Calculator cal)
        {
            listofCalculator.Add(cal);
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(cal.Hasil);
            ListPerhitungan.Items.Add(item);
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2("Calculator");
            form.OnCal += FormView;
            form.ShowDialog();
        }
    }
}
