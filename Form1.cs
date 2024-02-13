using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futoverseny
{
    public partial class Form1 : Form
    {
        public static string fajlnev {get; set;}
        public static List<Futo> lista = new List<Futo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuKilep_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuMegnyit_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                btnAdatbe.Enabled = true;
                fajlnev = openFileDialog1.FileName;
            }
        }

        private void btnAdatbe_Click(object sender, EventArgs e)
        {
            mnuEredmenyLista.Enabled = true;
            //var sr = new StreamReader(fajlnev);
            var sr = new StreamReader("futok.txt");
            while (!sr.EndOfStream)
            {
                lista.Add(new Futo(sr.ReadLine()));
            }
            sr.Close();

            foreach (var sor in lista)
            {
                listBox1.Items.Add(sor.Nev);
            }
            btnAdatbe.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRajtszam.Text = lista[listBox1.SelectedIndex].Rajtszam;
            txtOrszag.Text = lista[listBox1.SelectedIndex].Orszag;
            txtIdoeredmeny.Text = lista[listBox1.SelectedIndex].Eredmeny;
            //txtEletkor.Text = (DateTime.Today.Year - lista[listBox1.SelectedIndex].Szulido.Year).ToString();
            int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(lista[listBox1.SelectedIndex].Szulido.ToString("yyyyMMdd"));
            int age = (now - dob) / 10000;
            txtEletkor.Text = age.ToString();
        }

        private void mnuEredmenyLista_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eredmenylista eredmenylista = new Eredmenylista();
            eredmenylista.ShowDialog();
            eredmenylista.Dispose();
            this.Show();
        }
    }
}
