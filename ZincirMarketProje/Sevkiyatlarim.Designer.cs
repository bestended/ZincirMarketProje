namespace ZincirMarketProje
{
    partial class Sevkiyatlarim
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
            this.label5 = new System.Windows.Forms.Label();
            this.grp_personelBilgi = new System.Windows.Forms.GroupBox();
            this.dgw_sevkiyatBilgi = new System.Windows.Forms.DataGridView();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_maas = new System.Windows.Forms.TextBox();
            this.txt_sürücüAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_vardiya = new System.Windows.Forms.TextBox();
            this.txt_depoId = new System.Windows.Forms.TextBox();
            this.grp_personelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sevkiyatBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(12, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Depo Id";
            // 
            // grp_personelBilgi
            // 
            this.grp_personelBilgi.Controls.Add(this.dgw_sevkiyatBilgi);
            this.grp_personelBilgi.Location = new System.Drawing.Point(417, 19);
            this.grp_personelBilgi.Name = "grp_personelBilgi";
            this.grp_personelBilgi.Size = new System.Drawing.Size(385, 373);
            this.grp_personelBilgi.TabIndex = 44;
            this.grp_personelBilgi.TabStop = false;
            this.grp_personelBilgi.Text = "Sevkiyat Bilgisi";
            // 
            // dgw_sevkiyatBilgi
            // 
            this.dgw_sevkiyatBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_sevkiyatBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_sevkiyatBilgi.Location = new System.Drawing.Point(3, 16);
            this.dgw_sevkiyatBilgi.Name = "dgw_sevkiyatBilgi";
            this.dgw_sevkiyatBilgi.Size = new System.Drawing.Size(379, 354);
            this.dgw_sevkiyatBilgi.TabIndex = 0;
            this.dgw_sevkiyatBilgi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_sevkiyatBilgi_CellClick);
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(326, 303);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 8;
            this.btn_arama.Text = "ARAMA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(16, 260);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(385, 23);
            this.btn_listele.TabIndex = 9;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(229, 303);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 7;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(126, 303);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 6;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(30, 303);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(190, 74);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(197, 20);
            this.txt_telefon.TabIndex = 1;
            // 
            // txt_maas
            // 
            this.txt_maas.Location = new System.Drawing.Point(190, 115);
            this.txt_maas.Name = "txt_maas";
            this.txt_maas.Size = new System.Drawing.Size(197, 20);
            this.txt_maas.TabIndex = 2;
            // 
            // txt_sürücüAdSoyad
            // 
            this.txt_sürücüAdSoyad.Location = new System.Drawing.Point(190, 36);
            this.txt_sürücüAdSoyad.Name = "txt_sürücüAdSoyad";
            this.txt_sürücüAdSoyad.Size = new System.Drawing.Size(197, 20);
            this.txt_sürücüAdSoyad.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Vardiya";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Maaş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Sürücü Ad Soyad";
            // 
            // txt_vardiya
            // 
            this.txt_vardiya.Location = new System.Drawing.Point(190, 153);
            this.txt_vardiya.Name = "txt_vardiya";
            this.txt_vardiya.Size = new System.Drawing.Size(197, 20);
            this.txt_vardiya.TabIndex = 3;
            // 
            // txt_depoId
            // 
            this.txt_depoId.Location = new System.Drawing.Point(190, 198);
            this.txt_depoId.Name = "txt_depoId";
            this.txt_depoId.Size = new System.Drawing.Size(197, 20);
            this.txt_depoId.TabIndex = 46;
            // 
            // Sevkiyatlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.txt_depoId);
            this.Controls.Add(this.txt_vardiya);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grp_personelBilgi);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_maas);
            this.Controls.Add(this.txt_sürücüAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Sevkiyatlarim";
            this.Text = "Sevkiyatlarim";
            this.grp_personelBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_sevkiyatBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grp_personelBilgi;
        private System.Windows.Forms.DataGridView dgw_sevkiyatBilgi;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_maas;
        private System.Windows.Forms.TextBox txt_sürücüAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_vardiya;
        private System.Windows.Forms.TextBox txt_depoId;
    }
}