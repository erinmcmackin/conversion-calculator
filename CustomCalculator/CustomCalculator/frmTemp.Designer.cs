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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // txtOrigTemp
            // 
            this.txtOrigTemp.Location = new System.Drawing.Point(460, 69);
            this.txtOrigTemp.Name = "txtOrigTemp";
            this.txtOrigTemp.Size = new System.Drawing.Size(124, 38);
            this.txtOrigTemp.TabIndex = 1;
            // 
            // radioCel1
            // 
            this.radioCel1.AutoSize = true;
            this.radioCel1.Location = new System.Drawing.Point(64, 48);
            this.radioCel1.Name = "radioCel1";
            this.radioCel1.Size = new System.Drawing.Size(146, 36);
            this.radioCel1.TabIndex = 0;
            this.radioCel1.TabStop = true;
            this.radioCel1.Text = "Celsius";
            this.radioCel1.UseVisualStyleBackColor = true;
            // 
            // radioFahr1
            // 
            this.radioFahr1.AutoSize = true;
            this.radioFahr1.Location = new System.Drawing.Point(253, 48);
            this.radioFahr1.Name = "radioFahr1";
            this.radioFahr1.Size = new System.Drawing.Size(189, 36);
            this.radioFahr1.TabIndex = 1;
            this.radioFahr1.Text = "Fahrenheit";
            this.radioFahr1.UseVisualStyleBackColor = true;
            // 
            // radioKel1
            // 
            this.radioKel1.AutoSize = true;
            this.radioKel1.Location = new System.Drawing.Point(474, 48);
            this.radioKel1.Name = "radioKel1";
            this.radioKel1.Size = new System.Drawing.Size(131, 36);
            this.radioKel1.TabIndex = 2;
            this.radioKel1.Text = "Kelvin";
            this.radioKel1.UseVisualStyleBackColor = true;
            // 
            // radioCel2
            // 
            this.radioCel2.AutoSize = true;
            this.radioCel2.Location = new System.Drawing.Point(64, 37);
            this.radioCel2.Name = "radioCel2";
            this.radioCel2.Size = new System.Drawing.Size(146, 36);
            this.radioCel2.TabIndex = 0;
            this.radioCel2.TabStop = true;
            this.radioCel2.Text = "Celsius";
            this.radioCel2.UseVisualStyleBackColor = true;
            // 
            // radioFahr2
            // 
            this.radioFahr2.AutoSize = true;
            this.radioFahr2.Location = new System.Drawing.Point(253, 37);
            this.radioFahr2.Name = "radioFahr2";
            this.radioFahr2.Size = new System.Drawing.Size(189, 36);
            this.radioFahr2.TabIndex = 1;
            this.radioFahr2.Text = "Fahrenheit";
            this.radioFahr2.UseVisualStyleBackColor = true;
            // 
            // radioKel2
            // 
            this.radioKel2.AutoSize = true;
            this.radioKel2.Location = new System.Drawing.Point(474, 37);
            this.radioKel2.Name = "radioKel2";
            this.radioKel2.Size = new System.Drawing.Size(131, 36);
            this.radioKel2.TabIndex = 2;
            this.radioKel2.Text = "Kelvin";
            this.radioKel2.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(75, 524);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(304, 71);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnMenuReturn
            // 
            this.btnMenuReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMenuReturn.Location = new System.Drawing.Point(419, 524);
            this.btnMenuReturn.Name = "btnMenuReturn";
            this.btnMenuReturn.Size = new System.Drawing.Size(308, 71);
            this.btnMenuReturn.TabIndex = 7;
            this.btnMenuReturn.Text = "Menu";
            this.btnMenuReturn.UseVisualStyleBackColor = true;
            this.btnMenuReturn.Click += new System.EventHandler(this.btnMenuReturn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "&Converted Temperature:";
            // 
            // txtConvTemp
            // 
            this.txtConvTemp.Location = new System.Drawing.Point(460, 422);
            this.txtConvTemp.Name = "txtConvTemp";
            this.txtConvTemp.ReadOnly = true;
            this.txtConvTemp.Size = new System.Drawing.Size(124, 38);
            this.txtConvTemp.TabIndex = 5;
            this.txtConvTemp.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioKel1);
            this.groupBox1.Controls.Add(this.radioFahr1);
            this.groupBox1.Controls.Add(this.radioCel1);
            this.groupBox1.Location = new System.Drawing.Point(66, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioCel2);
            this.groupBox2.Controls.Add(this.radioFahr2);
            this.groupBox2.Controls.Add(this.radioKel2);
            this.groupBox2.Location = new System.Drawing.Point(66, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 105);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To:";
            // 
            // frmTemp
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnMenuReturn;
            this.ClientSize = new System.Drawing.Size(805, 657);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtConvTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMenuReturn);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOrigTemp);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTemp";
            this.Text = "Temperature Conversion";
            this.Load += new System.EventHandler(this.frmTemp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigTemp;
        private System.Windows.Forms.RadioButton radioCel1;
        private System.Windows.Forms.RadioButton radioKel1;
        private System.Windows.Forms.RadioButton radioCel2;
        private System.Windows.Forms.RadioButton radioFahr2;
        private System.Windows.Forms.RadioButton radioKel2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnMenuReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConvTemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioFahr1;
    }
}