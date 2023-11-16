using System.Linq.Expressions;

namespace Oblig5_O1
{
    //Samarbeid mellom Kristoffer Rød Huseby, Kristian Lande, Albert Haugland Kristiansen
    //Klasser som er implementert er Banken.cs og Kunde.cs. Kunde.cs holder på informasjonen til kunden i banken, og kun det. Den er bare ment
    //for å returnere kunden sin innlogging. Banken.cs har et par flere funksjoner derimot, den implementerer alle funksjoner som interface
    //IBankOperasjoner har som er: Loggeut, Tautpenger, Settinnpenger, Saldo, Saldoupdate og Autentifisere. 
    //Banken.cs brukes for alle funksjonene som banken har som listet og brukes for å operere alle funksjonene banken har.
    //Autentifisere er klassen som sjekker om innlogging som kunde har skrevet inn matcher med systemet sin lagrede innlogging, og returnerer
    //en bool basert på om du har skrevet inn riktig innlogging eller ikke
    //Loggeut lar deg loggeut av systemet og er for å shutte ned programmet
    //TaUtPenger sjekker om du har nok på saldo til å ta ut beløpet du ønsker, som returnerer da en bool til hovedprogrammet
    //Settinnpenger tar beløpet som kunden har skrevet inn og setter det inn på kontoen. Det skjer i klassen
    //Saldo returnerer saldoen som kunden har på kontoen sin og displayer det til kunden
    //Saldoupdate brukes for å kunne oppdatere saldoen til kunden utenfor klassen, siden saldoen er en private i klassen. Dermed er det et 
    //tilgangsmedlem slik at en kan oppdatere saldoen i hovedprogrammet
    //Både i klassen og hovedprogrammet er det lagt til failsafer slik at viss det blir skrevet inn et negativt tall eller en bokstav
    //istedet for et tall som er gyldig vil kunden bli opplyst om dette og blir bedt om å skrive det inn på nytt. På den måten kræsjer
    //ikke programmet men vil opplyse om hva kunden har gjort galt. 

    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double Saldo = 0;
        double beløp = 0;
        Banken bankhandlinger = new Banken();


        public Form1()
        {
            //I starten gjømmes alle knapper, labels og tekstbokser som ikke brukes før kunden har logget inn
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
            txtAutentifisere.PasswordChar = '*'; //Maskerer hva bruker skriver inn for å logge inn
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
                //Oppdaterer nå hvilken labels som skal gjemmes eller vises i formen 
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
            //Tilbake knappen brukes når kunden er inne på en av menyene, for å gjøre det universelt for alle menyene så gjømmes
            //alle labels, tekstbokser og knapper siden vi ikke vet hvilken meny kunder er på, og viser da hovedmenyen på nytt lenger nede
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
            //Her brukes try catch for å eliminere om kunde skriver inn en bokstav
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
            //Her brukes try catch for å eliminere om kunde skriver inn en bokstav
            try
            {
                string TaUtBeløp = txtGet.Text;
                beløp = Convert.ToDouble(TaUtBeløp);

                if (beløp < 0) //Om kunden skriver et negativt beløp så kan ikke det tas ut og blir bedt om å prøve igjen
                {
                    MessageBox.Show("Du har valgt et negativt tall som ikke er mulig, prøv igjen", "Feilmelding #C2");

                }
                else if (bankhandlinger.TaUtPenger(beløp) == true) //Om det skrives inn et tall som aksepteres så tas det ut penger
                {
                    MessageBox.Show("Uttak er gyldig " + Convert.ToString(beløp) + " NOK sendes ut", "Uttak");
                    bankhandlinger.SaldoUpdate = bankhandlinger.Saldo() - beløp;
                }

                else //Om det er et beløp de ikke har på konto så blir de opplyst om dette
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
            //Viser menyen for å ta ut penger
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
            //Viser saldo til kunde på skjerm
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