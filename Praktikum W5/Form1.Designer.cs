
namespace Praktikum_W5
{
    partial class FormMateri
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
            this.labelData = new System.Windows.Forms.Label();
            this.tBoxData = new System.Windows.Forms.TextBox();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.lBoxKoleksi = new System.Windows.Forms.ListBox();
            this.buttAdd = new System.Windows.Forms.Button();
            this.labelSetting = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.cBoxAktif = new System.Windows.Forms.CheckBox();
            this.rButtMerah = new System.Windows.Forms.RadioButton();
            this.rButtBiru = new System.Windows.Forms.RadioButton();
            this.buttClear = new System.Windows.Forms.Button();
            this.labelTulisan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(32, 22);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 20);
            this.labelData.TabIndex = 0;
            this.labelData.Text = "Data:";
            // 
            // tBoxData
            // 
            this.tBoxData.Location = new System.Drawing.Point(96, 19);
            this.tBoxData.Name = "tBoxData";
            this.tBoxData.Size = new System.Drawing.Size(321, 27);
            this.tBoxData.TabIndex = 1;
            this.tBoxData.TextChanged += new System.EventHandler(this.tBData_TextChanged);
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(32, 63);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(59, 20);
            this.labelKoleksi.TabIndex = 2;
            this.labelKoleksi.Text = "Koleksi:";
            // 
            // lBoxKoleksi
            // 
            this.lBoxKoleksi.FormattingEnabled = true;
            this.lBoxKoleksi.ItemHeight = 20;
            this.lBoxKoleksi.Location = new System.Drawing.Point(32, 95);
            this.lBoxKoleksi.Name = "lBoxKoleksi";
            this.lBoxKoleksi.Size = new System.Drawing.Size(189, 324);
            this.lBoxKoleksi.TabIndex = 3;
            this.lBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.lBoxKoleksi_SelectedIndexChanged);
            // 
            // buttAdd
            // 
            this.buttAdd.Location = new System.Drawing.Point(438, 18);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(94, 29);
            this.buttAdd.TabIndex = 4;
            this.buttAdd.Text = "Add";
            this.buttAdd.UseVisualStyleBackColor = true;
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(290, 63);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(59, 20);
            this.labelSetting.TabIndex = 5;
            this.labelSetting.Text = "Setting:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(290, 176);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(58, 20);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Output:";
            // 
            // cBoxAktif
            // 
            this.cBoxAktif.AutoSize = true;
            this.cBoxAktif.Location = new System.Drawing.Point(355, 63);
            this.cBoxAktif.Name = "cBoxAktif";
            this.cBoxAktif.Size = new System.Drawing.Size(62, 24);
            this.cBoxAktif.TabIndex = 7;
            this.cBoxAktif.Text = "Aktif";
            this.cBoxAktif.UseVisualStyleBackColor = true;
            this.cBoxAktif.CheckedChanged += new System.EventHandler(this.cBoxAktif_CheckedChanged);
            // 
            // rButtMerah
            // 
            this.rButtMerah.AutoSize = true;
            this.rButtMerah.Location = new System.Drawing.Point(321, 95);
            this.rButtMerah.Name = "rButtMerah";
            this.rButtMerah.Size = new System.Drawing.Size(118, 24);
            this.rButtMerah.TabIndex = 8;
            this.rButtMerah.TabStop = true;
            this.rButtMerah.Text = "Warna Merah";
            this.rButtMerah.UseVisualStyleBackColor = true;
            this.rButtMerah.CheckedChanged += new System.EventHandler(this.rButtMerah_CheckedChanged);
            // 
            // rButtBiru
            // 
            this.rButtBiru.AutoSize = true;
            this.rButtBiru.Location = new System.Drawing.Point(321, 125);
            this.rButtBiru.Name = "rButtBiru";
            this.rButtBiru.Size = new System.Drawing.Size(102, 24);
            this.rButtBiru.TabIndex = 9;
            this.rButtBiru.TabStop = true;
            this.rButtBiru.Text = "Warna Biru";
            this.rButtBiru.UseVisualStyleBackColor = true;
            this.rButtBiru.CheckedChanged += new System.EventHandler(this.rButtBiru_CheckedChanged);
            // 
            // buttClear
            // 
            this.buttClear.Location = new System.Drawing.Point(290, 390);
            this.buttClear.Name = "buttClear";
            this.buttClear.Size = new System.Drawing.Size(303, 29);
            this.buttClear.TabIndex = 10;
            this.buttClear.Text = "Clear";
            this.buttClear.UseVisualStyleBackColor = true;
            this.buttClear.Click += new System.EventHandler(this.buttClear_Click);
            // 
            // labelTulisan
            // 
            this.labelTulisan.AutoSize = true;
            this.labelTulisan.Font = new System.Drawing.Font("Segoe UI Historic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTulisan.Location = new System.Drawing.Point(355, 237);
            this.labelTulisan.Name = "labelTulisan";
            this.labelTulisan.Size = new System.Drawing.Size(135, 67);
            this.labelTulisan.TabIndex = 11;
            this.labelTulisan.Text = "Halo";
            // 
            // FormMateri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.labelTulisan);
            this.Controls.Add(this.buttClear);
            this.Controls.Add(this.rButtBiru);
            this.Controls.Add(this.rButtMerah);
            this.Controls.Add(this.cBoxAktif);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.lBoxKoleksi);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.tBoxData);
            this.Controls.Add(this.labelData);
            this.Name = "FormMateri";
            this.Text = "Form Materi";
            this.Load += new System.EventHandler(this.FormMateri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox tBoxData;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.ListBox lBoxKoleksi;
        private System.Windows.Forms.Button buttAdd;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.CheckBox cBoxAktif;
        private System.Windows.Forms.RadioButton rButtMerah;
        private System.Windows.Forms.RadioButton rButtBiru;
        private System.Windows.Forms.Button buttClear;
        private System.Windows.Forms.Label labelTulisan;
    }
}

