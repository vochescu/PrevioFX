using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Entities
{
    public class Constante
    {
        public static String CONNECTION_STRING = "Data Source=Anca-PC;Initial Catalog = PrevizionareBD; Integrated Security = True";
        public static CultureInfo PROVIDER = CultureInfo.InvariantCulture;

        public static String EROARE_SIMBOL = "Simbolul nu este corect!";
        public static String EROARE_DENUMIRE = "Denumirea nu este corectă!";

        public static String EROARE_DATA = "Data nu este corectă!";
        public static String EROARE_OPEN = "Prețul open nu este corect!";
        public static String EROARE_HIGH = "Prețul high nu este corect!";
        public static String EROARE_LOW = "Prețul low nu este corect!";
        public static String EROARE_CLOSE = "Prețul close nu este corect!";
        public static String EROARE_SELECTARE_PERECHE_VALUTARA = "Selectați o pereche valutară!";
        public static String EROARE_SELECTARE_RAND_TABEL = "Selectați un rând din tabel!";

        public static String EROARE_DATE_PERECHI_VALUTARE = "Date lipsă pentru perechea valutară selectată!";
        public static String EROARE_CREARE_MASINA_FARA_DATE = "Selectați date pentru a începe.";

        public static String MESAJ_VIZUALIZARE_INAINTE_DE_PRINT = "Vizualizati datele și apoi revenți pentru a printa";
        public static String DATASET_NAME_PERECHI_VALUTARE = "PerechiValutare";
        public static String DB_EROARE_SELECT_PERECHI_VALUTARE = "Eroare selectare perechi valutare";

    }
}
