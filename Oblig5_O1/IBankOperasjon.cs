using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oblig5_O1
{
    internal interface IBankOperasjon
    {
        bool Autentifisere(String bruker);

        void LoggeUt();

        void SettInPenger(double beløp);

        bool TaUtPenger(double beløp);

        double Saldo();
    }
}
