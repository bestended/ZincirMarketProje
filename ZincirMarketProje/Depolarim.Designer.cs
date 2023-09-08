namespace ZincirMarketProje
{
    partial class Depolarim
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
            this.lblnn = new System.Windows.Forms.Label();
            this.txt_ürünIsim = new System.Windows.Forms.TextBox();
            this.txt_depoSorumlusu = new System.Windows.Forms.TextBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_arama = new System.Windows.Forms.Button();
            this.dgw_DepoBilgi = new System.Windows.Forms.DataGridView();
            this.grp_müsteriBilgi = new System.Windows.Forms.GroupBox();
            this.txt_ürünId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_DepoBilgi)).BeginInit();
            this.grp_müsteriBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün isimleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(55, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Depo Sorumlusu";
            // 
            // lblnn
            // 
            this.lblnn.AutoSize = true;
            this.lblnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblnn.Location = new System.Drawing.Point(55, 160);
            this.lblnn.Name = "lblnn";
            this.lblnn.Size = new System.Drawing.Size(69, 20);
            this.lblnn.TabIndex = 6;
            this.lblnn.Text = "Ürün Id";
            // 
            // txt_ürünIsim
            // 
            this.txt_ürünIsim.Location = new System.Drawing.Point(233, 57);
            this.txt_ürünIsim.Name = "txt_ürünIsim";
            this.txt_ürünIsim.Size = new System.Drawing.Size(197, 20);
            this.txt_ürünIsim.TabIndex = 0;
            // 
            // txt_depoSorumlusu
            // 
            this.txt_depoSorumlusu.Location = new System.Drawing.Point(233, 112);
            this.txt_depoSorumlusu.Name = "txt_depoSorumlusu";
            this.txt_depoSorumlusu.Size = new System.Drawing.Size(197, 20);
            this.txt_depoSorumlusu.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(73, 390);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 3;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.Location = new System.Drawing.Point(169, 390);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_güncelle.TabIndex = 4;
            this.btn_güncelle.Text = "GÜNCELLE";
            this.btn_güncelle.UseVisualStyleBackColor = true;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(272, 390);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 5;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_listele
            // 
            this.btn_listele.Location = new System.Drawing.Point(59, 347);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(385, 23);
            this.btn_listele.TabIndex = 7;
            this.btn_listele.Text = "LİSTELE";
            this.btn_listele.UseVisualStyleBackColor = true;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_arama
            // 
            this.btn_arama.Location = new System.Drawing.Point(369, 390);
            this.btn_arama.Name = "btn_arama";
            this.btn_arama.Size = new System.Drawing.Size(75, 23);
            this.btn_arama.TabIndex = 6;
            this.btn_arama.Text = "ARAMA";
            this.btn_arama.UseVisualStyleBackColor = true;
            this.btn_arama.Click += new System.EventHandler(this.btn_arama_Click);
            // 
            // dgw_DepoBilgi
            // 
            this.dgw_DepoBilgi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_DepoBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgw_DepoBilgi.Location = new System.Drawing.Point(3, 16);
            this.dgw_DepoBilgi.Name = "dgw_DepoBilgi";
            this.dgw_DepoBilgi.Size = new System.Drawing.Size(379, 105);
            this.dgw_DepoBilgi.TabIndex = 0;
            this.dgw_DepoBilgi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_DepoBilgi_CellClick);
            // 
            // grp_müsteriBilgi
            // 
            this.grp_müsteriBilgi.Controls.Add(this.dgw_DepoBilgi);
            this.grp_müsteriBilgi.Location = new System.Drawing.Point(59, 207);
            this.grp_müsteriBilgi.Name = "grp_müsteriBilgi";
            this.grp_müsteriBilgi.Size = new System.Drawing.Size(385, 124);
            this.grp_müsteriBilgi.TabIndex = 16;
            this.grp_müsteriBilgi.TabStop = false;
            this.grp_müsteriBilgi.Text = "Müşteri Bilgisi";
            // 
            // txt_ürünId
            // 
            this.txt_ürünId.Location = new System.Drawing.Point(233, 160);
            this.txt_ürünId.Name = "txt_ürünId";
            this.txt_ürünId.Size = new System.Drawing.Size(197, 20);
            this.txt_ürünId.TabIndex = 17;
            // 
            // Depolarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.txt_ürünId);
            this.Controls.Add(this.grp_müsteriBilgi);
            this.Controls.Add(this.btn_arama);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_güncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_depoSorumlusu);
            this.Controls.Add(this.txt_ürünIsim);
            this.Controls.Add(this.lblnn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Depolarim";
            this.Text = "Depolarim";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_DepoBilgi)).EndInit();
            this.grp_müsteriBilgi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnn;
        private System.Windows.Forms.TextBox txt_ürünIsim;
        private System.Windows.Forms.TextBox txt_depoSorumlusu;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_arama;
        private System.Windows.Forms.DataGridView dgw_DepoBilgi;
        private System.Windows.Forms.GroupBox grp_müsteriBilgi;
        private System.Windows.Forms.TextBox txt_ürünId;
    }
}