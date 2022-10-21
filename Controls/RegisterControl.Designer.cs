
using System;

namespace ToDoList.Controls
{
    partial class RegisterControl
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
            this.lblImie = new System.Windows.Forms.Label();
            this.lblNazwisko = new System.Windows.Forms.Label();
            this.lblHaslo = new System.Windows.Forms.Label();
            this.lblPowtorzHaslo = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbHaslo = new System.Windows.Forms.TextBox();
            this.tbPowtorzHaslo = new System.Windows.Forms.TextBox();
            this.tbImie = new System.Windows.Forms.TextBox();
            this.btnCofnij = new System.Windows.Forms.Button();
            this.btnZarejestruj = new System.Windows.Forms.Button();
            this.lblHasloWalidacja = new System.Windows.Forms.Label();
            this.lblPowtorzHasloWalidacja = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImie
            // 
            this.lblImie.AutoSize = true;
            this.lblImie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImie.Location = new System.Drawing.Point(103, 131);
            this.lblImie.Name = "lblImie";
            this.lblImie.Size = new System.Drawing.Size(40, 20);
            this.lblImie.TabIndex = 0;
            this.lblImie.Text = "Imię:";
            // 
            // lblNazwisko
            // 
            this.lblNazwisko.AutoSize = true;
            this.lblNazwisko.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwisko.Location = new System.Drawing.Point(97, 222);
            this.lblNazwisko.Name = "lblNazwisko";
            this.lblNazwisko.Size = new System.Drawing.Size(49, 20);
            this.lblNazwisko.TabIndex = 1;
            this.lblNazwisko.Text = "Login:";
            // 
            // lblHaslo
            // 
            this.lblHaslo.AutoSize = true;
            this.lblHaslo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHaslo.Location = new System.Drawing.Point(95, 324);
            this.lblHaslo.Name = "lblHaslo";
            this.lblHaslo.Size = new System.Drawing.Size(48, 20);
            this.lblHaslo.TabIndex = 2;
            this.lblHaslo.Text = "Hasło:";
            // 
            // lblPowtorzHaslo
            // 
            this.lblPowtorzHaslo.AutoSize = true;
            this.lblPowtorzHaslo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPowtorzHaslo.Location = new System.Drawing.Point(67, 419);
            this.lblPowtorzHaslo.Name = "lblPowtorzHaslo";
            this.lblPowtorzHaslo.Size = new System.Drawing.Size(100, 20);
            this.lblPowtorzHaslo.TabIndex = 3;
            this.lblPowtorzHaslo.Text = "Powtórz hasło:";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(201, 219);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(154, 26);
            this.tbLogin.TabIndex = 4;
            // 
            // tbHaslo
            // 
            this.tbHaslo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbHaslo.Location = new System.Drawing.Point(201, 318);
            this.tbHaslo.Name = "tbHaslo";
            this.tbHaslo.Size = new System.Drawing.Size(154, 26);
            this.tbHaslo.TabIndex = 5;
            // 
            // tbPowtorzHaslo
            // 
            this.tbPowtorzHaslo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPowtorzHaslo.Location = new System.Drawing.Point(201, 416);
            this.tbPowtorzHaslo.Name = "tbPowtorzHaslo";
            this.tbPowtorzHaslo.Size = new System.Drawing.Size(154, 26);
            this.tbPowtorzHaslo.TabIndex = 6;
            // 
            // tbImie
            // 
            this.tbImie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImie.Location = new System.Drawing.Point(201, 128);
            this.tbImie.Name = "tbImie";
            this.tbImie.Size = new System.Drawing.Size(154, 26);
            this.tbImie.TabIndex = 7;
            // 
            // btnCofnij
            // 

            this.btnCofnij.BackColor = System.Drawing.Color.Red;
            this.btnCofnij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCofnij.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCofnij.Location = new System.Drawing.Point(3, 3);
            this.btnCofnij.Name = "btnCofnij";
            this.btnCofnij.Size = new System.Drawing.Size(105, 48);
            this.btnCofnij.TabIndex = 9;
            this.btnCofnij.Text = "←";
            this.btnCofnij.UseVisualStyleBackColor = false;
            this.btnCofnij.Click += new System.EventHandler(this.btnCofnij_Click);
            // 
            // btnZarejestruj
            // 
            this.btnZarejestruj.BackColor = System.Drawing.Color.PaleGreen;
            this.btnZarejestruj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZarejestruj.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZarejestruj.Location = new System.Drawing.Point(145, 526);
            this.btnZarejestruj.Name = "btnZarejestruj";
            this.btnZarejestruj.Size = new System.Drawing.Size(210, 70);
            this.btnZarejestruj.TabIndex = 10;
            this.btnZarejestruj.Text = "Zarejestruj";
            this.btnZarejestruj.UseVisualStyleBackColor = false;
            this.btnZarejestruj.Click += new System.EventHandler(this.btnZarejestruj_Click);
            // 
            // lblHasloWalidacja
            // 
            this.lblHasloWalidacja.AutoSize = true;
            this.lblHasloWalidacja.Location = new System.Drawing.Point(201, 375);
            this.lblHasloWalidacja.Name = "lblHasloWalidacja";
            this.lblHasloWalidacja.Size = new System.Drawing.Size(35, 13);
            this.lblHasloWalidacja.TabIndex = 13;
            this.lblHasloWalidacja.Text = "label3";
            this.lblHasloWalidacja.Visible = false;
            // 
            // lblPowtorzHasloWalidacja
            // 
            this.lblPowtorzHasloWalidacja.AutoSize = true;
            this.lblPowtorzHasloWalidacja.Location = new System.Drawing.Point(201, 465);
            this.lblPowtorzHasloWalidacja.Name = "lblPowtorzHasloWalidacja";
            this.lblPowtorzHasloWalidacja.Size = new System.Drawing.Size(35, 13);
            this.lblPowtorzHasloWalidacja.TabIndex = 14;
            this.lblPowtorzHasloWalidacja.Text = "label4";
            this.lblPowtorzHasloWalidacja.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(55, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 406);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Nowego Użytkownika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(159, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rejestracja";
            // 
            // RegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPowtorzHasloWalidacja);
            this.Controls.Add(this.lblHasloWalidacja);
            this.Controls.Add(this.btnZarejestruj);
            this.Controls.Add(this.btnCofnij);
            this.Controls.Add(this.tbImie);
            this.Controls.Add(this.tbPowtorzHaslo);
            this.Controls.Add(this.tbHaslo);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblPowtorzHaslo);
            this.Controls.Add(this.lblHaslo);
            this.Controls.Add(this.lblNazwisko);
            this.Controls.Add(this.lblImie);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterControl";
            this.Size = new System.Drawing.Size(500, 640);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label lblImie;
        private System.Windows.Forms.Label lblNazwisko;
        private System.Windows.Forms.Label lblHaslo;
        private System.Windows.Forms.Label lblPowtorzHaslo;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbHaslo;
        private System.Windows.Forms.TextBox tbPowtorzHaslo;
        private System.Windows.Forms.TextBox tbImie;
        private System.Windows.Forms.Button btnCofnij;
        private System.Windows.Forms.Button btnZarejestruj;
        private System.Windows.Forms.Label lblHasloWalidacja;
        private System.Windows.Forms.Label lblPowtorzHasloWalidacja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}
