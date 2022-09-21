using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchaltjahrWinFor
{
    public partial class Schaltjahr : Form
    {
        public Schaltjahr()
        {
            InitializeComponent();
        }

        private void PrüfenBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textJahr.Text) ||
                int.Parse(textJahr.Text) <= 0)
            {
                MessageBox.Show("Gib ein Jahr ein!", "Leer feld",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Textfeld leeren
                // Textfeld fokus aktivieren
                textJahr.Clear();
                ActiveControl = textJahr;
                return;
            }


            if (int.Parse(textJahr.Text) % 100 == 0)
            {
                if (int.Parse(textJahr.Text) % 400 == 0)
                {
                    SchaltListe.Items.Add(textJahr.Text);
                }
                else
                {
                    KeinSchaltList.Items.Add(textJahr.Text);
                }
            }
            else if (int.Parse(textJahr.Text) % 4 == 0)
            {
                SchaltListe.Items.Add(textJahr.Text);
            }
            else
            {
                KeinSchaltList.Items.Add(textJahr.Text);
            }
        }

        private void textJahr_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            

        }
    }
}
