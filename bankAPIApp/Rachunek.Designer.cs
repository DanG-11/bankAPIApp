namespace bankAPIApp
{
    partial class frmRachunek
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNrRachunku = new Label();
            txtBoxNrRachunku = new TextBox();
            btnPobierzDane = new Button();
            grpBoxRachunek = new GroupBox();
            grpBoxTxtBoxKwotaNaRachunku = new TextBox();
            grpBoxTxtBoxNrRachunku = new TextBox();
            grpBoxTxtBoxNazwaRachunku = new TextBox();
            grpBoxLblKwotaNaRachunku = new Label();
            grpBoxLblNrRachunku = new Label();
            grpBoxLblNazwaRachunku = new Label();
            grpBoxRachunek.SuspendLayout();
            SuspendLayout();
            // 
            // lblNrRachunku
            // 
            lblNrRachunku.AutoSize = true;
            lblNrRachunku.Location = new Point(12, 9);
            lblNrRachunku.Name = "lblNrRachunku";
            lblNrRachunku.Size = new Size(100, 15);
            lblNrRachunku.TabIndex = 0;
            lblNrRachunku.Text = "Numer rachunku:";
            // 
            // txtBoxNrRachunku
            // 
            txtBoxNrRachunku.Location = new Point(118, 6);
            txtBoxNrRachunku.Name = "txtBoxNrRachunku";
            txtBoxNrRachunku.Size = new Size(100, 23);
            txtBoxNrRachunku.TabIndex = 1;
            // 
            // btnPobierzDane
            // 
            btnPobierzDane.Location = new Point(224, 6);
            btnPobierzDane.Name = "btnPobierzDane";
            btnPobierzDane.Size = new Size(83, 23);
            btnPobierzDane.TabIndex = 2;
            btnPobierzDane.Text = "Pobierz dane";
            btnPobierzDane.UseVisualStyleBackColor = true;
            btnPobierzDane.Click += GetAccountData;
            // 
            // grpBoxRachunek
            // 
            grpBoxRachunek.Controls.Add(grpBoxTxtBoxKwotaNaRachunku);
            grpBoxRachunek.Controls.Add(grpBoxTxtBoxNrRachunku);
            grpBoxRachunek.Controls.Add(grpBoxTxtBoxNazwaRachunku);
            grpBoxRachunek.Controls.Add(grpBoxLblKwotaNaRachunku);
            grpBoxRachunek.Controls.Add(grpBoxLblNrRachunku);
            grpBoxRachunek.Controls.Add(grpBoxLblNazwaRachunku);
            grpBoxRachunek.Location = new Point(18, 35);
            grpBoxRachunek.Name = "grpBoxRachunek";
            grpBoxRachunek.Size = new Size(289, 105);
            grpBoxRachunek.TabIndex = 3;
            grpBoxRachunek.TabStop = false;
            grpBoxRachunek.Text = "Rachunek";
            // 
            // grpBoxTxtBoxKwotaNaRachunku
            // 
            grpBoxTxtBoxKwotaNaRachunku.Location = new Point(124, 74);
            grpBoxTxtBoxKwotaNaRachunku.Name = "grpBoxTxtBoxKwotaNaRachunku";
            grpBoxTxtBoxKwotaNaRachunku.Size = new Size(159, 23);
            grpBoxTxtBoxKwotaNaRachunku.TabIndex = 5;
            // 
            // grpBoxTxtBoxNrRachunku
            // 
            grpBoxTxtBoxNrRachunku.Location = new Point(124, 45);
            grpBoxTxtBoxNrRachunku.Name = "grpBoxTxtBoxNrRachunku";
            grpBoxTxtBoxNrRachunku.Size = new Size(159, 23);
            grpBoxTxtBoxNrRachunku.TabIndex = 4;
            // 
            // grpBoxTxtBoxNazwaRachunku
            // 
            grpBoxTxtBoxNazwaRachunku.Location = new Point(124, 16);
            grpBoxTxtBoxNazwaRachunku.Name = "grpBoxTxtBoxNazwaRachunku";
            grpBoxTxtBoxNazwaRachunku.Size = new Size(159, 23);
            grpBoxTxtBoxNazwaRachunku.TabIndex = 3;
            // 
            // grpBoxLblKwotaNaRachunku
            // 
            grpBoxLblKwotaNaRachunku.AutoSize = true;
            grpBoxLblKwotaNaRachunku.Location = new Point(6, 77);
            grpBoxLblKwotaNaRachunku.Name = "grpBoxLblKwotaNaRachunku";
            grpBoxLblKwotaNaRachunku.Size = new Size(112, 15);
            grpBoxLblKwotaNaRachunku.TabIndex = 2;
            grpBoxLblKwotaNaRachunku.Text = "Kwota na rachunku:";
            // 
            // grpBoxLblNrRachunku
            // 
            grpBoxLblNrRachunku.AutoSize = true;
            grpBoxLblNrRachunku.Location = new Point(6, 48);
            grpBoxLblNrRachunku.Name = "grpBoxLblNrRachunku";
            grpBoxLblNrRachunku.Size = new Size(100, 15);
            grpBoxLblNrRachunku.TabIndex = 1;
            grpBoxLblNrRachunku.Text = "Numer rachunku:";
            // 
            // grpBoxLblNazwaRachunku
            // 
            grpBoxLblNazwaRachunku.AutoSize = true;
            grpBoxLblNazwaRachunku.Location = new Point(6, 19);
            grpBoxLblNazwaRachunku.Name = "grpBoxLblNazwaRachunku";
            grpBoxLblNazwaRachunku.Size = new Size(98, 15);
            grpBoxLblNazwaRachunku.TabIndex = 0;
            grpBoxLblNazwaRachunku.Text = "Nazwa rachunku:";
            // 
            // frmRachunek
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 146);
            Controls.Add(grpBoxRachunek);
            Controls.Add(btnPobierzDane);
            Controls.Add(txtBoxNrRachunku);
            Controls.Add(lblNrRachunku);
            Name = "frmRachunek";
            Text = "Rachunek";
            Load += OnAppLoad;
            grpBoxRachunek.ResumeLayout(false);
            grpBoxRachunek.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNrRachunku;
        private TextBox txtBoxNrRachunku;
        private Button btnPobierzDane;
        private GroupBox grpBoxRachunek;
        private TextBox grpBoxTxtBoxKwotaNaRachunku;
        private TextBox grpBoxTxtBoxNrRachunku;
        private TextBox grpBoxTxtBoxNazwaRachunku;
        private Label grpBoxLblKwotaNaRachunku;
        private Label grpBoxLblNrRachunku;
        private Label grpBoxLblNazwaRachunku;
    }
}
