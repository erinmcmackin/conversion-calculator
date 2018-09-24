namespace CustomCalculator
{
    partial class frmTemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemp));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrigTemp = new System.Windows.Forms.TextBox();
            this.radioCel1 = new System.Windows.Forms.RadioButton();
            this.radioFahr1 = new System.Windows.Forms.RadioButton();
            this.radioKel1 = new System.Windows.Forms.RadioButton();
            this.radioCel2 = new System.Windows.Forms.RadioButton();
            this.radioFahr2 = new System.Windows.Forms.RadioButton();
            this.radioKel2 = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnMenuReturn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConvTemp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Original Temperature:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "&From:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "To:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtOrigTemp
            // 
            this.txtOrigTemp.Location = new System.Drawing.Point(460, 69);
            this.txtOrigTemp.Name = "txtOrigTemp";
            this.txtOrigTemp.Size = new System.Drawing.Size(124, 38);
            this.txtOrigTemp.TabIndex = 1;
            this.txtOrigTemp.TabStop = false;
            // 
            // radioCel1
            // 
            this.radioCel1.AutoSize = true;
            this.radioCel1.Location = new System.Drawing.Point(177, 167);
            this.radioCel1.Name = "radioCel1";
            this.radioCel1.Size = new System.Drawing.Size(146, 36);
            this.radioCel1.TabIndex = 2;
            this.radioCel1.Text = "Celsius";
            this.radioCel1.UseVisualStyleBackColor = true;
            // 
            // radioFahr1
            // 
            this.radioFahr1.AutoSize = true;
            this.radioFahr1.Location = new System.Drawing.Point(361, 167);
            this.radioFahr1.Name = "radioFahr1";
            this.radioFahr1.Size = new System.Drawing.Size(189, 36);
            this.radioFahr1.TabIndex = 3;
            this.radioFahr1.Text = "Fahrenheit";
            this.radioFahr1.UseVisualStyleBackColor = true;
            // 
            // radioKel1
            // 
            this.radioKel1.AutoSize = true;
            this.radioKel1.Location = new System.Drawing.Point(586, 167);
            this.radioKel1.Name = "radioKel1";
            this.radioKel1.Size = new System.Drawing.Size(131, 36);
            this.radioKel1.TabIndex = 4;
            this.radioKel1.Text = "Kelvin";
            this.radioKel1.UseVisualStyleBackColor = true;
            // 
            // radioCel2
            // 
            this.radioCel2.AutoSize = true;
            this.radioCel2.Location = new System.Drawing.Point(177, 227);
            this.radioCel2.Name = "radioCel2";
            this.radioCel2.Size = new System.Drawing.Size(146, 36);
            this.radioCel2.TabIndex = 5;
            this.radioCel2.Text = "Celsius";
            this.radioCel2.UseVisualStyleBackColor = true;
            // 
            // radioFahr2
            // 
            this.radioFahr2.AutoSize = true;
            this.radioFahr2.Location = new System.Drawing.Point(361, 227);
            this.radioFahr2.Name = "radioFahr2";
            this.radioFahr2.Size = new System.Drawing.Size(189, 36);
            this.radioFahr2.TabIndex = 6;
            this.radioFahr2.Text = "Fahrenheit";
            this.radioFahr2.UseVisualStyleBackColor = true;
            // 
            // radioKel2
            // 
            this.radioKel2.AutoSize = true;
            this.radioKel2.Location = new System.Drawing.Point(586, 227);
            this.radioKel2.Name = "radioKel2";
            this.radioKel2.Size = new System.Drawing.Size(131, 36);
            this.radioKel2.TabIndex = 7;
            this.radioKel2.Text = "Kelvin";
            this.radioKel2.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(75, 424);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(304, 71);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.TabStop = false;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnMenuReturn
            // 
            this.btnMenuReturn.Location = new System.Drawing.Point(419, 424);
            this.btnMenuReturn.Name = "btnMenuReturn";
            this.btnMenuReturn.Size = new System.Drawing.Size(308, 71);
            this.btnMenuReturn.TabIndex = 10;
            this.btnMenuReturn.Text = "Menu";
            this.btnMenuReturn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "&Converted Temperature:";
            // 
            // txtConvTemp
            // 
            this.txtConvTemp.Location = new System.Drawing.Point(460, 322);
            this.txtConvTemp.Name = "txtConvTemp";
            this.txtConvTemp.ReadOnly = true;
            this.txtConvTemp.Size = new System.Drawing.Size(124, 38);
            this.txtConvTemp.TabIndex = 8;
            this.txtConvTemp.TabStop = false;
            // 
            // frmTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 558);
            this.Controls.Add(this.txtConvTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenuReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radioKel2);
            this.Controls.Add(this.radioFahr2);
            this.Controls.Add(this.radioCel2);
            this.Controls.Add(this.radioKel1);
            this.Controls.Add(this.radioFahr1);
            this.Controls.Add(this.radioCel1);
            this.Controls.Add(this.txtOrigTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTemp";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.frmTemp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrigTemp;
        private System.Windows.Forms.RadioButton radioCel1;
        private System.Windows.Forms.RadioButton radioFahr1;
        private System.Windows.Forms.RadioButton radioKel1;
        private System.Windows.Forms.RadioButton radioCel2;
        private System.Windows.Forms.RadioButton radioFahr2;
        private System.Windows.Forms.RadioButton radioKel2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnMenuReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConvTemp;
    }
}