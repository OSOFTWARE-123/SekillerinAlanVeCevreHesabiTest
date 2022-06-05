namespace SekillerinAlanVeCevreHesabiTest
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
            this.btnHesap = new System.Windows.Forms.Button();
            this.numValue1 = new System.Windows.Forms.NumericUpDown();
            this.numValue2 = new System.Windows.Forms.NumericUpDown();
            this.comboShape = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltTot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(88, 137);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(120, 61);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // numValue1
            // 
            this.numValue1.Location = new System.Drawing.Point(12, 108);
            this.numValue1.Name = "numValue1";
            this.numValue1.Size = new System.Drawing.Size(120, 23);
            this.numValue1.TabIndex = 1;
            // 
            // numValue2
            // 
            this.numValue2.Location = new System.Drawing.Point(175, 108);
            this.numValue2.Name = "numValue2";
            this.numValue2.Size = new System.Drawing.Size(120, 23);
            this.numValue2.TabIndex = 1;
            // 
            // comboShape
            // 
            this.comboShape.FormattingEnabled = true;
            this.comboShape.Location = new System.Drawing.Point(52, 27);
            this.comboShape.Name = "comboShape";
            this.comboShape.Size = new System.Drawing.Size(196, 23);
            this.comboShape.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected Shape : ";
            // 
            // comboProc
            // 
            this.comboProc.FormattingEnabled = true;
            this.comboProc.Location = new System.Drawing.Point(52, 70);
            this.comboProc.Name = "comboProc";
            this.comboProc.Size = new System.Drawing.Size(196, 23);
            this.comboProc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Process : ";
            // 
            // lbltTot
            // 
            this.lbltTot.AutoSize = true;
            this.lbltTot.Location = new System.Drawing.Point(88, 216);
            this.lbltTot.Name = "lbltTot";
            this.lbltTot.Size = new System.Drawing.Size(41, 15);
            this.lbltTot.TabIndex = 4;
            this.lbltTot.Text = "Total : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 254);
            this.Controls.Add(this.lbltTot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProc);
            this.Controls.Add(this.comboShape);
            this.Controls.Add(this.numValue2);
            this.Controls.Add(this.numValue1);
            this.Controls.Add(this.btnHesap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnHesap;
        private NumericUpDown numValue1;
        private NumericUpDown value1;
        private NumericUpDown numValue2;
        private ComboBox comboShape;
        private Label label1;
        private ComboBox comboProc;
        private Label label2;
        private Label lbltTot;
    }
}