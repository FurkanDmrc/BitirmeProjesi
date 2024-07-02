namespace FordKontrolApp.Forms
{
    partial class Bilgi_Formu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilgi_Formu));
            this.dgwlist = new System.Windows.Forms.DataGridView();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblsoyad = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.lblmail = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.lbltelefon = new System.Windows.Forms.Label();
            this.txtaraba = new System.Windows.Forms.TextBox();
            this.lblaraba = new System.Windows.Forms.Label();
            this.lblıd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwlist
            // 
            this.dgwlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwlist.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(171)))), ((int)(((byte)(236)))));
            this.dgwlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwlist.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgwlist.Location = new System.Drawing.Point(29, 12);
            this.dgwlist.Name = "dgwlist";
            this.dgwlist.Size = new System.Drawing.Size(733, 222);
            this.dgwlist.TabIndex = 6;
            this.dgwlist.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwlist_CellClick);
            this.dgwlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwlist_CellContentClick);
            // 
            // btnekle
            // 
            this.btnekle.BackColor = System.Drawing.Color.Transparent;
            this.btnekle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnekle.BackgroundImage")));
            this.btnekle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnekle.FlatAppearance.BorderSize = 0;
            this.btnekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnekle.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnekle.ForeColor = System.Drawing.Color.Transparent;
            this.btnekle.Location = new System.Drawing.Point(44, 336);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(60, 46);
            this.btnekle.TabIndex = 7;
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnguncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguncelle.BackgroundImage")));
            this.btnguncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnguncelle.FlatAppearance.BorderSize = 0;
            this.btnguncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguncelle.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnguncelle.Location = new System.Drawing.Point(110, 332);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(62, 50);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.Transparent;
            this.btnsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsil.BackgroundImage")));
            this.btnsil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsil.Location = new System.Drawing.Point(178, 336);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(56, 46);
            this.btnsil.TabIndex = 9;
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(84, 285);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(152, 20);
            this.txtsoyad.TabIndex = 12;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(84, 256);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(152, 20);
            this.txtad.TabIndex = 13;
            this.txtad.TextChanged += new System.EventHandler(this.txtad_TextChanged);
            // 
            // lblsoyad
            // 
            this.lblsoyad.AutoSize = true;
            this.lblsoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblsoyad.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoyad.ForeColor = System.Drawing.Color.Black;
            this.lblsoyad.Location = new System.Drawing.Point(15, 285);
            this.lblsoyad.Name = "lblsoyad";
            this.lblsoyad.Size = new System.Drawing.Size(58, 21);
            this.lblsoyad.TabIndex = 11;
            this.lblsoyad.Text = "Soyad";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.BackColor = System.Drawing.Color.Transparent;
            this.lblad.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.ForeColor = System.Drawing.Color.Black;
            this.lblad.Location = new System.Drawing.Point(33, 256);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(31, 21);
            this.lblad.TabIndex = 10;
            this.lblad.Text = "Ad";
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(328, 259);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(152, 20);
            this.txtmail.TabIndex = 15;
            // 
            // lblmail
            // 
            this.lblmail.AutoSize = true;
            this.lblmail.BackColor = System.Drawing.Color.Transparent;
            this.lblmail.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmail.ForeColor = System.Drawing.Color.Black;
            this.lblmail.Location = new System.Drawing.Point(264, 259);
            this.lblmail.Name = "lblmail";
            this.lblmail.Size = new System.Drawing.Size(55, 21);
            this.lblmail.TabIndex = 14;
            this.lblmail.Text = "Email";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(329, 290);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(151, 20);
            this.txttel.TabIndex = 17;
            // 
            // lbltelefon
            // 
            this.lbltelefon.AutoSize = true;
            this.lbltelefon.BackColor = System.Drawing.Color.Transparent;
            this.lbltelefon.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltelefon.ForeColor = System.Drawing.Color.Black;
            this.lbltelefon.Location = new System.Drawing.Point(256, 287);
            this.lbltelefon.Name = "lbltelefon";
            this.lbltelefon.Size = new System.Drawing.Size(67, 21);
            this.lbltelefon.TabIndex = 16;
            this.lbltelefon.Text = "Telefon";
            // 
            // txtaraba
            // 
            this.txtaraba.Location = new System.Drawing.Point(573, 259);
            this.txtaraba.Name = "txtaraba";
            this.txtaraba.Size = new System.Drawing.Size(147, 20);
            this.txtaraba.TabIndex = 19;
            // 
            // lblaraba
            // 
            this.lblaraba.AutoSize = true;
            this.lblaraba.BackColor = System.Drawing.Color.Transparent;
            this.lblaraba.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaraba.ForeColor = System.Drawing.Color.Black;
            this.lblaraba.Location = new System.Drawing.Point(494, 256);
            this.lblaraba.Name = "lblaraba";
            this.lblaraba.Size = new System.Drawing.Size(55, 21);
            this.lblaraba.TabIndex = 18;
            this.lblaraba.Text = "Araba";
            // 
            // lblıd
            // 
            this.lblıd.AutoSize = true;
            this.lblıd.BackColor = System.Drawing.Color.Transparent;
            this.lblıd.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblıd.ForeColor = System.Drawing.Color.Black;
            this.lblıd.Location = new System.Drawing.Point(535, 290);
            this.lblıd.Name = "lblıd";
            this.lblıd.Size = new System.Drawing.Size(20, 21);
            this.lblıd.TabIndex = 20;
            this.lblıd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(502, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Id";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTemizle.BackgroundImage")));
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Agency FB", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTemizle.Location = new System.Drawing.Point(240, 336);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(52, 46);
            this.btnTemizle.TabIndex = 22;
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Bilgi_Formu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.lblıd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaraba);
            this.Controls.Add(this.lblaraba);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.lbltelefon);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.lblmail);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.lblsoyad);
            this.Controls.Add(this.lblad);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.dgwlist);
            this.Name = "Bilgi_Formu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgi_Formu";
            this.Load += new System.EventHandler(this.Bilgi_Formu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwlist;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblsoyad;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Label lblmail;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label lbltelefon;
        private System.Windows.Forms.TextBox txtaraba;
        private System.Windows.Forms.Label lblaraba;
        private System.Windows.Forms.Label lblıd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemizle;
    }
}