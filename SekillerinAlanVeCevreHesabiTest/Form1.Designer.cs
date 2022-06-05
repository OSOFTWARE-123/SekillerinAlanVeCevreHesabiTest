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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHesap = new System.Windows.Forms.Button();
            this.numValue1 = new System.Windows.Forms.NumericUpDown();
            this.numValue2 = new System.Windows.Forms.NumericUpDown();
            this.comboShape = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltTot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValue2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesap
            // 
            this.btnHesap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesap.Location = new System.Drawing.Point(163, 282);
            this.btnHesap.Margin = new System.Windows.Forms.Padding(6);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(223, 114);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // numValue1
            // 
            this.numValue1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numValue1.ForeColor = System.Drawing.Color.LimeGreen;
            this.numValue1.Location = new System.Drawing.Point(22, 228);
            this.numValue1.Margin = new System.Windows.Forms.Padding(6);
            this.numValue1.Name = "numValue1";
            this.numValue1.Size = new System.Drawing.Size(223, 36);
            this.numValue1.TabIndex = 1;
            // 
            // numValue2
            // 
            this.numValue2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numValue2.ForeColor = System.Drawing.Color.LimeGreen;
            this.numValue2.Location = new System.Drawing.Point(325, 228);
            this.numValue2.Margin = new System.Windows.Forms.Padding(6);
            this.numValue2.Name = "numValue2";
            this.numValue2.Size = new System.Drawing.Size(223, 36);
            this.numValue2.TabIndex = 1;
            // 
            // comboShape
            // 
            this.comboShape.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboShape.ForeColor = System.Drawing.Color.LimeGreen;
            this.comboShape.FormattingEnabled = true;
            this.comboShape.Location = new System.Drawing.Point(97, 50);
            this.comboShape.Margin = new System.Windows.Forms.Padding(6);
            this.comboShape.Name = "comboShape";
            this.comboShape.Size = new System.Drawing.Size(361, 36);
            this.comboShape.TabIndex = 2;
            this.comboShape.SelectedIndexChanged += new System.EventHandler(this.comboShape_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selected Shape : ";
            // 
            // comboProc
            // 
            this.comboProc.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboProc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProc.ForeColor = System.Drawing.Color.LimeGreen;
            this.comboProc.FormattingEnabled = true;
            this.comboProc.Location = new System.Drawing.Point(97, 131);
            this.comboProc.Margin = new System.Windows.Forms.Padding(6);
            this.comboProc.Name = "comboProc";
            this.comboProc.Size = new System.Drawing.Size(361, 36);
            this.comboProc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selected Process : ";
            // 
            // lbltTot
            // 
            this.lbltTot.AutoSize = true;
            this.lbltTot.Location = new System.Drawing.Point(4, 437);
            this.lbltTot.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbltTot.Name = "lbltTot";
            this.lbltTot.Size = new System.Drawing.Size(116, 28);
            this.lbltTot.TabIndex = 4;
            this.lbltTot.Text = "Total : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Height :  ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Taban Length : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(570, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltTot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProc);
            this.Controls.Add(this.comboShape);
            this.Controls.Add(this.numValue2);
            this.Controls.Add(this.numValue1);
            this.Controls.Add(this.btnHesap);
            this.Font = new System.Drawing.Font("Consolas", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(586, 513);
            this.MinimumSize = new System.Drawing.Size(586, 513);
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
        private Label label3;
        private Label label4;
    }
}