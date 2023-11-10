using System.Linq.Expressions;

namespace Oblig5_O1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double Saldo = 0;
        double beløp = 0;
        Banken bankhandlinger = new Banken();

        public Form1()
        {
            InitializeComponent();
            lbHandling.Hide();
            btnGet.Hide();
            btnSet.Hide();
            txtGet.Hide();
            txtSaldo.Hide();
            txtSet.Hide();
            btnTilbake.Hide();
            btnSettInnPenger.Hide();
            btnSjekkSaldo.Hide();
            btnTaUtPenger.Hide();
            btnLoggUt.Hide();
            lbSaldo.Hide();
            lbBelopSet.Hide();
            lbBelopGet.Hide();
            lbBelopInnskudd.Hide();
            lbBelopUttak.Hide();
            Saldo = rnd.Next(0, 100000);
            bankhandlinger.SaldoUpdate = Saldo;

        }


        private void btnAutentifisere_Click(object sender, EventArgs e)
        {
            String input = txtAutentifisere.Text;
            bool Autentifisert = false;
            Autentifisert = bankhandlinger.Autentifisere(input);
            if (Autentifisert == true) //Skift tilbake til == når koding er ferdig, ment for å komme seg fortere gjennom
            {
                btnSettInnPenger.Show();
                btnTaUtPenger.Show();
                btnLoggUt.Show();
                btnSjekkSaldo.Show();
                lbHandling.Show();
                btnAutentifisere.Hide();
                txtAutentifisere.Hide();
            }
            else
            {
                txtAutentifisere.Clear();
                MessageBox.Show("Feil bruker, prøv igjen", "Feilmelding #C1");
            }

        }

        private void btnLoggUt_Click(object sender, EventArgs e)
        {
            bankhandlinger.LoggeUt();
        }

        private void btnSettInnPenger_Click(object sender, EventArgs e)
        {
            btnSettInnPenger.Hide();
            btnTaUtPenger.Hide();
            btnLoggUt.Hide();
            btnSjekkSaldo.Hide();
            btnSet.Show();
            btnTilbake.Show();
            txtSet.Show();
            lbBelopSet.Show();
            lbBelopInnskudd.Show();

        }

        private void btnTilbake_Click(object sender, EventArgs e)
        {
            foreach (var lb in Controls.OfType<Label>())
            {
                lb.Hide();
            }
            foreach (var btn in Controls.OfType<Button>())
            {
                btn.Hide();
            }
            foreach (var txt in Controls.OfType<TextBox>())
            {
                txt.Hide();
            }
            btnSettInnPenger.Show();
            btnSjekkSaldo.Show();
            btnLoggUt.Show();
            btnTaUtPenger.Show();
            lbVelkommen.Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                string SettInnBeløp = txtSet.Text;
                beløp = Convert.ToDouble(SettInnBeløp);
                bankhandlinger.SettInPenger(beløp);
                txtSet.Clear();
            }
            catch
            {
                string feilmelding = "Feilmelding #C3";
                string message = "Du har skrevet inn noe som ikke er et tall, prøv igjen";
                MessageBox.Show(message, feilmelding);
                txtSet.Clear();
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                string TaUtBeløp = txtGet.Text;
                beløp = Convert.ToDouble(TaUtBeløp);

                if (beløp < 0)
                {
                    MessageBox.Show("Du har valgt et negativt tall som ikke er mulig, prøv igjen", "Feilmelding #C2");

                }
                else if (bankhandlinger.TaUtPenger(beløp) == true)
                {
                    MessageBox.Show("Uttak er gyldig " + Convert.ToString(beløp) + " NOK sendes ut", "Uttak");
                    bankhandlinger.SaldoUpdate = bankhandlinger.Saldo() - beløp;
                }

                else
                {
                    MessageBox.Show("Du har ikke dette beløpet på konto, og kan dermed ikke ta ut disse pengene. Om du fortsatt ønsker å ta ut penger vennligst sjekk saldo og ta ut et beløp som du har", "Feilmelding #C4");
                }
                txtGet.Clear();
            }
            catch
            {
                MessageBox.Show("Input av beløp er ugyldig, prøv igjen ", "Feilmelding #C3");
            }
        }

        private void btnTaUtPenger_Click(object sender, EventArgs e)
        {
            btnSettInnPenger.Hide();
            btnTaUtPenger.Hide();
            btnLoggUt.Hide();
            btnSjekkSaldo.Hide();
            btnGet.Show();
            btnTilbake.Show();
            txtGet.Show();
            lbBelopGet.Show();
            lbBelopUttak.Show();
        }

        private void btnSjekkSaldo_Click(object sender, EventArgs e)
        {
            btnSettInnPenger.Hide();
            btnTaUtPenger.Hide();
            btnLoggUt.Hide();
            btnSjekkSaldo.Hide();
            lbSaldo.Show();
            txtSaldo.Show();
            btnTilbake.Show();
            txtSaldo.Text = Convert.ToString(bankhandlinger.Saldo() + " NOK");
        }
    }
}