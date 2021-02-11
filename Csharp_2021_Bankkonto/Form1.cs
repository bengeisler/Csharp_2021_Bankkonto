using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_2021_Bankkonto
{
	public partial class frmKonto : Form
	{
		private Konto meinKonto;
		public frmKonto()
		{
			InitializeComponent();
		}

		private void btnEinzahlen_Click(object sender, EventArgs e)
		{
			try
			{
				if (!double.TryParse(txtBetrag.Text, out double betrag))
					throw new ArgumentException("Bitte gültige Zahl eingeben!");

				meinKonto.Einzahlen(betrag);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void frmKonto_Load(object sender, EventArgs e)
		{
			meinKonto = new Konto();
		}

		private void btnAuszahlen_Click(object sender, EventArgs e)
		{
			try
			{
				if (!double.TryParse(txtBetrag.Text, out double betrag))
					throw new ArgumentException("Bitte gültige Zahl eingeben!");

				meinKonto.Auszahlen(betrag);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnKontoauszug_Click(object sender, EventArgs e)
		{
			lblKontoauszug.Text = meinKonto.KontoauszugDrucken();
		}

		private void btnKontostand_Click(object sender, EventArgs e)
		{
			lblKontostand.Text = meinKonto.KontostandAnzeigen();
		}
	}
}
