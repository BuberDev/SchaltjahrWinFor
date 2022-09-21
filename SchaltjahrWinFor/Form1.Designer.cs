
namespace SchaltjahrWinFor
{
    partial class Schaltjahr
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
            this.SchaltListe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeinSchaltList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textJahr = new System.Windows.Forms.TextBox();
            this.PrüfenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SchaltListe
            // 
            this.SchaltListe.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchaltListe.FormattingEnabled = true;
            this.SchaltListe.ItemHeight = 23;
            this.SchaltListe.Location = new System.Drawing.Point(13, 71);
            this.SchaltListe.Name = "SchaltListe";
            this.SchaltListe.Size = new System.Drawing.Size(213, 441);
            this.SchaltListe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Schaltjahr";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kein Schaltjahr";
            // 
            // KeinSchaltList
            // 
            this.KeinSchaltList.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeinSchaltList.FormattingEnabled = true;
            this.KeinSchaltList.ItemHeight = 23;
            this.KeinSchaltList.Location = new System.Drawing.Point(607, 71);
            this.KeinSchaltList.Name = "KeinSchaltList";
            this.KeinSchaltList.Size = new System.Drawing.Size(221, 441);
            this.KeinSchaltList.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gib dein Jahr ein:";
            // 
            // textJahr
            // 
            this.textJahr.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textJahr.Location = new System.Drawing.Point(265, 180);
            this.textJahr.Multiline = true;
            this.textJahr.Name = "textJahr";
            this.textJahr.Size = new System.Drawing.Size(283, 46);
            this.textJahr.TabIndex = 5;
            this.textJahr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textJahr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textJahr_KeyPress);
            // 
            // PrüfenBtn
            // 
            this.PrüfenBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrüfenBtn.Location = new System.Drawing.Point(322, 288);
            this.PrüfenBtn.Name = "PrüfenBtn";
            this.PrüfenBtn.Size = new System.Drawing.Size(165, 99);
            this.PrüfenBtn.TabIndex = 6;
            this.PrüfenBtn.Text = "Prüfen";
            this.PrüfenBtn.UseVisualStyleBackColor = true;
            this.PrüfenBtn.Click += new System.EventHandler(this.PrüfenBtn_Click);
            // 
            // Schaltjahr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 539);
            this.Controls.Add(this.PrüfenBtn);
            this.Controls.Add(this.textJahr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeinSchaltList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SchaltListe);
            this.Name = "Schaltjahr";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox SchaltListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox KeinSchaltList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textJahr;
        private System.Windows.Forms.Button PrüfenBtn;
    }
}

