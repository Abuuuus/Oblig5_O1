using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Oblig5_O1
{
    internal class Banken : IBankOperasjon
    {
        private double saldo;
        Kunde Innlogging = new Kunde(); //Oppretter et nytt objekt for kunde for å hente ut innloggingen

        public void LoggeUt()
        {
            
            string message = "Vil du logge ut av banken?";
            string title = "Logg ut";
            MessageBoxButtons button  =  MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, button);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public bool Autentifisere(String bruker)
        {
            //Sjekk for å se om innlogging kunde skriver inn korresponderer med innloggingen i banken
            bool svar = false;
            if (bruker == Innlogging.Kundenavn())
            {
                svar = true;
            }
            else
            {
                svar = false;
            }
            return svar;
        }

        public void SettInPenger(double beløp)
        {
            //Her blir beløpet sendt inn for kunde og sjekket om det er et gyldig tall, om det er så blir saldo oppdatert
            if (beløp <= 0)
            {
                MessageBox.Show("Beløpet du har oppgit er ugyldig, og vi kan ikkje gjennomføre dette inskuddet", "Feilmelding #C2");
            }
            else
            {
                this.saldo = this.saldo + beløp;
                MessageBox.Show("Innskudded er gyldig, " + Convert.ToString(beløp) + " NOK er satt inn på konto");
            }
        }

        public double SaldoUpdate //Tilgangsmedlem for saldoen som brukes i hovedprogrammet for å oppdatere saldo
        {
            get { return saldo; } 
            
            set
            {
                if (saldo < 0)
                {
                    saldo = 0;
                }
                else
                {
                    saldo = value;
                }
            }
        }


        public bool TaUtPenger(double beløp)
        {
            //Sjekker her om kunden har beløpet de har skrevet inn er gyldig iforhold til saldoen 
            bool svar = false;
            if(beløp <= saldo)
            {
                svar = true;
            }
            else if (beløp < 0)
            {
                svar = false;
            }
            else { svar = false; }
            return svar;
        }

        public double Saldo()
        {
            //Returnerer saldoen til kunde
            double svar = this.saldo;
            return svar;
            
        }
    }
}
