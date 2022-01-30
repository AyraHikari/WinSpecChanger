namespace WinSpecChanger
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.ManBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProcBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TempSave = new System.Windows.Forms.Button();
            this.PermSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PermSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ModelBox);
            this.groupBox1.Controls.Add(this.ManBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "System Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Permanent changes";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(94, 58);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(200, 23);
            this.ModelBox.TabIndex = 4;
            // 
            // ManBox
            // 
            this.ManBox.Location = new System.Drawing.Point(94, 26);
            this.ManBox.Name = "ManBox";
            this.ManBox.Size = new System.Drawing.Size(200, 23);
            this.ManBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manufacturer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TempSave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ProcBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hardware Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Temporary changes";
            // 
            // ProcBox
            // 
            this.ProcBox.Location = new System.Drawing.Point(94, 24);
            this.ProcBox.Name = "ProcBox";
            this.ProcBox.Size = new System.Drawing.Size(200, 23);
            this.ProcBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Processor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(285, 30);
            this.label6.TabIndex = 2;
            this.label6.Text = "This app is just for fun only. I don\'t responsibly if you\r\nused this for wrong wa" +
    "y! Also do with you own risk!";
            // 
            // TempSave
            // 
            this.TempSave.Location = new System.Drawing.Point(219, 71);
            this.TempSave.Name = "TempSave";
            this.TempSave.Size = new System.Drawing.Size(75, 23);
            this.TempSave.TabIndex = 3;
            this.TempSave.Text = "Save";
            this.TempSave.UseVisualStyleBackColor = true;
            this.TempSave.Click += new System.EventHandler(this.TempSave_Click);
            // 
            // PermSave
            // 
            this.PermSave.Location = new System.Drawing.Point(219, 120);
            this.PermSave.Name = "PermSave";
            this.PermSave.Size = new System.Drawing.Size(75, 23);
            this.PermSave.TabIndex = 6;
            this.PermSave.Text = "Save";
            this.PermSave.UseVisualStyleBackColor = true;
            this.PermSave.Click += new System.EventHandler(this.PermSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 321);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "WinSpecChanger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox ManBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProcBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PermSave;
        private System.Windows.Forms.Button TempSave;
    }
}
