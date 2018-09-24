namespace CustomCalculator
{
    partial class frmMenu
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
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnLinear = new System.Windows.Forms.Button();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnWeight = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMenuTitle.Location = new System.Drawing.Point(113, 25);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(357, 40);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Conversion Calculator";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLinear
            // 
            this.btnLinear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLinear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLinear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinear.ForeColor = System.Drawing.Color.White;
            this.btnLinear.Location = new System.Drawing.Point(175, 100);
            this.btnLinear.Name = "btnLinear";
            this.btnLinear.Size = new System.Drawing.Size(250, 50);
            this.btnLinear.TabIndex = 1;
            this.btnLinear.Text = "&Linear Conversion";
            this.btnLinear.UseVisualStyleBackColor = false;
            this.btnLinear.Click += new System.EventHandler(this.btnLinear_Click);
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVolume.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolume.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.ForeColor = System.Drawing.Color.White;
            this.btnVolume.Location = new System.Drawing.Point(175, 156);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(250, 50);
            this.btnVolume.TabIndex = 2;
            this.btnVolume.Text = "&Volume Conversion";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnWeight
            // 
            this.btnWeight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWeight.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnWeight.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeight.ForeColor = System.Drawing.Color.White;
            this.btnWeight.Location = new System.Drawing.Point(175, 268);
            this.btnWeight.Name = "btnWeight";
            this.btnWeight.Size = new System.Drawing.Size(250, 50);
            this.btnWeight.TabIndex = 4;
            this.btnWeight.Text = "&Weight Conversion";
            this.btnWeight.UseVisualStyleBackColor = false;
            // 
            // btnTemp
            // 
            this.btnTemp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTemp.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTemp.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemp.ForeColor = System.Drawing.Color.White;
            this.btnTemp.Location = new System.Drawing.Point(175, 324);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(250, 50);
            this.btnTemp.TabIndex = 5;
            this.btnTemp.Text = "&Temperature Conversion";
            this.btnTemp.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(225, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(175, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Area/Vol Calculation";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnWeight);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnLinear);
            this.Controls.Add(this.lblMenuTitle);
            this.Name = "frmMenu";
            this.Text = "Conversion Calculator";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnLinear;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Button btnWeight;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}

