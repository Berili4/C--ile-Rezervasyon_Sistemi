namespace paneller
{
    partial class BiletAl
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerSeferAra = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewSeferAra = new System.Windows.Forms.DataGridView();
            this.textBoxYolcuSayisi = new System.Windows.Forms.TextBox();
            this.dataGridViewTumSeferler = new System.Windows.Forms.DataGridView();
            this.buttonTarihGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSeferAra = new System.Windows.Forms.Button();
            this.dateTimePickerTumSeferler = new System.Windows.Forms.DateTimePicker();
            this.comboBoxKalkis = new System.Windows.Forms.ComboBox();
            this.comboBoxVaris = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferAra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumSeferler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kalkış Noktası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(43, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Varış Noktası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yolcu Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih";
            // 
            // dateTimePickerSeferAra
            // 
            this.dateTimePickerSeferAra.Location = new System.Drawing.Point(175, 204);
            this.dateTimePickerSeferAra.Name = "dateTimePickerSeferAra";
            this.dateTimePickerSeferAra.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerSeferAra.TabIndex = 2;
            // 
            // dataGridViewSeferAra
            // 
            this.dataGridViewSeferAra.AllowUserToAddRows = false;
            this.dataGridViewSeferAra.AllowUserToDeleteRows = false;
            this.dataGridViewSeferAra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeferAra.Location = new System.Drawing.Point(434, 67);
            this.dataGridViewSeferAra.Name = "dataGridViewSeferAra";
            this.dataGridViewSeferAra.ReadOnly = true;
            this.dataGridViewSeferAra.RowHeadersWidth = 51;
            this.dataGridViewSeferAra.RowTemplate.Height = 24;
            this.dataGridViewSeferAra.Size = new System.Drawing.Size(470, 226);
            this.dataGridViewSeferAra.TabIndex = 3;
            this.dataGridViewSeferAra.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewSeferAra_RowHeaderMouseDoubleClick);
            // 
            // textBoxYolcuSayisi
            // 
            this.textBoxYolcuSayisi.Location = new System.Drawing.Point(175, 40);
            this.textBoxYolcuSayisi.Name = "textBoxYolcuSayisi";
            this.textBoxYolcuSayisi.Size = new System.Drawing.Size(200, 22);
            this.textBoxYolcuSayisi.TabIndex = 4;
            // 
            // dataGridViewTumSeferler
            // 
            this.dataGridViewTumSeferler.AllowUserToAddRows = false;
            this.dataGridViewTumSeferler.AllowUserToDeleteRows = false;
            this.dataGridViewTumSeferler.AllowUserToResizeColumns = false;
            this.dataGridViewTumSeferler.AllowUserToResizeRows = false;
            this.dataGridViewTumSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTumSeferler.Location = new System.Drawing.Point(974, 67);
            this.dataGridViewTumSeferler.Name = "dataGridViewTumSeferler";
            this.dataGridViewTumSeferler.ReadOnly = true;
            this.dataGridViewTumSeferler.RowHeadersVisible = false;
            this.dataGridViewTumSeferler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewTumSeferler.RowTemplate.Height = 24;
            this.dataGridViewTumSeferler.Size = new System.Drawing.Size(347, 385);
            this.dataGridViewTumSeferler.TabIndex = 5;
            // 
            // buttonTarihGuncelle
            // 
            this.buttonTarihGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTarihGuncelle.Location = new System.Drawing.Point(756, 362);
            this.buttonTarihGuncelle.Name = "buttonTarihGuncelle";
            this.buttonTarihGuncelle.Size = new System.Drawing.Size(200, 63);
            this.buttonTarihGuncelle.TabIndex = 6;
            this.buttonTarihGuncelle.Text = "Güncelle";
            this.buttonTarihGuncelle.UseVisualStyleBackColor = true;
            this.buttonTarihGuncelle.Click += new System.EventHandler(this.buttonTarihGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(968, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(340, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seçilen Gün Tüm Seferler";
            // 
            // buttonSeferAra
            // 
            this.buttonSeferAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSeferAra.Location = new System.Drawing.Point(175, 265);
            this.buttonSeferAra.Name = "buttonSeferAra";
            this.buttonSeferAra.Size = new System.Drawing.Size(200, 63);
            this.buttonSeferAra.TabIndex = 6;
            this.buttonSeferAra.TabStop = false;
            this.buttonSeferAra.Text = "Sefer Bul";
            this.buttonSeferAra.UseVisualStyleBackColor = true;
            this.buttonSeferAra.Click += new System.EventHandler(this.buttonSeferAra_Click);
            // 
            // dateTimePickerTumSeferler
            // 
            this.dateTimePickerTumSeferler.Location = new System.Drawing.Point(756, 317);
            this.dateTimePickerTumSeferler.Name = "dateTimePickerTumSeferler";
            this.dateTimePickerTumSeferler.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTumSeferler.TabIndex = 8;
            // 
            // comboBoxKalkis
            // 
            this.comboBoxKalkis.FormattingEnabled = true;
            this.comboBoxKalkis.Location = new System.Drawing.Point(175, 96);
            this.comboBoxKalkis.Name = "comboBoxKalkis";
            this.comboBoxKalkis.Size = new System.Drawing.Size(200, 24);
            this.comboBoxKalkis.TabIndex = 9;
            // 
            // comboBoxVaris
            // 
            this.comboBoxVaris.FormattingEnabled = true;
            this.comboBoxVaris.Location = new System.Drawing.Point(175, 153);
            this.comboBoxVaris.Name = "comboBoxVaris";
            this.comboBoxVaris.Size = new System.Drawing.Size(200, 24);
            this.comboBoxVaris.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(428, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sefer Seçiniz";
            // 
            // BiletAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 464);
            this.Controls.Add(this.comboBoxVaris);
            this.Controls.Add(this.comboBoxKalkis);
            this.Controls.Add(this.dateTimePickerTumSeferler);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSeferAra);
            this.Controls.Add(this.buttonTarihGuncelle);
            this.Controls.Add(this.dataGridViewTumSeferler);
            this.Controls.Add(this.textBoxYolcuSayisi);
            this.Controls.Add(this.dataGridViewSeferAra);
            this.Controls.Add(this.dateTimePickerSeferAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "BiletAl";
            this.Text = "BiletAl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BiletAl_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeferAra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTumSeferler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerSeferAra;
        private System.Windows.Forms.DataGridView dataGridViewSeferAra;
        private System.Windows.Forms.TextBox textBoxYolcuSayisi;
        private System.Windows.Forms.DataGridView dataGridViewTumSeferler;
        private System.Windows.Forms.Button buttonTarihGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSeferAra;
        private System.Windows.Forms.DateTimePicker dateTimePickerTumSeferler;
        private System.Windows.Forms.ComboBox comboBoxKalkis;
        private System.Windows.Forms.ComboBox comboBoxVaris;
        private System.Windows.Forms.Label label6;
    }
}