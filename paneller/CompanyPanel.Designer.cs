namespace paneller
{
    partial class CompanyPanel
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
            this.btnaracekle = new System.Windows.Forms.Button();
            this.comboBoxVehicles = new System.Windows.Forms.ComboBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxaracisim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewaracsefer = new System.Windows.Forms.DataGridView();
            this.btnaracsil = new System.Windows.Forms.Button();
            this.btnyenidurakekle = new System.Windows.Forms.Button();
            this.comboseferaracekle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combobasnok = new System.Windows.Forms.ComboBox();
            this.combobitnok = new System.Windows.Forms.ComboBox();
            this.btnsefersil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxCapacity = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSeferTarihiGuncelle = new System.Windows.Forms.Button();
            this.dateTimePickerSeferTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboSilinecekArac = new System.Windows.Forms.ComboBox();
            this.comboSilinecekSefer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaracsefer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnaracekle
            // 
            this.btnaracekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaracekle.Location = new System.Drawing.Point(337, 149);
            this.btnaracekle.Name = "btnaracekle";
            this.btnaracekle.Size = new System.Drawing.Size(228, 72);
            this.btnaracekle.TabIndex = 0;
            this.btnaracekle.Text = "Araç Ekle";
            this.btnaracekle.UseVisualStyleBackColor = true;
            this.btnaracekle.Click += new System.EventHandler(this.btnaracekle_Click);
            // 
            // comboBoxVehicles
            // 
            this.comboBoxVehicles.FormattingEnabled = true;
            this.comboBoxVehicles.Location = new System.Drawing.Point(19, 68);
            this.comboBoxVehicles.Name = "comboBoxVehicles";
            this.comboBoxVehicles.Size = new System.Drawing.Size(134, 24);
            this.comboBoxVehicles.TabIndex = 1;
            this.comboBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.comboBoxVehicles_SelectedIndexChanged);
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Location = new System.Drawing.Point(182, 68);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(134, 22);
            this.textBoxFuel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yakıt Türü";
            // 
            // textBoxaracisim
            // 
            this.textBoxaracisim.Location = new System.Drawing.Point(337, 68);
            this.textBoxaracisim.Name = "textBoxaracisim";
            this.textBoxaracisim.Size = new System.Drawing.Size(222, 22);
            this.textBoxaracisim.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Araç İsmi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Araç Tipi";
            // 
            // dataGridViewaracsefer
            // 
            this.dataGridViewaracsefer.AllowUserToAddRows = false;
            this.dataGridViewaracsefer.AllowUserToDeleteRows = false;
            this.dataGridViewaracsefer.AllowUserToResizeColumns = false;
            this.dataGridViewaracsefer.AllowUserToResizeRows = false;
            this.dataGridViewaracsefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewaracsefer.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewaracsefer.Name = "dataGridViewaracsefer";
            this.dataGridViewaracsefer.ReadOnly = true;
            this.dataGridViewaracsefer.RowHeadersVisible = false;
            this.dataGridViewaracsefer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewaracsefer.RowTemplate.Height = 24;
            this.dataGridViewaracsefer.Size = new System.Drawing.Size(707, 324);
            this.dataGridViewaracsefer.TabIndex = 7;
            // 
            // btnaracsil
            // 
            this.btnaracsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaracsil.Location = new System.Drawing.Point(129, 395);
            this.btnaracsil.Name = "btnaracsil";
            this.btnaracsil.Size = new System.Drawing.Size(164, 66);
            this.btnaracsil.TabIndex = 8;
            this.btnaracsil.Text = "Seçilen Aracı Sil";
            this.btnaracsil.UseVisualStyleBackColor = true;
            this.btnaracsil.Click += new System.EventHandler(this.btnaracsil_Click);
            // 
            // btnyenidurakekle
            // 
            this.btnyenidurakekle.Location = new System.Drawing.Point(488, 54);
            this.btnyenidurakekle.Name = "btnyenidurakekle";
            this.btnyenidurakekle.Size = new System.Drawing.Size(134, 48);
            this.btnyenidurakekle.TabIndex = 9;
            this.btnyenidurakekle.Text = "Sefere Durak Ekleyin";
            this.btnyenidurakekle.UseVisualStyleBackColor = true;
            this.btnyenidurakekle.Click += new System.EventHandler(this.btnyenidurakekle_Click);
            // 
            // comboseferaracekle
            // 
            this.comboseferaracekle.FormattingEnabled = true;
            this.comboseferaracekle.Location = new System.Drawing.Point(25, 67);
            this.comboseferaracekle.Name = "comboseferaracekle";
            this.comboseferaracekle.Size = new System.Drawing.Size(134, 24);
            this.comboseferaracekle.TabIndex = 10;
            this.comboseferaracekle.SelectedValueChanged += new System.EventHandler(this.comboseferaracekle_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Araç Seçin";
            // 
            // combobasnok
            // 
            this.combobasnok.FormattingEnabled = true;
            this.combobasnok.Location = new System.Drawing.Point(179, 67);
            this.combobasnok.Name = "combobasnok";
            this.combobasnok.Size = new System.Drawing.Size(134, 24);
            this.combobasnok.TabIndex = 13;
            this.combobasnok.SelectedValueChanged += new System.EventHandler(this.combobasnok_SelectedValueChanged);
            // 
            // combobitnok
            // 
            this.combobitnok.FormattingEnabled = true;
            this.combobitnok.Location = new System.Drawing.Point(337, 67);
            this.combobitnok.Name = "combobitnok";
            this.combobitnok.Size = new System.Drawing.Size(134, 24);
            this.combobitnok.TabIndex = 14;
            this.combobitnok.SelectedValueChanged += new System.EventHandler(this.combobitnok_SelectedValueChanged);
            // 
            // btnsefersil
            // 
            this.btnsefersil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsefersil.Location = new System.Drawing.Point(449, 395);
            this.btnsefersil.Name = "btnsefersil";
            this.btnsefersil.Size = new System.Drawing.Size(164, 66);
            this.btnsefersil.TabIndex = 15;
            this.btnsefersil.Text = "Seçilen Aracın Seferini Sil";
            this.btnsefersil.UseVisualStyleBackColor = true;
            this.btnsefersil.Click += new System.EventHandler(this.btnsefersil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Başlangıç Noktası";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Bitiş Noktası";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBoxCapacity);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBoxaracisim);
            this.groupBox1.Controls.Add(this.btnaracekle);
            this.groupBox1.Controls.Add(this.comboBoxVehicles);
            this.groupBox1.Controls.Add(this.textBoxFuel);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(769, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 257);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Araç Bilgileri";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(134, 22);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 222);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 22);
            this.textBox3.TabIndex = 7;
            // 
            // textBoxCapacity
            // 
            this.textBoxCapacity.Location = new System.Drawing.Point(176, 149);
            this.textBoxCapacity.Name = "textBoxCapacity";
            this.textBoxCapacity.Size = new System.Drawing.Size(134, 22);
            this.textBoxCapacity.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(173, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 32);
            this.label10.TabIndex = 6;
            this.label10.Text = "Hizmetli\nPersonel Ücreti";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kapasite";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 32);
            this.label9.TabIndex = 6;
            this.label9.Text = "Araç Kullanan\nPersonel Ücreti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yakıt Ücreti";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSeferTarihiGuncelle);
            this.groupBox2.Controls.Add(this.dateTimePickerSeferTarihi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnyenidurakekle);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboseferaracekle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.combobasnok);
            this.groupBox2.Controls.Add(this.combobitnok);
            this.groupBox2.Location = new System.Drawing.Point(769, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 240);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Sefer Bilgileri";
            // 
            // buttonSeferTarihiGuncelle
            // 
            this.buttonSeferTarihiGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeferTarihiGuncelle.Location = new System.Drawing.Point(271, 159);
            this.buttonSeferTarihiGuncelle.Name = "buttonSeferTarihiGuncelle";
            this.buttonSeferTarihiGuncelle.Size = new System.Drawing.Size(200, 43);
            this.buttonSeferTarihiGuncelle.TabIndex = 19;
            this.buttonSeferTarihiGuncelle.Text = "Seferin Tarihini Güncelle";
            this.buttonSeferTarihiGuncelle.UseVisualStyleBackColor = true;
            this.buttonSeferTarihiGuncelle.Click += new System.EventHandler(this.buttonSeferTarihiGuncelle_Click);
            // 
            // dateTimePickerSeferTarihi
            // 
            this.dateTimePickerSeferTarihi.Location = new System.Drawing.Point(25, 167);
            this.dateTimePickerSeferTarihi.Name = "dateTimePickerSeferTarihi";
            this.dateTimePickerSeferTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSeferTarihi.TabIndex = 18;
            // 
            // comboSilinecekArac
            // 
            this.comboSilinecekArac.FormattingEnabled = true;
            this.comboSilinecekArac.Location = new System.Drawing.Point(129, 358);
            this.comboSilinecekArac.Name = "comboSilinecekArac";
            this.comboSilinecekArac.Size = new System.Drawing.Size(164, 24);
            this.comboSilinecekArac.TabIndex = 20;
            // 
            // comboSilinecekSefer
            // 
            this.comboSilinecekSefer.FormattingEnabled = true;
            this.comboSilinecekSefer.Location = new System.Drawing.Point(449, 358);
            this.comboSilinecekSefer.Name = "comboSilinecekSefer";
            this.comboSilinecekSefer.Size = new System.Drawing.Size(164, 24);
            this.comboSilinecekSefer.TabIndex = 21;
            // 
            // CompanyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 571);
            this.Controls.Add(this.comboSilinecekSefer);
            this.Controls.Add(this.comboSilinecekArac);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsefersil);
            this.Controls.Add(this.btnaracsil);
            this.Controls.Add(this.dataGridViewaracsefer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CompanyPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompanyPanel_FormClosed);
            this.Load += new System.EventHandler(this.CompanyPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewaracsefer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnaracekle;
        private System.Windows.Forms.ComboBox comboBoxVehicles;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxaracisim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewaracsefer;
        private System.Windows.Forms.Button btnaracsil;
        private System.Windows.Forms.Button btnyenidurakekle;
        private System.Windows.Forms.ComboBox comboseferaracekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combobasnok;
        private System.Windows.Forms.ComboBox combobitnok;
        private System.Windows.Forms.Button btnsefersil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboSilinecekArac;
        private System.Windows.Forms.ComboBox comboSilinecekSefer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxCapacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonSeferTarihiGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimePickerSeferTarihi;
    }
}