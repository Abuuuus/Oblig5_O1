using System.Linq.Expressions;

namespace Oblig5_O1
{
    //Samarbeid mellom Kristoffer R�d Huseby, Kristian Lande, Albert Haugland Kristiansen
    //Klasser som er implementert er Banken.cs og Kunde.cs. Kunde.cs holder p� informasjonen til kunden i banken, og kun det. Den er bare ment
    //for � returnere kunden sin innlogging. Banken.cs har et par flere funksjoner derimot, den implementerer alle funksjoner som interface
    //IBankOperasjoner har som er: Loggeut, Tautpenger, Settinnpenger, Saldo, Saldoupdate og Autentifisere. 
    //Banken.cs brukes for alle funksjonene som banken har som listet og brukes for � operere alle funksjonene banken har.
    //Autentifisere er klassen som sjekker om innlogging som kunde har skrevet inn matcher med systemet sin lagrede innlogging, og returnerer
    //en bool basert p� om du har skrevet inn riktig innlogging eller ikke
    //Loggeut lar deg loggeut av systemet og er for � shutte ned programmet
    //TaUtPenger sjekker om du har nok p� saldo til � ta ut bel�pet du �nsker, som returnerer da en bool til hovedprogrammet
    //Settinnpenger tar bel�pet som kunden har skrevet inn og setter det inn p� kontoen. Det skjer i klassen
    //Saldo returnerer saldoen som kunden har p� kontoen sin og displayer det til kunden
    //Saldoupdate brukes for � kunne oppdatere saldoen til kunden utenfor klassen, siden saldoen er en private i klassen. Dermed er det et 
    //tilgangsmedlem slik at en kan oppdatere saldoen i hovedprogrammet
    //B�de i klassen og hovedprogrammet er det lagt til failsafer slik at viss det blir skrevet inn et negativt tall eller en bokstav
    //istedet for et tall som er gyldig vil kunden bli opplyst om dette og blir bedt om � skrive det inn p� nytt. P� den m�ten kr�sjer
    //ikke programmet men vil opplyse om hva kunden har gjort galt. 

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double Saldo = 0;
        double bel�p = 0;
        Banken bankhandlinger = new Banken();


        public Form1()
        {
            //I starten gj�mmes alle knapper, labels og tekstbokser som ikke brukes f�r kunden har logget inn
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
            lbSaldo.Hide();
            lbBelopSet.Hide();
            lbBelopGet.Hide();
            btnLoggUt.Hide();
            lbBelopInnskudd.Hide();
            lbBelopUttak.Hide();
            txtAutentifisere.PasswordChar = '*'; //Maskerer hva bruker skriver inn for � logge inn
            txtAutentifisere.Focus();
            Saldo = rnd.Next(0, 100000); //Lager et random tall for saldoen til kunden
            bankhandlinger.SaldoUpdate = Saldo; //Oppdaterer saldoen til kunden gjennom tilgangsmedlemmet

        }


        private void btnAutentifisere_Click(object sender, EventArgs e)
        {
            String input = txtAutentifisere.Text;
            bool Autentifisert = false;
            Autentifisert = bankhandlinger.Autentifisere(input);
            if (Autentifisert == true) //Sjekker opp mot klassen om kunden har skrevet inn riktig innlogging
            {
                //Oppdaterer n� hvilken labels som skal gjemmes eller vises i formen 
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
                MessageBox.Show("Feil bruker, pr�v igjen", "Feilmelding #C1");
            }

        }

        private void btnLoggUt_Click(object sender, EventArgs e)
        {
            bankhandlinger.LoggeUt();
        }

        private void btnSettInnPenger_Click(object sender, EventArgs e)
        {
            //Oppdaterer labels, tekstbokser og knapper som skal vises
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
            //Tilbake knappen brukes n�r kunden er inne p� en av menyene, for � gj�re det universelt for alle menyene s� gj�mmes
            //alle labels, tekstbokser og knapper siden vi ikke vet hvilken meny kunder er p�, og viser da hovedmenyen p� nytt lenger nede
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
            //Her brukes try catch for � eliminere om kunde skriver inn en bokstav
            try
            {
                string SettInnBel�p = txtSet.Text;
                bel�p = Convert.ToDouble(SettInnBel�p);
                bankhandlinger.SettInPenger(bel�p);
                txtSet.Clear();
            }
            catch
            {
                string feilmelding = "Feilmelding #C3";
                string message = "Du har skrevet inn noe som ikke er et tall, pr�v igjen";
                MessageBox.Show(message, feilmelding);
                txtSet.Clear();
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            //Her brukes try catch for � eliminere om kunde skriver inn en bokstav
            try
            {
                string TaUtBel�p = txtGet.Text;
                bel�p = Convert.ToDouble(TaUtBel�p);

                if (bel�p < 0) //Om kunden skriver et negativt bel�p s� kan ikke det tas ut og blir bedt om � pr�ve igjen
                {
                    MessageBox.Show("Du har valgt et negativt tall som ikke er mulig, pr�v igjen", "Feilmelding #C2");

                }
                else if (bankhandlinger.TaUtPenger(bel�p) == true) //Om det skrives inn et tall som aksepteres s� tas det ut penger
                {
                    MessageBox.Show("Uttak er gyldig " + Convert.ToString(bel�p) + " NOK sendes ut", "Uttak");
                    bankhandlinger.SaldoUpdate = bankhandlinger.Saldo() - bel�p;
                }

                else //Om det er et bel�p de ikke har p� konto s� blir de opplyst om dette
                {
                    MessageBox.Show("Du har ikke dette bel�pet p� konto, og kan dermed ikke ta ut disse pengene. Om du fortsatt �nsker � ta ut penger vennligst sjekk saldo og ta ut et bel�p som du har", "Feilmelding #C4");
                }
                txtGet.Clear();
            }
            catch
            {
                MessageBox.Show("Input av bel�p er ugyldig, pr�v igjen ", "Feilmelding #C3");
            }
        }

        private void btnTaUtPenger_Click(object sender, EventArgs e)
        {
            //Viser menyen for � ta ut penger
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
            //Viser saldo til kunde p� skjerm
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