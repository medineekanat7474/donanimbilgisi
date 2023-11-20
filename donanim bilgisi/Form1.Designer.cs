namespace donanim_bilgisi
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
            this.lstTumparcalar = new System.Windows.Forms.ListBox();
            this.lstDisdonanim = new System.Windows.Forms.ListBox();
            this.lstİçdonanim = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÜM PARÇALAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "DIŞ DONANIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "İÇ DONANIM";
            // 
            // lstTumparcalar
            // 
            this.lstTumparcalar.FormattingEnabled = true;
            this.lstTumparcalar.ItemHeight = 18;
            this.lstTumparcalar.Items.AddRange(new object[] {
            "ram",
            "hoparlör",
            "anakart",
            "ekran kartı",
            "monitör",
            "CPU",
            "mikrofon",
            "hardisk",
            "klavye",
            "SSD"});
            this.lstTumparcalar.Location = new System.Drawing.Point(16, 55);
            this.lstTumparcalar.Name = "lstTumparcalar";
            this.lstTumparcalar.Size = new System.Drawing.Size(120, 184);
            this.lstTumparcalar.TabIndex = 3;
            // 
            // lstDisdonanim
            // 
            this.lstDisdonanim.FormattingEnabled = true;
            this.lstDisdonanim.ItemHeight = 18;
            this.lstDisdonanim.Location = new System.Drawing.Point(176, 55);
            this.lstDisdonanim.Name = "lstDisdonanim";
            this.lstDisdonanim.Size = new System.Drawing.Size(114, 184);
            this.lstDisdonanim.TabIndex = 4;
            // 
            // lstİçdonanim
            // 
            this.lstİçdonanim.FormattingEnabled = true;
            this.lstİçdonanim.ItemHeight = 18;
            this.lstİçdonanim.Location = new System.Drawing.Point(336, 55);
            this.lstİçdonanim.Name = "lstİçdonanim";
            this.lstİçdonanim.Size = new System.Drawing.Size(114, 184);
            this.lstİçdonanim.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstİçdonanim);
            this.Controls.Add(this.lstDisdonanim);
            this.Controls.Add(this.lstTumparcalar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstTumparcalar;
        private System.Windows.Forms.ListBox lstDisdonanim;
        private System.Windows.Forms.ListBox lstİçdonanim;
        private System.Windows.Forms.Button button1;
    }
}

