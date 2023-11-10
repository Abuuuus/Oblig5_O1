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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            btnLoggUt.Location = new Point(628, 403);
            btnLoggUt.Margin = new Padding(3, 2, 3, 2);
            btnLoggUt.Name = "btnLoggUt";
            btnLoggUt.Size = new Size(157, 52);
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
            btnGet.Location = new Point(122, 320);
            btnGet.Margin = new Padding(3, 2, 3, 2);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(120, 57);
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
            btnSet.Location = new Point(123, 208);
            btnSet.Margin = new Padding(3, 2, 3, 2);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(120, 62);
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
            btnAutentifisere.Location = new Point(112, 101);
            btnAutentifisere.Margin = new Padding(3, 2, 3, 2);
            btnAutentifisere.Name = "btnAutentifisere";
            btnAutentifisere.Size = new Size(124, 40);
            btnAutentifisere.TabIndex = 4;
            btnAutentifisere.Text = "Logg Inn";
            btnAutentifisere.UseVisualStyleBackColor = false;
            btnAutentifisere.Click += btnAutentifisere_Click;
            // 
            // txtAutentifisere
            // 
            txtAutentifisere.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAutentifisere.ForeColor = SystemColors.WindowText;
            txtAutentifisere.Location = new Point(242, 101);
            txtAutentifisere.Margin = new Padding(3, 2, 3, 2);
            txtAutentifisere.Multiline = true;
            txtAutentifisere.Name = "txtAutentifisere";
            txtAutentifisere.Size = new Size(266, 56);
            txtAutentifisere.TabIndex = 6;
            // 
            // lbVelkommen
            // 
            lbVelkommen.AutoSize = true;
            lbVelkommen.BackColor = Color.Transparent;
            lbVelkommen.FlatStyle = FlatStyle.Flat;
            lbVelkommen.Font = new Font("Broadway", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbVelkommen.ForeColor = Color.Gold;
            lbVelkommen.Location = new Point(123, 9);
            lbVelkommen.Name = "lbVelkommen";
            lbVelkommen.Size = new Size(570, 40);
            lbVelkommen.TabIndex = 7;
            lbVelkommen.Text = "Velkommen til Koldal bank";
            // 
            // txtGet
            // 
            txtGet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtGet.Location = new Point(263, 311);
            txtGet.Margin = new Padding(3, 2, 3, 2);
            txtGet.Multiline = true;
            txtGet.Name = "txtGet";
            txtGet.Size = new Size(245, 75);
            txtGet.TabIndex = 8;
            // 
            // txtSet
            // 
            txtSet.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSet.Location = new Point(263, 201);
            txtSet.Margin = new Padding(3, 2, 3, 2);
            txtSet.Multiline = true;
            txtSet.Name = "txtSet";
            txtSet.Size = new Size(245, 69);
            txtSet.TabIndex = 9;
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldo.Location = new Point(263, 431);
            txtSaldo.Margin = new Padding(3, 2, 3, 2);
            txtSaldo.Multiline = true;
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(245, 72);
            txtSaldo.TabIndex = 10;
            // 
            // btnSettInnPenger
            // 
            btnSettInnPenger.BackColor = Color.Transparent;
            btnSettInnPenger.FlatAppearance.MouseOverBackColor = Color.Black;
            btnSettInnPenger.FlatStyle = FlatStyle.Flat;
            btnSettInnPenger.Font = new Font("Stencil", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSettInnPenger.ForeColor = Color.Gold;
            btnSettInnPenger.Location = new Point(12, 152);
            btnSettInnPenger.Margin = new Padding(3, 2, 3, 2);
            btnSettInnPenger.Name = "btnSettInnPenger";
            btnSettInnPenger.Size = new Size(164, 52);
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
            btnTaUtPenger.Location = new Point(12, 403);
            btnTaUtPenger.Margin = new Padding(3, 2, 3, 2);
            btnTaUtPenger.Name = "btnTaUtPenger";
            btnTaUtPenger.Size = new Size(157, 52);
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
            btnSjekkSaldo.Location = new Point(628, 152);
            btnSjekkSaldo.Margin = new Padding(3, 2, 3, 2);
            btnSjekkSaldo.Name = "btnSjekkSaldo";
            btnSjekkSaldo.Size = new Size(157, 52);
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
            btnTilbake.Location = new Point(628, 474);
            btnTilbake.Margin = new Padding(3, 2, 3, 2);
            btnTilbake.Name = "btnTilbake";
            btnTilbake.Size = new Size(157, 43);
            btnTilbake.TabIndex = 14;
            btnTilbake.Text = "Tilbake";
            btnTilbake.UseVisualStyleBackColor = false;
            btnTilbake.Click += btnTilbake_Click;
            // 
            // lbHandling
            // 
            lbHandling.AutoSize = true;
            lbHandling.BackColor = Color.LightGray;
            lbHandling.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbHandling.ForeColor = Color.Gold;
            lbHandling.Location = new Point(272, 50);
            lbHandling.Name = "lbHandling";
            lbHandling.Size = new Size(263, 33);
            lbHandling.TabIndex = 15;
            lbHandling.Text = "Velg en handling";
            // 
            // lbSaldo
            // 
            lbSaldo.AutoSize = true;
            lbSaldo.BackColor = Color.LightGray;
            lbSaldo.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbSaldo.ForeColor = Color.Gold;
            lbSaldo.Location = new Point(199, 403);
            lbSaldo.Name = "lbSaldo";
            lbSaldo.Size = new Size(376, 26);
            lbSaldo.TabIndex = 16;
            lbSaldo.Text = "Du har følgende saldo på konto";
            // 
            // lbBelopSet
            // 
            lbBelopSet.AutoSize = true;
            lbBelopSet.BackColor = Color.LightGray;
            lbBelopSet.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopSet.ForeColor = Color.Gold;
            lbBelopSet.Location = new Point(171, 159);
            lbBelopSet.Name = "lbBelopSet";
            lbBelopSet.Size = new Size(404, 26);
            lbBelopSet.TabIndex = 17;
            lbBelopSet.Text = "Hvor mye ønsker du og sette inn?";
            // 
            // lbBelopGet
            // 
            lbBelopGet.AutoSize = true;
            lbBelopGet.BackColor = Color.LightGray;
            lbBelopGet.FlatStyle = FlatStyle.Flat;
            lbBelopGet.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopGet.ForeColor = Color.Gold;
            lbBelopGet.Location = new Point(199, 283);
            lbBelopGet.Name = "lbBelopGet";
            lbBelopGet.Size = new Size(357, 26);
            lbBelopGet.TabIndex = 18;
            lbBelopGet.Text = "Hvor mye ønsker du og ta ut?";
            // 
            // lbBelopInnskudd
            // 
            lbBelopInnskudd.AutoSize = true;
            lbBelopInnskudd.BackColor = Color.LightGray;
            lbBelopInnskudd.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopInnskudd.ForeColor = Color.Gold;
            lbBelopInnskudd.Location = new Point(514, 230);
            lbBelopInnskudd.Name = "lbBelopInnskudd";
            lbBelopInnskudd.Size = new Size(263, 26);
            lbBelopInnskudd.TabIndex = 19;
            lbBelopInnskudd.Text = "Skriv inn beløp I NOK";
            // 
            // lbBelopUttak
            // 
            lbBelopUttak.AutoSize = true;
            lbBelopUttak.BackColor = Color.LightGray;
            lbBelopUttak.Font = new Font("Gill Sans Ultra Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbBelopUttak.ForeColor = Color.Gold;
            lbBelopUttak.Location = new Point(514, 339);
            lbBelopUttak.Name = "lbBelopUttak";
            lbBelopUttak.Size = new Size(263, 26);
            lbBelopUttak.TabIndex = 20;
            lbBelopUttak.Text = "Skriv inn beløp I NOK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 528);
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
            Margin = new Padding(3, 2, 3, 2);
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