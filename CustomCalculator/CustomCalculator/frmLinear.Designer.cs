namespace CustomCalculator
{
    partial class frmLinear
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
            this.components = new System.ComponentModel.Container();
            this.lblInch = new System.Windows.Forms.Label();
            this.lblFoot = new System.Windows.Forms.Label();
            this.lblYard = new System.Windows.Forms.Label();
            this.lblMile = new System.Windows.Forms.Label();
            this.lblImperial = new System.Windows.Forms.Label();
            this.lblCentiMeter = new System.Windows.Forms.Label();
            this.lblMeter = new System.Windows.Forms.Label();
            this.lblKiloMeter = new System.Windows.Forms.Label();
            this.lblMilliMeter = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtInch = new System.Windows.Forms.TextBox();
            this.txtFoot = new System.Windows.Forms.TextBox();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.txtMile = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMilliMeter = new System.Windows.Forms.TextBox();
            this.txtCentiMeter = new System.Windows.Forms.TextBox();
            this.txtMeter = new System.Windows.Forms.TextBox();
            this.txtKiloMeter = new System.Windows.Forms.TextBox();
            this.lblMetric = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtLinearValue = new System.Windows.Forms.TextBox();
            this.txtLinearUnit = new System.Windows.Forms.TextBox();
            this.ctxMenuUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ydToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblInputValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ctxMenuUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInch
            // 
            this.lblInch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInch.AutoSize = true;
            this.lblInch.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInch.ForeColor = System.Drawing.Color.White;
            this.lblInch.Location = new System.Drawing.Point(204, 10);
            this.lblInch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInch.Name = "lblInch";
            this.lblInch.Size = new System.Drawing.Size(21, 18);
            this.lblInch.TabIndex = 0;
            this.lblInch.Text = "in";
            // 
            // lblFoot
            // 
            this.lblFoot.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoot.AutoSize = true;
            this.lblFoot.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoot.ForeColor = System.Drawing.Color.White;
            this.lblFoot.Location = new System.Drawing.Point(204, 48);
            this.lblFoot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFoot.Name = "lblFoot";
            this.lblFoot.Size = new System.Drawing.Size(18, 18);
            this.lblFoot.TabIndex = 1;
            this.lblFoot.Text = "ft";
            // 
            // lblYard
            // 
            this.lblYard.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblYard.AutoSize = true;
            this.lblYard.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYard.ForeColor = System.Drawing.Color.White;
            this.lblYard.Location = new System.Drawing.Point(204, 86);
            this.lblYard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYard.Name = "lblYard";
            this.lblYard.Size = new System.Drawing.Size(25, 18);
            this.lblYard.TabIndex = 2;
            this.lblYard.Text = "yd";
            // 
            // lblMile
            // 
            this.lblMile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMile.AutoSize = true;
            this.lblMile.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMile.ForeColor = System.Drawing.Color.White;
            this.lblMile.Location = new System.Drawing.Point(204, 125);
            this.lblMile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMile.Name = "lblMile";
            this.lblMile.Size = new System.Drawing.Size(25, 18);
            this.lblMile.TabIndex = 3;
            this.lblMile.Text = "mi";
            // 
            // lblImperial
            // 
            this.lblImperial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImperial.AutoSize = true;
            this.lblImperial.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImperial.Location = new System.Drawing.Point(131, 154);
            this.lblImperial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImperial.Name = "lblImperial";
            this.lblImperial.Size = new System.Drawing.Size(142, 25);
            this.lblImperial.TabIndex = 4;
            this.lblImperial.Text = "Imperial Units";
            // 
            // lblCentiMeter
            // 
            this.lblCentiMeter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCentiMeter.AutoSize = true;
            this.lblCentiMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCentiMeter.ForeColor = System.Drawing.Color.White;
            this.lblCentiMeter.Location = new System.Drawing.Point(204, 48);
            this.lblCentiMeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCentiMeter.Name = "lblCentiMeter";
            this.lblCentiMeter.Size = new System.Drawing.Size(28, 18);
            this.lblCentiMeter.TabIndex = 5;
            this.lblCentiMeter.Text = "cm";
            // 
            // lblMeter
            // 
            this.lblMeter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMeter.AutoSize = true;
            this.lblMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter.ForeColor = System.Drawing.Color.White;
            this.lblMeter.Location = new System.Drawing.Point(204, 86);
            this.lblMeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeter.Name = "lblMeter";
            this.lblMeter.Size = new System.Drawing.Size(21, 18);
            this.lblMeter.TabIndex = 6;
            this.lblMeter.Text = "m";
            // 
            // lblKiloMeter
            // 
            this.lblKiloMeter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblKiloMeter.AutoSize = true;
            this.lblKiloMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKiloMeter.ForeColor = System.Drawing.Color.White;
            this.lblKiloMeter.Location = new System.Drawing.Point(204, 125);
            this.lblKiloMeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKiloMeter.Name = "lblKiloMeter";
            this.lblKiloMeter.Size = new System.Drawing.Size(29, 18);
            this.lblKiloMeter.TabIndex = 7;
            this.lblKiloMeter.Text = "km";
            // 
            // lblMilliMeter
            // 
            this.lblMilliMeter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMilliMeter.AutoSize = true;
            this.lblMilliMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilliMeter.ForeColor = System.Drawing.Color.White;
            this.lblMilliMeter.Location = new System.Drawing.Point(204, 10);
            this.lblMilliMeter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilliMeter.Name = "lblMilliMeter";
            this.lblMilliMeter.Size = new System.Drawing.Size(34, 18);
            this.lblMilliMeter.TabIndex = 8;
            this.lblMilliMeter.Text = "mm";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Controls.Add(this.lblInch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFoot, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblYard, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblMile, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtInch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFoot, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtYard, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtMile, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 185);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(267, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtInch
            // 
            this.txtInch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInch.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInch.Location = new System.Drawing.Point(4, 6);
            this.txtInch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInch.Name = "txtInch";
            this.txtInch.ReadOnly = true;
            this.txtInch.Size = new System.Drawing.Size(192, 26);
            this.txtInch.TabIndex = 0;
            this.txtInch.TabStop = false;
            // 
            // txtFoot
            // 
            this.txtFoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoot.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoot.Location = new System.Drawing.Point(4, 44);
            this.txtFoot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFoot.Name = "txtFoot";
            this.txtFoot.ReadOnly = true;
            this.txtFoot.Size = new System.Drawing.Size(192, 26);
            this.txtFoot.TabIndex = 0;
            this.txtFoot.TabStop = false;
            // 
            // txtYard
            // 
            this.txtYard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYard.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYard.Location = new System.Drawing.Point(4, 82);
            this.txtYard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYard.Name = "txtYard";
            this.txtYard.ReadOnly = true;
            this.txtYard.Size = new System.Drawing.Size(192, 26);
            this.txtYard.TabIndex = 0;
            this.txtYard.TabStop = false;
            // 
            // txtMile
            // 
            this.txtMile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMile.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMile.Location = new System.Drawing.Point(4, 121);
            this.txtMile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMile.Name = "txtMile";
            this.txtMile.ReadOnly = true;
            this.txtMile.Size = new System.Drawing.Size(192, 26);
            this.txtMile.TabIndex = 0;
            this.txtMile.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.lblMilliMeter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCentiMeter, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblKiloMeter, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblMeter, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtMilliMeter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCentiMeter, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMeter, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtKiloMeter, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(420, 185);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 154);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtMilliMeter
            // 
            this.txtMilliMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMilliMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilliMeter.Location = new System.Drawing.Point(4, 6);
            this.txtMilliMeter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMilliMeter.Name = "txtMilliMeter";
            this.txtMilliMeter.ReadOnly = true;
            this.txtMilliMeter.Size = new System.Drawing.Size(192, 26);
            this.txtMilliMeter.TabIndex = 0;
            this.txtMilliMeter.TabStop = false;
            // 
            // txtCentiMeter
            // 
            this.txtCentiMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCentiMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentiMeter.Location = new System.Drawing.Point(4, 44);
            this.txtCentiMeter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCentiMeter.Name = "txtCentiMeter";
            this.txtCentiMeter.ReadOnly = true;
            this.txtCentiMeter.Size = new System.Drawing.Size(192, 26);
            this.txtCentiMeter.TabIndex = 0;
            this.txtCentiMeter.TabStop = false;
            // 
            // txtMeter
            // 
            this.txtMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeter.Location = new System.Drawing.Point(4, 82);
            this.txtMeter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMeter.Name = "txtMeter";
            this.txtMeter.ReadOnly = true;
            this.txtMeter.Size = new System.Drawing.Size(192, 26);
            this.txtMeter.TabIndex = 0;
            this.txtMeter.TabStop = false;
            // 
            // txtKiloMeter
            // 
            this.txtKiloMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKiloMeter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKiloMeter.Location = new System.Drawing.Point(4, 121);
            this.txtKiloMeter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKiloMeter.Name = "txtKiloMeter";
            this.txtKiloMeter.ReadOnly = true;
            this.txtKiloMeter.Size = new System.Drawing.Size(192, 26);
            this.txtKiloMeter.TabIndex = 0;
            this.txtKiloMeter.TabStop = false;
            // 
            // lblMetric
            // 
            this.lblMetric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMetric.AutoSize = true;
            this.lblMetric.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric.Location = new System.Drawing.Point(483, 154);
            this.lblMetric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric.Name = "lblMetric";
            this.lblMetric.Size = new System.Drawing.Size(124, 25);
            this.lblMetric.TabIndex = 11;
            this.lblMetric.Text = "Metric Units";
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(220, 369);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(333, 37);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "&Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtLinearValue
            // 
            this.txtLinearValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLinearValue.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinearValue.Location = new System.Drawing.Point(213, 74);
            this.txtLinearValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLinearValue.Name = "txtLinearValue";
            this.txtLinearValue.Size = new System.Drawing.Size(165, 26);
            this.txtLinearValue.TabIndex = 1;
            // 
            // txtLinearUnit
            // 
            this.txtLinearUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLinearUnit.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinearUnit.Location = new System.Drawing.Point(387, 74);
            this.txtLinearUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLinearUnit.Name = "txtLinearUnit";
            this.txtLinearUnit.ReadOnly = true;
            this.txtLinearUnit.Size = new System.Drawing.Size(165, 26);
            this.txtLinearUnit.TabIndex = 0;
            this.txtLinearUnit.TabStop = false;
            this.txtLinearUnit.Text = "(inches)";
            this.txtLinearUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctxMenuUnits
            // 
            this.ctxMenuUnits.BackColor = System.Drawing.Color.White;
            this.ctxMenuUnits.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inToolStripMenuItem,
            this.ftToolStripMenuItem,
            this.ydToolStripMenuItem,
            this.miToolStripMenuItem,
            this.mmToolStripMenuItem,
            this.cmToolStripMenuItem,
            this.meterToolStripMenuItem,
            this.kmToolStripMenuItem});
            this.ctxMenuUnits.Name = "ctxMenuUnits";
            this.ctxMenuUnits.Size = new System.Drawing.Size(105, 196);
            // 
            // inToolStripMenuItem
            // 
            this.inToolStripMenuItem.Name = "inToolStripMenuItem";
            this.inToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.inToolStripMenuItem.Text = "in";
            this.inToolStripMenuItem.Click += new System.EventHandler(this.inToolStripMenuItem_Click);
            // 
            // ftToolStripMenuItem
            // 
            this.ftToolStripMenuItem.Name = "ftToolStripMenuItem";
            this.ftToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ftToolStripMenuItem.Text = "ft";
            this.ftToolStripMenuItem.Click += new System.EventHandler(this.ftToolStripMenuItem_Click);
            // 
            // ydToolStripMenuItem
            // 
            this.ydToolStripMenuItem.Name = "ydToolStripMenuItem";
            this.ydToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.ydToolStripMenuItem.Text = "yd";
            this.ydToolStripMenuItem.Click += new System.EventHandler(this.ydToolStripMenuItem_Click);
            // 
            // miToolStripMenuItem
            // 
            this.miToolStripMenuItem.Name = "miToolStripMenuItem";
            this.miToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.miToolStripMenuItem.Text = "mi";
            this.miToolStripMenuItem.Click += new System.EventHandler(this.miToolStripMenuItem_Click);
            // 
            // mmToolStripMenuItem
            // 
            this.mmToolStripMenuItem.Name = "mmToolStripMenuItem";
            this.mmToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.mmToolStripMenuItem.Text = "mm";
            this.mmToolStripMenuItem.Click += new System.EventHandler(this.mmToolStripMenuItem_Click);
            // 
            // cmToolStripMenuItem
            // 
            this.cmToolStripMenuItem.Name = "cmToolStripMenuItem";
            this.cmToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.cmToolStripMenuItem.Text = "cm";
            this.cmToolStripMenuItem.Click += new System.EventHandler(this.cmToolStripMenuItem_Click);
            // 
            // meterToolStripMenuItem
            // 
            this.meterToolStripMenuItem.Name = "meterToolStripMenuItem";
            this.meterToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.meterToolStripMenuItem.Text = "m";
            this.meterToolStripMenuItem.Click += new System.EventHandler(this.meterToolStripMenuItem_Click);
            // 
            // kmToolStripMenuItem
            // 
            this.kmToolStripMenuItem.Name = "kmToolStripMenuItem";
            this.kmToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.kmToolStripMenuItem.Text = "km";
            this.kmToolStripMenuItem.Click += new System.EventHandler(this.kmToolStripMenuItem_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUnit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Location = new System.Drawing.Point(387, 105);
            this.btnUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(167, 31);
            this.btnUnit.TabIndex = 16;
            this.btnUnit.Text = "&Select Units";
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConvert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(213, 105);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(167, 31);
            this.btnConvert.TabIndex = 17;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblInputValue
            // 
            this.lblInputValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInputValue.AutoSize = true;
            this.lblInputValue.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputValue.Location = new System.Drawing.Point(153, 80);
            this.lblInputValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputValue.Name = "lblInputValue";
            this.lblInputValue.Size = new System.Drawing.Size(49, 18);
            this.lblInputValue.TabIndex = 18;
            this.lblInputValue.Text = "Value:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 50);
            this.label1.TabIndex = 19;
            this.label1.Text = "Linear Unit Converter";
            // 
            // frmLinear
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInputValue);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnUnit);
            this.Controls.Add(this.txtLinearUnit);
            this.Controls.Add(this.txtLinearValue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblMetric);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblImperial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLinear";
            this.Text = "Linear Unit Converter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ctxMenuUnits.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInch;
        private System.Windows.Forms.Label lblFoot;
        private System.Windows.Forms.Label lblYard;
        private System.Windows.Forms.Label lblMile;
        private System.Windows.Forms.Label lblImperial;
        private System.Windows.Forms.Label lblCentiMeter;
        private System.Windows.Forms.Label lblMeter;
        private System.Windows.Forms.Label lblKiloMeter;
        private System.Windows.Forms.Label lblMilliMeter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtInch;
        private System.Windows.Forms.TextBox txtFoot;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.TextBox txtMile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtMilliMeter;
        private System.Windows.Forms.TextBox txtCentiMeter;
        private System.Windows.Forms.TextBox txtMeter;
        private System.Windows.Forms.TextBox txtKiloMeter;
        private System.Windows.Forms.Label lblMetric;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtLinearValue;
        private System.Windows.Forms.TextBox txtLinearUnit;
        private System.Windows.Forms.ContextMenuStrip ctxMenuUnits;
        private System.Windows.Forms.ToolStripMenuItem inToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ydToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kmToolStripMenuItem;
        private System.Windows.Forms.Button btnUnit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblInputValue;
        private System.Windows.Forms.Label label1;
    }
}