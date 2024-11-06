namespace bankAPIApp
{
    partial class Login
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
            tabLayPanLogowanie = new TableLayoutPanel();
            lblLogowanie = new Label();
            lblEMail = new Label();
            lblHaslo = new Label();
            btnZaloguj = new Button();
            btnWyjdz = new Button();
            txtBoxEMail = new TextBox();
            txtBoxHaslo = new TextBox();
            tabLayPanLogowanie.SuspendLayout();
            SuspendLayout();
            // 
            // tabLayPanLogowanie
            // 
            tabLayPanLogowanie.ColumnCount = 2;
            tabLayPanLogowanie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tabLayPanLogowanie.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tabLayPanLogowanie.Controls.Add(lblLogowanie, 0, 0);
            tabLayPanLogowanie.Controls.Add(lblEMail, 0, 1);
            tabLayPanLogowanie.Controls.Add(lblHaslo, 0, 2);
            tabLayPanLogowanie.Controls.Add(btnZaloguj, 0, 3);
            tabLayPanLogowanie.Controls.Add(btnWyjdz, 1, 3);
            tabLayPanLogowanie.Controls.Add(txtBoxEMail, 1, 1);
            tabLayPanLogowanie.Controls.Add(txtBoxHaslo, 1, 2);
            tabLayPanLogowanie.Location = new Point(12, 12);
            tabLayPanLogowanie.Name = "tabLayPanLogowanie";
            tabLayPanLogowanie.RowCount = 4;
            tabLayPanLogowanie.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tabLayPanLogowanie.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tabLayPanLogowanie.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tabLayPanLogowanie.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tabLayPanLogowanie.Size = new Size(776, 426);
            tabLayPanLogowanie.TabIndex = 0;
            // 
            // lblLogowanie
            // 
            lblLogowanie.AutoSize = true;
            tabLayPanLogowanie.SetColumnSpan(lblLogowanie, 2);
            lblLogowanie.Dock = DockStyle.Fill;
            lblLogowanie.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblLogowanie.Location = new Point(3, 0);
            lblLogowanie.Name = "lblLogowanie";
            lblLogowanie.Size = new Size(770, 106);
            lblLogowanie.TabIndex = 0;
            lblLogowanie.Text = "Logowanie";
            lblLogowanie.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEMail
            // 
            lblEMail.AutoSize = true;
            lblEMail.Dock = DockStyle.Fill;
            lblEMail.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblEMail.Location = new Point(3, 106);
            lblEMail.Name = "lblEMail";
            lblEMail.Size = new Size(382, 106);
            lblEMail.TabIndex = 1;
            lblEMail.Text = "E-Mail:";
            lblEMail.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblHaslo
            // 
            lblHaslo.AutoSize = true;
            lblHaslo.Dock = DockStyle.Fill;
            lblHaslo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblHaslo.Location = new Point(3, 212);
            lblHaslo.Name = "lblHaslo";
            lblHaslo.Size = new Size(382, 106);
            lblHaslo.TabIndex = 2;
            lblHaslo.Text = "Hasło:";
            lblHaslo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnZaloguj
            // 
            btnZaloguj.Dock = DockStyle.Fill;
            btnZaloguj.Location = new Point(3, 321);
            btnZaloguj.Name = "btnZaloguj";
            btnZaloguj.Size = new Size(382, 102);
            btnZaloguj.TabIndex = 5;
            btnZaloguj.Text = "Zaloguj";
            btnZaloguj.UseVisualStyleBackColor = true;
            btnZaloguj.Click += PrzyciskZalogujWcisniety;
            // 
            // btnWyjdz
            // 
            btnWyjdz.Dock = DockStyle.Fill;
            btnWyjdz.Location = new Point(391, 321);
            btnWyjdz.Name = "btnWyjdz";
            btnWyjdz.Size = new Size(382, 102);
            btnWyjdz.TabIndex = 6;
            btnWyjdz.Text = "Wyjdź";
            btnWyjdz.UseVisualStyleBackColor = true;
            btnWyjdz.Click += PrzyciskWyjdzKlikniety;
            // 
            // txtBoxEMail
            // 
            txtBoxEMail.Dock = DockStyle.Fill;
            txtBoxEMail.Location = new Point(391, 109);
            txtBoxEMail.Name = "txtBoxEMail";
            txtBoxEMail.Size = new Size(382, 23);
            txtBoxEMail.TabIndex = 3;
            txtBoxEMail.Text = "jkowalski@teb.edu.pl";
            // 
            // txtBoxHaslo
            // 
            txtBoxHaslo.Dock = DockStyle.Fill;
            txtBoxHaslo.Location = new Point(391, 215);
            txtBoxHaslo.Name = "txtBoxHaslo";
            txtBoxHaslo.PasswordChar = '*';
            txtBoxHaslo.Size = new Size(382, 23);
            txtBoxHaslo.TabIndex = 4;
            txtBoxHaslo.Text = "321";
            txtBoxHaslo.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabLayPanLogowanie);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            tabLayPanLogowanie.ResumeLayout(false);
            tabLayPanLogowanie.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tabLayPanLogowanie;
        private Label lblLogowanie;
        private Label lblEMail;
        private Label lblHaslo;
        private Button btnZaloguj;
        private Button btnWyjdz;
        private TextBox txtBoxEMail;
        private TextBox txtBoxHaslo;
    }
}