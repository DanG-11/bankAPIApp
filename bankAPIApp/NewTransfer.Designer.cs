namespace bankAPIApp
{
    partial class NewTransfer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblRachunekZrodlowy = new Label();
            LblRachunekDocelowy = new Label();
            LblKwota = new Label();
            TxtBoxRachunekZrodlowy = new TextBox();
            TxtBoxRachunekDocelowy = new TextBox();
            TxtBoxKwota = new TextBox();
            BtnWykonajPrzelew = new Button();
            SuspendLayout();
            // 
            // LblRachunekZrodlowy
            // 
            LblRachunekZrodlowy.AutoSize = true;
            LblRachunekZrodlowy.Location = new Point(12, 9);
            LblRachunekZrodlowy.Name = "LblRachunekZrodlowy";
            LblRachunekZrodlowy.Size = new Size(113, 15);
            LblRachunekZrodlowy.TabIndex = 0;
            LblRachunekZrodlowy.Text = "Rachunek źródłowy:";
            // 
            // LblRachunekDocelowy
            // 
            LblRachunekDocelowy.AutoSize = true;
            LblRachunekDocelowy.Location = new Point(12, 49);
            LblRachunekDocelowy.Name = "LblRachunekDocelowy";
            LblRachunekDocelowy.Size = new Size(116, 15);
            LblRachunekDocelowy.TabIndex = 1;
            LblRachunekDocelowy.Text = "Rachunek docelowy:";
            // 
            // LblKwota
            // 
            LblKwota.AutoSize = true;
            LblKwota.Location = new Point(12, 89);
            LblKwota.Name = "LblKwota";
            LblKwota.Size = new Size(43, 15);
            LblKwota.TabIndex = 2;
            LblKwota.Text = "Kwota:";
            // 
            // TxtBoxRachunekZrodlowy
            // 
            TxtBoxRachunekZrodlowy.Location = new Point(134, 6);
            TxtBoxRachunekZrodlowy.Name = "TxtBoxRachunekZrodlowy";
            TxtBoxRachunekZrodlowy.ReadOnly = true;
            TxtBoxRachunekZrodlowy.Size = new Size(100, 23);
            TxtBoxRachunekZrodlowy.TabIndex = 3;
            // 
            // TxtBoxRachunekDocelowy
            // 
            TxtBoxRachunekDocelowy.Location = new Point(134, 46);
            TxtBoxRachunekDocelowy.Name = "TxtBoxRachunekDocelowy";
            TxtBoxRachunekDocelowy.Size = new Size(100, 23);
            TxtBoxRachunekDocelowy.TabIndex = 4;
            // 
            // TxtBoxKwota
            // 
            TxtBoxKwota.Location = new Point(134, 86);
            TxtBoxKwota.Name = "TxtBoxKwota";
            TxtBoxKwota.Size = new Size(100, 23);
            TxtBoxKwota.TabIndex = 5;
            // 
            // BtnWykonajPrzelew
            // 
            BtnWykonajPrzelew.Location = new Point(12, 115);
            BtnWykonajPrzelew.Name = "BtnWykonajPrzelew";
            BtnWykonajPrzelew.Size = new Size(222, 23);
            BtnWykonajPrzelew.TabIndex = 6;
            BtnWykonajPrzelew.Text = "Wykonaj przelew";
            BtnWykonajPrzelew.UseVisualStyleBackColor = true;
            BtnWykonajPrzelew.Click += BtnWykonajPrzelew_Click;
            // 
            // NewTransfer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 153);
            Controls.Add(BtnWykonajPrzelew);
            Controls.Add(TxtBoxKwota);
            Controls.Add(TxtBoxRachunekDocelowy);
            Controls.Add(TxtBoxRachunekZrodlowy);
            Controls.Add(LblKwota);
            Controls.Add(LblRachunekDocelowy);
            Controls.Add(LblRachunekZrodlowy);
            Name = "NewTransfer";
            Text = "NewTransfer";
            Load += NewTransfer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblRachunekZrodlowy;
        private Label LblRachunekDocelowy;
        private Label LblKwota;
        private TextBox TxtBoxRachunekZrodlowy;
        private TextBox TxtBoxRachunekDocelowy;
        private TextBox TxtBoxKwota;
        private Button BtnWykonajPrzelew;
    }
}