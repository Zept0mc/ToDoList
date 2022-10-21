
namespace ToDoList.Controls
{
    partial class LoginControl
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWalidacjaLogowania = new System.Windows.Forms.Label();
            this.btnZalozKonto = new System.Windows.Forms.Button();
            this.btnZaloguj = new System.Windows.Forms.Button();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWalidacjaLogowania
            // 
            this.lblWalidacjaLogowania.AutoSize = true;
            this.lblWalidacjaLogowania.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWalidacjaLogowania.Location = new System.Drawing.Point(145, 270);
            this.lblWalidacjaLogowania.Name = "lblWalidacjaLogowania";
            this.lblWalidacjaLogowania.Size = new System.Drawing.Size(217, 18);
            this.lblWalidacjaLogowania.TabIndex = 13;
            this.lblWalidacjaLogowania.Text = "Nieprawidłowy login lub hasło";
            this.lblWalidacjaLogowania.Visible = false;
            // 
            // btnZalozKonto
            // 
            this.btnZalozKonto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnZalozKonto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZalozKonto.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZalozKonto.Location = new System.Drawing.Point(141, 418);
            this.btnZalozKonto.Name = "btnZalozKonto";
            this.btnZalozKonto.Size = new System.Drawing.Size(210, 70);
            this.btnZalozKonto.TabIndex = 12;
            this.btnZalozKonto.Text = "Załóż nowe konto";
            this.btnZalozKonto.UseVisualStyleBackColor = false;
            this.btnZalozKonto.Click += new System.EventHandler(this.btnZalozKonto_Click);
            // 
            // btnZaloguj
            // 
            this.btnZaloguj.BackColor = System.Drawing.Color.PeachPuff;
            this.btnZaloguj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZaloguj.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZaloguj.Location = new System.Drawing.Point(141, 318);
            this.btnZaloguj.Name = "btnZaloguj";
            this.btnZaloguj.Size = new System.Drawing.Size(210, 70);
            this.btnZaloguj.TabIndex = 11;
            this.btnZaloguj.Text = "Zaloguj";
            this.btnZaloguj.UseVisualStyleBackColor = false;
            this.btnZaloguj.Click += new System.EventHandler(this.btnZaloguj_Click);
            // 
            // tbHaslo
            // 
            this.tbHaslo.Location = new System.Drawing.Point(148, 209);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.PasswordChar = '*';
            this.tbHaslo.Size = new System.Drawing.Size(210, 20);
            this.tbHaslo.TabIndex = 10;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(148, 156);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(210, 20);
            this.tbLogin.TabIndex = 9;
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(85, 209);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(48, 20);
            this.lblHaslo.TabIndex = 8;
            this.lblHaslo.Text = "Hasło:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(85, 156);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 20);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 69);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lista zadań";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWalidacjaLogowania);
            this.Controls.Add(this.btnZalozKonto);
            this.Controls.Add(this.btnZaloguj);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblLogin);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWalidacjaLogowania;
        private System.Windows.Forms.Button btnZalozKonto;
        private System.Windows.Forms.Button btnZaloguj;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
    }
}
