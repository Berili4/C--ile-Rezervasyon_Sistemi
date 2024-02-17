namespace paneller
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
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnfirma = new System.Windows.Forms.Button();
            this.btnbiletal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadmin
            // 
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnadmin.Location = new System.Drawing.Point(84, 38);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(294, 88);
            this.btnadmin.TabIndex = 0;
            this.btnadmin.Text = "Admin Paneli";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnfirma
            // 
            this.btnfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnfirma.Location = new System.Drawing.Point(84, 162);
            this.btnfirma.Name = "btnfirma";
            this.btnfirma.Size = new System.Drawing.Size(294, 88);
            this.btnfirma.TabIndex = 0;
            this.btnfirma.Text = "Firma Paneli";
            this.btnfirma.UseVisualStyleBackColor = true;
            this.btnfirma.Click += new System.EventHandler(this.btnfirma_Click);
            // 
            // btnbiletal
            // 
            this.btnbiletal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbiletal.Location = new System.Drawing.Point(84, 286);
            this.btnbiletal.Name = "btnbiletal";
            this.btnbiletal.Size = new System.Drawing.Size(294, 88);
            this.btnbiletal.TabIndex = 0;
            this.btnbiletal.Text = "Bilet Al";
            this.btnbiletal.UseVisualStyleBackColor = true;
            this.btnbiletal.Click += new System.EventHandler(this.btnbiletal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 432);
            this.Controls.Add(this.btnbiletal);
            this.Controls.Add(this.btnfirma);
            this.Controls.Add(this.btnadmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Menüsü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnfirma;
        private System.Windows.Forms.Button btnbiletal;
    }
}

