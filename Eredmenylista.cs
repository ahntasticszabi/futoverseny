using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futoverseny
{
    public partial class Eredmenylista : Form
    {
        public Eredmenylista()
        {
            InitializeComponent();
        }

        private void Eredmenylista_Load(object sender, EventArgs e)
        {
            var rendezett = Form1.lista.OrderByDescending(x => x.Eredmeny);

            foreach (var item in rendezett)
            {
                richTextBox1.Text += item.Nev + ' ' + item.Eredmeny + '\n';
            }
        }
    }
}
