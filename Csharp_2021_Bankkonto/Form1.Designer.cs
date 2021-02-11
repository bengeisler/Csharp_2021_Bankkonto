
namespace Csharp_2021_Bankkonto
{
	partial class frmKonto
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtBetrag = new System.Windows.Forms.TextBox();
			this.btnEinzahlen = new System.Windows.Forms.Button();
			this.btnAuszahlen = new System.Windows.Forms.Button();
			this.btnKontostand = new System.Windows.Forms.Button();
			this.btnKontoauszug = new System.Windows.Forms.Button();
			this.lblKontoauszug = new System.Windows.Forms.Label();
			this.lblKontostand = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Betrag:";
			// 
			// txtBetrag
			// 
			this.txtBetrag.Location = new System.Drawing.Point(84, 26);
			this.txtBetrag.Name = "txtBetrag";
			this.txtBetrag.Size = new System.Drawing.Size(100, 20);
			this.txtBetrag.TabIndex = 1;
			// 
			// btnEinzahlen
			// 
			this.btnEinzahlen.Location = new System.Drawing.Point(23, 73);
			this.btnEinzahlen.Name = "btnEinzahlen";
			this.btnEinzahlen.Size = new System.Drawing.Size(75, 23);
			this.btnEinzahlen.TabIndex = 2;
			this.btnEinzahlen.Text = "Einzahlen";
			this.btnEinzahlen.UseVisualStyleBackColor = true;
			this.btnEinzahlen.Click += new System.EventHandler(this.btnEinzahlen_Click);
			// 
			// btnAuszahlen
			// 
			this.btnAuszahlen.Location = new System.Drawing.Point(108, 72);
			this.btnAuszahlen.Name = "btnAuszahlen";
			this.btnAuszahlen.Size = new System.Drawing.Size(75, 23);
			this.btnAuszahlen.TabIndex = 3;
			this.btnAuszahlen.Text = "Auszahlen";
			this.btnAuszahlen.UseVisualStyleBackColor = true;
			this.btnAuszahlen.Click += new System.EventHandler(this.btnAuszahlen_Click);
			// 
			// btnKontostand
			// 
			this.btnKontostand.Location = new System.Drawing.Point(67, 126);
			this.btnKontostand.Name = "btnKontostand";
			this.btnKontostand.Size = new System.Drawing.Size(75, 23);
			this.btnKontostand.TabIndex = 4;
			this.btnKontostand.Text = "Kontostand";
			this.btnKontostand.UseVisualStyleBackColor = true;
			this.btnKontostand.Click += new System.EventHandler(this.btnKontostand_Click);
			// 
			// btnKontoauszug
			// 
			this.btnKontoauszug.Location = new System.Drawing.Point(59, 164);
			this.btnKontoauszug.Name = "btnKontoauszug";
			this.btnKontoauszug.Size = new System.Drawing.Size(90, 40);
			this.btnKontoauszug.TabIndex = 5;
			this.btnKontoauszug.Text = "Kontoauszug drucken";
			this.btnKontoauszug.UseVisualStyleBackColor = true;
			this.btnKontoauszug.Click += new System.EventHandler(this.btnKontoauszug_Click);
			// 
			// lblKontoauszug
			// 
			this.lblKontoauszug.AutoSize = true;
			this.lblKontoauszug.Location = new System.Drawing.Point(39, 221);
			this.lblKontoauszug.Name = "lblKontoauszug";
			this.lblKontoauszug.Size = new System.Drawing.Size(35, 13);
			this.lblKontoauszug.TabIndex = 6;
			this.lblKontoauszug.Text = "label2";
			// 
			// lblKontostand
			// 
			this.lblKontostand.AutoSize = true;
			this.lblKontostand.Location = new System.Drawing.Point(67, 107);
			this.lblKontostand.Name = "lblKontostand";
			this.lblKontostand.Size = new System.Drawing.Size(35, 13);
			this.lblKontostand.TabIndex = 7;
			this.lblKontostand.Text = "label2";
			// 
			// frmKonto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(222, 351);
			this.Controls.Add(this.lblKontostand);
			this.Controls.Add(this.lblKontoauszug);
			this.Controls.Add(this.btnKontoauszug);
			this.Controls.Add(this.btnKontostand);
			this.Controls.Add(this.btnAuszahlen);
			this.Controls.Add(this.btnEinzahlen);
			this.Controls.Add(this.txtBetrag);
			this.Controls.Add(this.label1);
			this.Name = "frmKonto";
			this.Text = "Konto verwalten";
			this.Load += new System.EventHandler(this.frmKonto_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtBetrag;
		private System.Windows.Forms.Button btnEinzahlen;
		private System.Windows.Forms.Button btnAuszahlen;
		private System.Windows.Forms.Button btnKontostand;
		private System.Windows.Forms.Button btnKontoauszug;
		private System.Windows.Forms.Label lblKontoauszug;
		private System.Windows.Forms.Label lblKontostand;
	}
}

