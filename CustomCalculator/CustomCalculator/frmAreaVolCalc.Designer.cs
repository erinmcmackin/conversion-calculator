namespace CustomCalculator
{
    partial class frmAreaVolCalc
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
            this.lblAreaVolCalc = new System.Windows.Forms.Label();
            this.rdArea = new System.Windows.Forms.RadioButton();
            this.rdVolume = new System.Windows.Forms.RadioButton();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClearInputs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAreaVolCalc
            // 
            this.lblAreaVolCalc.AutoSize = true;
            this.lblAreaVolCalc.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaVolCalc.Location = new System.Drawing.Point(12, 51);
            this.lblAreaVolCalc.Name = "lblAreaVolCalc";
            this.lblAreaVolCalc.Size = new System.Drawing.Size(466, 40);
            this.lblAreaVolCalc.TabIndex = 0;
            this.lblAreaVolCalc.Text = "Area and Volume Calculations";
            // 
            // rdArea
            // 
            this.rdArea.AutoSize = true;
            this.rdArea.Checked = true;
            this.rdArea.Location = new System.Drawing.Point(11, 19);
            this.rdArea.Name = "rdArea";
            this.rdArea.Size = new System.Drawing.Size(47, 17);
            this.rdArea.TabIndex = 1;
            this.rdArea.TabStop = true;
            this.rdArea.Text = "Area";
            this.rdArea.UseVisualStyleBackColor = true;
            this.rdArea.CheckedChanged += new System.EventHandler(this.rdArea_CheckedChanged);
            // 
            // rdVolume
            // 
            this.rdVolume.AutoSize = true;
            this.rdVolume.Location = new System.Drawing.Point(11, 47);
            this.rdVolume.Name = "rdVolume";
            this.rdVolume.Size = new System.Drawing.Size(60, 17);
            this.rdVolume.TabIndex = 2;
            this.rdVolume.Text = "Volume";
            this.rdVolume.UseVisualStyleBackColor = true;
            this.rdVolume.CheckedChanged += new System.EventHandler(this.rdVolume_CheckedChanged);
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(123, 181);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 3;
            this.txtLength.Text = "0";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(57, 184);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(61, 13);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Length ( ft):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width ( ft):";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(57, 236);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(62, 13);
            this.lblHeight.TabIndex = 6;
            this.lblHeight.Text = "Height ( ft): ";
            this.lblHeight.Visible = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(123, 207);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 4;
            this.txtWidth.Text = "0";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(123, 233);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.ReadOnly = true;
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 5;
            this.txtHeight.Text = "0";
            this.txtHeight.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(285, 181);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TabStop = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(245, 184);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(34, 13);
            this.lblArea.TabIndex = 10;
            this.lblArea.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(60, 275);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(163, 35);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(97, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(262, 36);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Return To Main Menu";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClearInputs
            // 
            this.btnClearInputs.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClearInputs.ForeColor = System.Drawing.Color.White;
            this.btnClearInputs.Location = new System.Drawing.Point(229, 275);
            this.btnClearInputs.Name = "btnClearInputs";
            this.btnClearInputs.Size = new System.Drawing.Size(163, 35);
            this.btnClearInputs.TabIndex = 7;
            this.btnClearInputs.Text = "C&lear";
            this.btnClearInputs.UseVisualStyleBackColor = false;
            this.btnClearInputs.Click += new System.EventHandler(this.btnClearInputs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.rdVolume);
            this.groupBox1.Controls.Add(this.rdArea);
            this.groupBox1.Location = new System.Drawing.Point(60, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 70);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Calculation Type";
            // 
            // frmAreaVolCalc
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(486, 409);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClearInputs);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblAreaVolCalc);
            this.Name = "frmAreaVolCalc";
            this.Text = "Area & Volume Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAreaVolCalc;
        private System.Windows.Forms.RadioButton rdArea;
        private System.Windows.Forms.RadioButton rdVolume;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClearInputs;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}