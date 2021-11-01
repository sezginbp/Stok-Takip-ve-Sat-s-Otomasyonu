
namespace stoktakip
{
    partial class frmMüşteriListeleme
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtEmailML = new System.Windows.Forms.TextBox();
            this.txtAdresML = new System.Windows.Forms.TextBox();
            this.txtTelefonML = new System.Windows.Forms.TextBox();
            this.txtAdSoyadML = new System.Windows.Forms.TextBox();
            this.txtTcML = new System.Windows.Forms.TextBox();
            this.lblEmailME = new System.Windows.Forms.Label();
            this.lblAdresME = new System.Windows.Forms.Label();
            this.lblTelefonME = new System.Windows.Forms.Label();
            this.lblAdSoyadME = new System.Windows.Forms.Label();
            this.lblTcME = new System.Windows.Forms.Label();
            this.btnGuncelleML = new System.Windows.Forms.Button();
            this.btnSilML = new System.Windows.Forms.Button();
            this.lblTcAraML = new System.Windows.Forms.Label();
            this.txtTcAraML = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(982, 525);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // txtEmailML
            // 
            this.txtEmailML.Location = new System.Drawing.Point(79, 318);
            this.txtEmailML.Name = "txtEmailML";
            this.txtEmailML.Size = new System.Drawing.Size(103, 20);
            this.txtEmailML.TabIndex = 19;
            // 
            // txtAdresML
            // 
            this.txtAdresML.Location = new System.Drawing.Point(79, 265);
            this.txtAdresML.Name = "txtAdresML";
            this.txtAdresML.Size = new System.Drawing.Size(103, 20);
            this.txtAdresML.TabIndex = 18;
            // 
            // txtTelefonML
            // 
            this.txtTelefonML.Location = new System.Drawing.Point(79, 212);
            this.txtTelefonML.Name = "txtTelefonML";
            this.txtTelefonML.Size = new System.Drawing.Size(103, 20);
            this.txtTelefonML.TabIndex = 17;
            // 
            // txtAdSoyadML
            // 
            this.txtAdSoyadML.Location = new System.Drawing.Point(79, 159);
            this.txtAdSoyadML.Name = "txtAdSoyadML";
            this.txtAdSoyadML.Size = new System.Drawing.Size(103, 20);
            this.txtAdSoyadML.TabIndex = 16;
            // 
            // txtTcML
            // 
            this.txtTcML.Location = new System.Drawing.Point(79, 106);
            this.txtTcML.Name = "txtTcML";
            this.txtTcML.Size = new System.Drawing.Size(103, 20);
            this.txtTcML.TabIndex = 15;
            // 
            // lblEmailME
            // 
            this.lblEmailME.AutoSize = true;
            this.lblEmailME.Location = new System.Drawing.Point(19, 325);
            this.lblEmailME.Name = "lblEmailME";
            this.lblEmailME.Size = new System.Drawing.Size(35, 13);
            this.lblEmailME.TabIndex = 14;
            this.lblEmailME.Text = "E-mail";
            // 
            // lblAdresME
            // 
            this.lblAdresME.AutoSize = true;
            this.lblAdresME.Location = new System.Drawing.Point(19, 272);
            this.lblAdresME.Name = "lblAdresME";
            this.lblAdresME.Size = new System.Drawing.Size(34, 13);
            this.lblAdresME.TabIndex = 13;
            this.lblAdresME.Text = "Adres";
            // 
            // lblTelefonME
            // 
            this.lblTelefonME.AutoSize = true;
            this.lblTelefonME.Location = new System.Drawing.Point(15, 219);
            this.lblTelefonME.Name = "lblTelefonME";
            this.lblTelefonME.Size = new System.Drawing.Size(43, 13);
            this.lblTelefonME.TabIndex = 12;
            this.lblTelefonME.Text = "Telefon";
            // 
            // lblAdSoyadME
            // 
            this.lblAdSoyadME.AutoSize = true;
            this.lblAdSoyadME.Location = new System.Drawing.Point(10, 166);
            this.lblAdSoyadME.Name = "lblAdSoyadME";
            this.lblAdSoyadME.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyadME.TabIndex = 11;
            this.lblAdSoyadME.Text = "Ad Soyad";
            // 
            // lblTcME
            // 
            this.lblTcME.AutoSize = true;
            this.lblTcME.Location = new System.Drawing.Point(24, 113);
            this.lblTcME.Name = "lblTcME";
            this.lblTcME.Size = new System.Drawing.Size(24, 13);
            this.lblTcME.TabIndex = 10;
            this.lblTcME.Text = "TC:";
            // 
            // btnGuncelleML
            // 
            this.btnGuncelleML.Location = new System.Drawing.Point(120, 355);
            this.btnGuncelleML.Name = "btnGuncelleML";
            this.btnGuncelleML.Size = new System.Drawing.Size(78, 21);
            this.btnGuncelleML.TabIndex = 20;
            this.btnGuncelleML.Text = "Güncelle";
            this.btnGuncelleML.UseVisualStyleBackColor = true;
            this.btnGuncelleML.Click += new System.EventHandler(this.btnGuncelleML_Click);
            // 
            // btnSilML
            // 
            this.btnSilML.Location = new System.Drawing.Point(1201, 108);
            this.btnSilML.Name = "btnSilML";
            this.btnSilML.Size = new System.Drawing.Size(56, 51);
            this.btnSilML.TabIndex = 21;
            this.btnSilML.Text = "Sil";
            this.btnSilML.UseVisualStyleBackColor = true;
            this.btnSilML.Click += new System.EventHandler(this.btnSilML_Click);
            // 
            // lblTcAraML
            // 
            this.lblTcAraML.AutoSize = true;
            this.lblTcAraML.Location = new System.Drawing.Point(985, 41);
            this.lblTcAraML.Name = "lblTcAraML";
            this.lblTcAraML.Size = new System.Drawing.Size(46, 13);
            this.lblTcAraML.TabIndex = 23;
            this.lblTcAraML.Text = "TC Ara :";
            // 
            // txtTcAraML
            // 
            this.txtTcAraML.Location = new System.Drawing.Point(1052, 40);
            this.txtTcAraML.Name = "txtTcAraML";
            this.txtTcAraML.Size = new System.Drawing.Size(133, 20);
            this.txtTcAraML.TabIndex = 24;
            this.txtTcAraML.TextChanged += new System.EventHandler(this.txtTcAraML_TextChanged);
            // 
            // frmMüşteriListeleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 688);
            this.Controls.Add(this.txtTcAraML);
            this.Controls.Add(this.lblTcAraML);
            this.Controls.Add(this.btnSilML);
            this.Controls.Add(this.btnGuncelleML);
            this.Controls.Add(this.txtEmailML);
            this.Controls.Add(this.txtAdresML);
            this.Controls.Add(this.txtTelefonML);
            this.Controls.Add(this.txtAdSoyadML);
            this.Controls.Add(this.txtTcML);
            this.Controls.Add(this.lblEmailME);
            this.Controls.Add(this.lblAdresME);
            this.Controls.Add(this.lblTelefonME);
            this.Controls.Add(this.lblAdSoyadME);
            this.Controls.Add(this.lblTcME);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMüşteriListeleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusteriListeleme";
            this.Load += new System.EventHandler(this.MusteriListeleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmailML;
        private System.Windows.Forms.TextBox txtAdresML;
        private System.Windows.Forms.TextBox txtTelefonML;
        private System.Windows.Forms.TextBox txtAdSoyadML;
        private System.Windows.Forms.TextBox txtTcML;
        private System.Windows.Forms.Label lblEmailME;
        private System.Windows.Forms.Label lblAdresME;
        private System.Windows.Forms.Label lblTelefonME;
        private System.Windows.Forms.Label lblAdSoyadME;
        private System.Windows.Forms.Label lblTcME;
        private System.Windows.Forms.Button btnGuncelleML;
        private System.Windows.Forms.Button btnSilML;
        private System.Windows.Forms.Label lblTcAraML;
        private System.Windows.Forms.TextBox txtTcAraML;
    }
}