namespace ZincirMarketProje
{
    partial class Urünlerim
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
            this.grp_personelBilgi = new System.Windows.Forms.GroupBox();
            this.dgw_ürünBilgi = new System.Windows.Forms.DataGridView();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_ürünFiyati = new System.Windows.Forms.TextBox();
            this.txt_müsteriId = new System.Windows.Forms.TextBox();
            this.txt_ürünCins = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_personelBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ürünBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_personelBilgi
            // 
            this.grp_personelBilgi.Controls.Add(this.dgw_ürünBilgi);
            this.grp_personelBilgi.Location = new System.Drawing.Point(417, 18);
            this.grp_personelBilgi.Name = "grp_personelBilgi";
            this.grp_personelBilgi.Size = new System.Drawing.Size(385, 373);
            this.grp_personelBilgi.TabIndex = 44;
            this.grp_personelBilgi.TabStop = false;
            this.grp_personelBilgi.Text = "Ürün Bilgisi";
            // 
            // dgw_ürünBilgi
            // 
            this.dgw_ürünBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ürünBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_ürünBilgi.Location = new System.Drawing.Point(3, 16);
            this.dgw_ürünBilgi.Name = "dgw_ürünBilgi";
            this.dgw_ürünBilgi.Size = new System.Drawing.Size(379, 354);
            this.dgw_ürünBilgi.TabIndex = 0;
            this.dgw_ürünBilgi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_ürünBilgi_CellClick);
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(326, 237);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 6;
            this.btn_arama.Text = "ARAMA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(16, 194);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(385, 23);
            this.btn_listele.TabIndex = 7;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(229, 237);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(126, 237);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 4;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(30, 237);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_ürünFiyati
            // 
            this.txt_ürünFiyati.Location = new System.Drawing.Point(190, 73);
            this.txt_ürünFiyati.Name = "txt_ürünFiyati";
            this.txt_ürünFiyati.Size = new System.Drawing.Size(197, 20);
            this.txt_ürünFiyati.TabIndex = 1;
            // 
            // txt_müsteriId
            // 
            this.txt_müsteriId.Location = new System.Drawing.Point(190, 114);
            this.txt_müsteriId.Name = "txt_müsteriId";
            this.txt_müsteriId.Size = new System.Drawing.Size(197, 20);
            this.txt_müsteriId.TabIndex = 2;
            // 
            // txt_ürünCins
            // 
            this.txt_ürünCins.Location = new System.Drawing.Point(190, 35);
            this.txt_ürünCins.Name = "txt_ürünCins";
            this.txt_ürünCins.Size = new System.Drawing.Size(197, 20);
            this.txt_ürünCins.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Müşteri ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Ürün Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Ürün Cinsi";
            // 
            // Urünlerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 424);
            this.Controls.Add(this.grp_personelBilgi);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_ürünFiyati);
            this.Controls.Add(this.txt_müsteriId);
            this.Controls.Add(this.txt_ürünCins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Urünlerim";
            this.Text = "Urünlerim";
            this.grp_personelBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ürünBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grp_personelBilgi;
        private System.Windows.Forms.DataGridView dgw_ürünBilgi;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_ürünFiyati;
        private System.Windows.Forms.TextBox txt_müsteriId;
        private System.Windows.Forms.TextBox txt_ürünCins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}