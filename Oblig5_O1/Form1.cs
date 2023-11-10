using System.Linq.Expressions;

namespace Oblig5_O1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double Saldo = 0;
        double bel�p = 0;
        bool SettInn = false;
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
            if (Autentifisert == true) //Skift tilbake til == n�r koding er ferdig, ment for � komme seg fortere gjennom
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
                MessageBox.Show("Feil bruker, pr�v igjen");
            }

        }

        private void btnLoggUt_Click(object sender, EventArgs e)
        {
            Banken Loggut = new Banken();
            Loggut.LoggeUt();
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
                string SettInnBel�p = txtSet.Text;
                bel�p = Convert.ToDouble(SettInnBel�p);
                bankhandlinger.SettInPenger(bel�p);
                txtSet.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input av bel�p er ugyldig, pr�v igjen " + ex.Message);
                txtSet.Clear();
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            try
            {
                string TaUtBel�p = txtGet.Text;
                bel�p = Convert.ToDouble(TaUtBel�p);

                if (bel�p < 0)
                {
                    MessageBox.Show("Du kan ikke ta ut negative verdier, pr�v igjen");

                }
                else if (bankhandlinger.TaUtPenger(bel�p) == true)
                {
                    MessageBox.Show("Uttak er gyldig " + Convert.ToString(bel�p) + " NOK sendes ut");
                    bankhandlinger.SaldoUpdate = bankhandlinger.SaldoUpdate - bel�p;
                }

                else
                {
                    MessageBox.Show("Du har ikke dette bel�pet p� konto, og kan dermed ikke ta ut disse pengene. Om du fortsatt �nsker � ta ut penger vennligst sjekk saldo og ta ut et bel�p som du har");
                }
                txtGet.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input av bel�p er ugyldig, pr�v igjen " + ex.Message);
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