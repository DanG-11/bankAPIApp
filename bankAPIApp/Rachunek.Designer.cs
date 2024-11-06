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
            // grpBoxRachunek
            // 
            grpBoxRachunek.Controls.Add(grpBoxTxtBoxKwotaNaRachunku);
            grpBoxRachunek.Controls.Add(grpBoxTxtBoxNrRachunku);
            grpBoxRachunek.Controls.Add(grpBoxTxtBoxNazwaRachunku);
            grpBoxRachunek.Controls.Add(grpBoxLblKwotaNaRachunku);
            grpBoxRachunek.Controls.Add(grpBoxLblNrRachunku);
            grpBoxRachunek.Controls.Add(grpBoxLblNazwaRachunku);
            grpBoxRachunek.Location = new Point(12, 12);
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
            ClientSize = new Size(315, 133);
            Controls.Add(grpBoxRachunek);
            Name = "frmRachunek";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rachunek";
            Load += OnAppLoad;
            grpBoxRachunek.ResumeLayout(false);
            grpBoxRachunek.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpBoxRachunek;
        private TextBox grpBoxTxtBoxKwotaNaRachunku;
        private TextBox grpBoxTxtBoxNrRachunku;
        private TextBox grpBoxTxtBoxNazwaRachunku;
        private Label grpBoxLblKwotaNaRachunku;
        private Label grpBoxLblNrRachunku;
        private Label grpBoxLblNazwaRachunku;
    }
}
