namespace ZincirMarketProje
{
    partial class Magazalarim
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
            this.grp_müsteriBilgi = new System.Windows.Forms.GroupBox();
            this.dgw_MagazaBilgi = new System.Windows.Forms.DataGridView();
            this.btn_arama = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_ülkem = new System.Windows.Forms.TextBox();
            this.txt_telefonum = new System.Windows.Forms.TextBox();
            this.txt_sehrim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_plakaNo = new System.Windows.Forms.TextBox();
            this.grp_müsteriBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MagazaBilgi)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_müsteriBilgi
            // 
            this.grp_müsteriBilgi.Controls.Add(this.dgw_MagazaBilgi);
            this.grp_müsteriBilgi.Location = new System.Drawing.Point(37, 226);
            this.grp_müsteriBilgi.Name = "grp_müsteriBilgi";
            this.grp_müsteriBilgi.Size = new System.Drawing.Size(385, 124);
            this.grp_müsteriBilgi.TabIndex = 21;
            this.grp_müsteriBilgi.TabStop = false;
            this.grp_müsteriBilgi.Text = "Mağaza Bilgisi";
            // 
            // dgw_MagazaBilgi
            // 
            this.dgw_MagazaBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_MagazaBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_MagazaBilgi.Location = new System.Drawing.Point(3, 16);
            this.dgw_MagazaBilgi.Name = "dgw_MagazaBilgi";
            this.dgw_MagazaBilgi.Size = new System.Drawing.Size(379, 105);
            this.dgw_MagazaBilgi.TabIndex = 0;
            this.dgw_MagazaBilgi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_MagazaBilgi_CellClick);
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(347, 412);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 7;
            this.btn_arama.Text = "ARAMA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(37, 369);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(385, 23);
            this.btn_listele.TabIndex = 8;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(250, 412);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 6;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(147, 412);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 5;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(51, 412);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_ülkem
            // 
            this.txt_ülkem.Location = new System.Drawing.Point(211, 146);
            this.txt_ülkem.Name = "txt_ülkem";
            this.txt_ülkem.Size = new System.Drawing.Size(197, 20);
            this.txt_ülkem.TabIndex = 2;
            // 
            // txt_telefonum
            // 
            this.txt_telefonum.Location = new System.Drawing.Point(211, 96);
            this.txt_telefonum.Name = "txt_telefonum";
            this.txt_telefonum.Size = new System.Drawing.Size(197, 20);
            this.txt_telefonum.TabIndex = 1;
            // 
            // txt_sehrim
            // 
            this.txt_sehrim.Location = new System.Drawing.Point(211, 41);
            this.txt_sehrim.Name = "txt_sehrim";
            this.txt_sehrim.Size = new System.Drawing.Size(197, 20);
            this.txt_sehrim.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(33, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ülke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefonu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(33, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Araç Plaka No";
            // 
            // txt_plakaNo
            // 
            this.txt_plakaNo.Location = new System.Drawing.Point(211, 181);
            this.txt_plakaNo.Name = "txt_plakaNo";
            this.txt_plakaNo.Size = new System.Drawing.Size(197, 20);
            this.txt_plakaNo.TabIndex = 23;
            // 
            // Magazalarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.txt_plakaNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grp_müsteriBilgi);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_ülkem);
            this.Controls.Add(this.txt_telefonum);
            this.Controls.Add(this.txt_sehrim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Magazalarim";
            this.Text = "Magazalarim";
            this.grp_müsteriBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_MagazaBilgi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_müsteriBilgi;
        private System.Windows.Forms.DataGridView dgw_MagazaBilgi;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox txt_ülkem;
        private System.Windows.Forms.TextBox txt_telefonum;
        private System.Windows.Forms.TextBox txt_sehrim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_plakaNo;
    }
}