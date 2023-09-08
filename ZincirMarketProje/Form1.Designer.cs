namespace ZincirMarketProje
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_adSoyad = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_sehir = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_arama = new System.Windows.Forms.Button();
            this.grp_müsteriBilgi = new System.Windows.Forms.GroupBox();
            this.dgw_müsteriBilgi = new System.Windows.Forms.DataGridView();
            this.grp_müsteriBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_müsteriBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Adı-Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(24, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefonu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şehir";
            // 
            // txt_adSoyad
            // 
            this.txt_adSoyad.Location = new System.Drawing.Point(202, 34);
            this.txt_adSoyad.Name = "txt_adSoyad";
            this.txt_adSoyad.Size = new System.Drawing.Size(197, 20);
            this.txt_adSoyad.TabIndex = 0;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(202, 89);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(197, 20);
            this.txt_telefon.TabIndex = 1;
            // 
            // txt_sehir
            // 
            this.txt_sehir.Location = new System.Drawing.Point(202, 139);
            this.txt_sehir.Name = "txt_sehir";
            this.txt_sehir.Size = new System.Drawing.Size(197, 20);
            this.txt_sehir.TabIndex = 2;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(42, 370);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(138, 370);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 4;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(28, 327);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(385, 23);
            this.btn_listele.TabIndex = 7;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(241, 370);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(338, 370);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 6;
            this.btn_arama.Text = "ARAMA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // grp_müsteriBilgi
            // 
            this.grp_müsteriBilgi.Controls.Add(this.dgw_müsteriBilgi);
            this.grp_müsteriBilgi.Location = new System.Drawing.Point(28, 184);
            this.grp_müsteriBilgi.Name = "grp_müsteriBilgi";
            this.grp_müsteriBilgi.Size = new System.Drawing.Size(385, 124);
            this.grp_müsteriBilgi.TabIndex = 9;
            this.grp_müsteriBilgi.TabStop = false;
            this.grp_müsteriBilgi.Text = "Müşteri Bilgisi";
            // 
            // dgw_müsteriBilgi
            // 
            this.dgw_müsteriBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_müsteriBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_müsteriBilgi.Location = new System.Drawing.Point(3, 16);
            this.dgw_müsteriBilgi.Name = "dgw_müsteriBilgi";
            this.dgw_müsteriBilgi.Size = new System.Drawing.Size(379, 105);
            this.dgw_müsteriBilgi.TabIndex = 0;
            this.dgw_müsteriBilgi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_müsteriBilgi_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 416);
            this.Controls.Add(this.grp_müsteriBilgi);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_sehir);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_adSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Müşteri Bilgileri";
            this.grp_müsteriBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_müsteriBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_adSoyad;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_sehir;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.GroupBox grp_müsteriBilgi;
        private System.Windows.Forms.DataGridView dgw_müsteriBilgi;
    }
}

