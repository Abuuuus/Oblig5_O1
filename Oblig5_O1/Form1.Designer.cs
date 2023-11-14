namespace Oblig5_O1
{
    partial class Form1
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
            btnLoggUt = new Button();
            btnGet = new Button();
            btnSet = new Button();
            btnAutentifisere = new Button();
            txtAutentifisere = new TextBox();
            lbVelkommen = new Label();
            txtGet = new TextBox();
            txtSet = new TextBox();
            txtSaldo = new TextBox();
            btnSettInnPenger = new Button();
            btnTaUtPenger = new Button();
            btnSjekkSaldo = new Button();
            btnTilbake = new Button();
            lbHandling = new Label();
            lbSaldo = new Label();
            lbBelopSet = new Label();
            lbBelopGet = new Label();
            lbBelopInnskudd = new Label();
            lbBelopUttak = new Label();
            SuspendLayout();
            // 
            // btnLoggUt
            // 
            btnLoggUt.BackColor = Color.Transparent;
            btnLoggUt.FlatAppearance.MouseDownBackColor = Color.White;
            btnLoggUt.FlatAppearance.MouseOverBackColor = Color.Black;
            btnLoggUt.FlatStyle = FlatStyle.Flat;
            btnLoggUt.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoggUt.ForeColor = Color.Gold;
            btnLoggUt.Location = new Point(718, 537);
            btnLoggUt.Name = "btnLoggUt";
            btnLoggUt.Size = new Size(179, 69);
            btnLoggUt.TabIndex = 1;
            btnLoggUt.Text = "Logg Ut";
            btnLoggUt.UseVisualStyleBackColor = false;
            btnLoggUt.Click += btnLoggUt_Click;
            // 
            // btnGet
            // 
            btnGet.BackColor = Color.Transparent;
            btnGet.FlatAppearance.MouseOverBackColor = Color.Black;
            btnGet.FlatStyle = FlatStyle.Flat;
            btnGet.Font = new Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnGet.ForeColor = Color.Gold;
            btnGet.Location = new Point(139, 427);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(137, 76);
            btnGet.TabIndex = 2;
            btnGet.Text = "Ta Ut";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // btnSet
            // 
            btnSet.BackColor = Color.Transparent;
            btnSet.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSet.FlatStyle = FlatStyle.Flat;
            btnSet.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSet.ForeColor = Color.Gold;
            btnSet.Location = new Point(141, 277);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(137, 83);
            btnSet.TabIndex = 3;
            btnSet.Text = "Sett Inn";
            btnSet.UseVisualStyleBackColor = false;
            btnSet.Click += btnSet_Click;
            // 
            // btnAutentifisere
            // 
            btnAutentifisere.BackColor = Color.Transparent;
            btnAutentifisere.FlatAppearance.MouseOverBackColor = Color.Black;
            btnAutentifisere.FlatStyle = FlatStyle.Flat;
            btnAutentifisere.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnAutentifisere.ForeColor = Color.Gold;
            btnAutentifisere.Location = new Point(128, 135);
            btnAutentifisere.Name = "btnAutentifisere";
            btnAutentifisere.Size = new Size(142, 53);
            btnAutentifisere.TabIndex = 4;
            btnAutentifisere.Text = "Logg Inn";
            btnAutentifisere.UseVisualStyleBackColor = false;
            btnAutentifisere.Click += btnAutentifisere_Click;
            // 
            // txtAutentifisere
            // 
            txtAutentifisere.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutentifisere.ForeColor = SystemColors.WindowText;
            txtAutentifisere.Location = new Point(277, 135);
            txtAutentifisere.Multiline = true;
            txtAutentifisere.Name = "txtAutentifisere";
            txtAutentifisere.Size = new Size(303, 73);
            txtAutentifisere.TabIndex = 6;
            // 
            // lbVelkommen
            // 
            lbVelkommen.AutoSize = true;
            lbVelkommen.BackColor = Color.Transparent;
            lbVelkommen.FlatStyle = FlatStyle.Flat;
            lbVelkommen.Font = new Font("Broadway", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbVelkommen.ForeColor = Color.Gold;
            lbVelkommen.Location = new Point(141, 12);
            lbVelkommen.Name = "lbVelkommen";
            lbVelkommen.Size = new Size(709, 50);
            lbVelkommen.TabIndex = 7;
            lbVelkommen.Text = "Velkommen til Koldal bank";
            // 
            // txtGet
            // 
            txtGet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtGet.Location = new Point(301, 415);
            txtGet.Multiline = true;
            txtGet.Name = "txtGet";
            txtGet.Size = new Size(279, 99);
            txtGet.TabIndex = 8;
            // 
            // txtSet
            // 
            txtSet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSet.Location = new Point(301, 268);
            txtSet.Multiline = true;
            txtSet.Name = "txtSet";
            txtSet.Size = new Size(279, 91);
            txtSet.TabIndex = 9;
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.Location = new Point(301, 575);
            txtSaldo.Multiline = true;
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(279, 95);
            txtSaldo.TabIndex = 10;
            // 
            // btnSettInnPenger
            // 
            btnSettInnPenger.BackColor = Color.Transparent;
            btnSettInnPenger.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSettInnPenger.FlatStyle = FlatStyle.Flat;
            btnSettInnPenger.Font = new Font("Stencil", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettInnPenger.ForeColor = Color.Gold;
            btnSettInnPenger.Location = new Point(14, 203);
            btnSettInnPenger.Name = "btnSettInnPenger";
            btnSettInnPenger.Size = new Size(187, 69);
            btnSettInnPenger.TabIndex = 11;
            btnSettInnPenger.Text = "Sett Inn Penger";
            btnSettInnPenger.UseVisualStyleBackColor = false;
            btnSettInnPenger.Click += btnSettInnPenger_Click;
            // 
            // btnTaUtPenger
            // 
            btnTaUtPenger.BackColor = Color.Transparent;
            btnTaUtPenger.FlatAppearance.MouseOverBackColor = Color.Black;
            btnTaUtPenger.FlatStyle = FlatStyle.Flat;
            btnTaUtPenger.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTaUtPenger.ForeColor = Color.Gold;
            btnTaUtPenger.Location = new Point(14, 537);
            btnTaUtPenger.Name = "btnTaUtPenger";
            btnTaUtPenger.Size = new Size(179, 69);
            btnTaUtPenger.TabIndex = 12;
            btnTaUtPenger.Text = "Ta ut penger";
            btnTaUtPenger.UseVisualStyleBackColor = false;
            btnTaUtPenger.Click += btnTaUtPenger_Click;
            // 
            // btnSjekkSaldo
            // 
            btnSjekkSaldo.BackColor = Color.Transparent;
            btnSjekkSaldo.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSjekkSaldo.FlatStyle = FlatStyle.Flat;
            btnSjekkSaldo.Font = new Font("Stencil", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSjekkSaldo.ForeColor = Color.Gold;
            btnSjekkSaldo.Location = new Point(718, 203);
            btnSjekkSaldo.Name = "btnSjekkSaldo";
            btnSjekkSaldo.Size = new Size(179, 69);
            btnSjekkSaldo.TabIndex = 13;
            btnSjekkSaldo.Text = "Sjekke Saldo";
            btnSjekkSaldo.UseVisualStyleBackColor = false;
            btnSjekkSaldo.Click += btnSjekkSaldo_Click;
            // 
            // btnTilbake
            // 
            btnTilbake.BackColor = Color.Transparent;
            btnTilbake.FlatAppearance.MouseOverBackColor = Color.Black;
            btnTilbake.FlatStyle = FlatStyle.Flat;
            btnTilbake.Font = new Font("Stencil", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTilbake.ForeColor = Color.Gold;
            btnTilbake.Location = new Point(703, 632);
            btnTilbake.Name = "btnTilbake";
            btnTilbake.Size = new Size(194, 57);
            btnTilbake.TabIndex = 14;
            btnTilbake.Text = "Tilbake";
            btnTilbake.UseVisualStyleBackColor = false;
            btnTilbake.Click += btnTilbake_Click;
            // 
            // lbHandling
            // 
            lbHandling.AutoSize = true;
            lbHandling.BackColor = Color.Transparent;
            lbHandling.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbHandling.ForeColor = Color.Gold;
            lbHandling.Location = new Point(311, 67);
            lbHandling.Name = "lbHandling";
            lbHandling.Size = new Size(332, 43);
            lbHandling.TabIndex = 15;
            lbHandling.Text = "Velg en handling";
            // 
            // lbSaldo
            // 
            lbSaldo.AutoSize = true;
            lbSaldo.BackColor = Color.Transparent;
            lbSaldo.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSaldo.ForeColor = Color.Gold;
            lbSaldo.Location = new Point(227, 537);
            lbSaldo.Name = "lbSaldo";
            lbSaldo.Size = new Size(478, 33);
            lbSaldo.TabIndex = 16;
            lbSaldo.Text = "Du har følgende saldo på konto";
            // 
            // lbBelopSet
            // 
            lbBelopSet.AutoSize = true;
            lbBelopSet.BackColor = Color.Transparent;
            lbBelopSet.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopSet.ForeColor = Color.Gold;
            lbBelopSet.Location = new Point(195, 212);
            lbBelopSet.Name = "lbBelopSet";
            lbBelopSet.Size = new Size(516, 33);
            lbBelopSet.TabIndex = 17;
            lbBelopSet.Text = "Hvor mye ønsker du og sette inn?";
            // 
            // lbBelopGet
            // 
            lbBelopGet.AutoSize = true;
            lbBelopGet.BackColor = Color.Transparent;
            lbBelopGet.FlatStyle = FlatStyle.Flat;
            lbBelopGet.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopGet.ForeColor = Color.Gold;
            lbBelopGet.Location = new Point(227, 377);
            lbBelopGet.Name = "lbBelopGet";
            lbBelopGet.Size = new Size(455, 33);
            lbBelopGet.TabIndex = 18;
            lbBelopGet.Text = "Hvor mye ønsker du og ta ut?";
            // 
            // lbBelopInnskudd
            // 
            lbBelopInnskudd.AutoSize = true;
            lbBelopInnskudd.BackColor = Color.Transparent;
            lbBelopInnskudd.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopInnskudd.ForeColor = Color.Gold;
            lbBelopInnskudd.Location = new Point(587, 307);
            lbBelopInnskudd.Name = "lbBelopInnskudd";
            lbBelopInnskudd.Size = new Size(335, 33);
            lbBelopInnskudd.TabIndex = 19;
            lbBelopInnskudd.Text = "Skriv inn beløp I NOK";
            // 
            // lbBelopUttak
            // 
            lbBelopUttak.AutoSize = true;
            lbBelopUttak.BackColor = Color.Transparent;
            lbBelopUttak.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopUttak.ForeColor = Color.Gold;
            lbBelopUttak.Location = new Point(587, 452);
            lbBelopUttak.Name = "lbBelopUttak";
            lbBelopUttak.Size = new Size(335, 33);
            lbBelopUttak.TabIndex = 20;
            lbBelopUttak.Text = "Skriv inn beløp I NOK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(911, 704);
            Controls.Add(btnSettInnPenger);
            Controls.Add(lbBelopUttak);
            Controls.Add(lbBelopInnskudd);
            Controls.Add(lbBelopGet);
            Controls.Add(lbBelopSet);
            Controls.Add(lbSaldo);
            Controls.Add(lbHandling);
            Controls.Add(btnTilbake);
            Controls.Add(btnGet);
            Controls.Add(btnSjekkSaldo);
            Controls.Add(btnTaUtPenger);
            Controls.Add(txtSaldo);
            Controls.Add(txtSet);
            Controls.Add(txtGet);
            Controls.Add(lbVelkommen);
            Controls.Add(txtAutentifisere);
            Controls.Add(btnAutentifisere);
            Controls.Add(btnSet);
            Controls.Add(btnLoggUt);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Banken";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLoggUt;
        private Button btnGet;
        private Button btnSet;
        private Button btnAutentifisere;
        private TextBox txtAutentifisere;
        private Label lbVelkommen;
        private TextBox txtGet;
        private TextBox txtSet;
        private TextBox txtSaldo;
        private Button btnSettInnPenger;
        private Button btnTaUtPenger;
        private Button btnSjekkSaldo;
        private Button btnTilbake;
        private Label lbHandling;
        private Label lbSaldo;
        private Label lbBelopSet;
        private Label lbBelopGet;
        private Label lbBelopInnskudd;
        private Label lbBelopUttak;
    }
}