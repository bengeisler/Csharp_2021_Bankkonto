using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2021_Bankkonto
{
	class Konto
	{
		// Bonus: Kontoauszug
		private string kontoauszug;

		// Eigenschaft Kontostand
		private double kontostand;

		// zugehörige Eigenschaftsmethode
		public double Kontostand
		{
			get { return kontostand; }
			private set 
			{
				if (value < 0) throw new Exception("Kontostand ist nicht gedeckt!");
				kontostand = value; 
			}
		}

		// Methode Einzahlen
		public void Einzahlen(double betrag)
		{
			Kontostand += betrag;

			// Bonus: Kontoauszug mitschreiben
			kontoauszug += " + " + betrag + " €" + "\n";
		}

		// Methode Auszahlen
		public void Auszahlen(double betrag)
		{
			Kontostand -= betrag;

			// Bonus: Kontoauszug mitschreiben
			kontoauszug += "  - " + betrag + " €" + "\n";
		}

		// Methode Kontostand ausgeben
		public string KontostandAnzeigen()
		{
			return "Kontostand: " + Kontostand + " €";
		}

		// Bonus: Kontoauszug erstellen
		public string KontoauszugDrucken()
		{
			return "Kontoauszug:\n" +
				kontoauszug +
				"-------------------\n" +
				+ kontostand + " €";

		}

	}
}
