using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_W5
{
    public partial class FormMateri : Form
    {
        public void CekWarna()
        {
            if (cBoxAktif.Checked)
                if (rButtMerah.Checked)
                    labelTulisan.ForeColor = Color.Red;
                else if (rButtBiru.Checked)
                    labelTulisan.ForeColor = Color.Blue;
            else
                labelTulisan.ForeColor = Color.Black;
        }
        public FormMateri()
        {
            InitializeComponent();
        }

        private void lBoxKoleksi_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelTulisan.Text = lBoxKoleksi.SelectedItem.ToString();
        }

        private void FormMateri_Load(object sender, EventArgs e)
        {
            lBoxKoleksi.Items.Clear();
            rButtMerah.Checked = true;
            labelTulisan.Text = "";
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            if (lBoxKoleksi.Items.Contains(tBoxData.Text))
                MessageBox.Show("Input Kembar");
            else
                lBoxKoleksi.Items.Add(tBoxData.Text);
        }

        private void cBoxAktif_CheckedChanged(object sender, EventArgs e)
        {
            CekWarna();
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            cBoxAktif.Checked = false;
            labelTulisan.ForeColor = Color.Black;
            labelTulisan.Text = "";
            lBoxKoleksi.Items.Clear();
            rButtMerah.Checked = true;
            tBoxData.Text = "";
        }

        private void rButtMerah_CheckedChanged(object sender, EventArgs e)
        {
            CekWarna();
        }

        private void rButtBiru_CheckedChanged(object sender, EventArgs e)
        {
            CekWarna();
        }
    }
}
