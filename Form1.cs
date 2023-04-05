using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezbe3
{
    public partial class Form1 : Form
    {
        Clan nov;
        List<Clan> listaClanova;

        public Form1()
        {
            InitializeComponent();
            listaClanova = new List<Clan>();
        }

        private string citajSport()
        {
            string pom = "";

            foreach (string s in chlbSport.CheckedItems)
            {
                pom += " " + s + ";";
            }

            return pom;
        }

        private void resetuj()
        {
            tbIme.Clear();

            for (int i = 0; i < this.chlbSport.Items.Count; i++)
                this.chlbSport.SetItemChecked(i, false);

            mtbTelefon.Clear();

            lbSpisak.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetuj();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbIme.Text != "" && chlbSport.CheckedItems.Count > 0
                && mtbTelefon.Text != "")
            {
                nov = new Clan();
                nov.Ime = tbIme.Text;
                nov.Sport = citajSport();
                nov.Telefon = mtbTelefon.Text;

                listaClanova.Add(nov);
                MessageBox.Show("Uspesan unos novog clana", "Obavestenje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                resetuj();
            }
            else
            {
                MessageBox.Show("Sva polja su obavezna", "Obavestenje", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
