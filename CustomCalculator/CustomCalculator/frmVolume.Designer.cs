namespace CustomCalculator
{
    partial class frmVolume
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
            this.lblVolumeTitle = new System.Windows.Forms.Label();
            this.lblInputValue = new System.Windows.Forms.Label();
            this.btnVolumeConvert = new System.Windows.Forms.Button();
            this.btnSelectVolumeUnits = new System.Windows.Forms.Button();
            this.txtVolumeUnit = new System.Windows.Forms.TextBox();
            this.txtVolumeValue = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblMetric = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMilliLiter = new System.Windows.Forms.Label();
            this.lblLiter = new System.Windows.Forms.Label();
            this.txtMilliLiter = new System.Windows.Forms.TextBox();
            this.txtLiter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFluidOunce = new System.Windows.Forms.Label();
            this.lblCup = new System.Windows.Forms.Label();
            this.lblPint = new System.Windows.Forms.Label();
            this.lblQuart = new System.Windows.Forms.Label();
            this.txtFluidOunce = new System.Windows.Forms.TextBox();
            this.txtCup = new System.Windows.Forms.TextBox();
            this.txtPint = new System.Windows.Forms.TextBox();
            this.txtQuart = new System.Windows.Forms.TextBox();
            this.lblImperial = new System.Windows.Forms.Label();
            this.lblGallon = new System.Windows.Forms.Label();
            this.txtGallon = new System.Windows.Forms.TextBox();
            this.ctxMenuVolumeUnits = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flOzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.galToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ctxMenuVolumeUnits.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVolumeTitle
            // 
            this.lblVolumeTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblVolumeTitle.AutoSize = true;
            this.lblVolumeTitle.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolumeTitle.Location = new System.Drawing.Point(180, 28);
            this.lblVolumeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolumeTitle.Name = "lblVolumeTitle";
            this.lblVolumeTitle.Size = new System.Drawing.Size(455, 50);
            this.lblVolumeTitle.TabIndex = 0;
            this.lblVolumeTitle.Text = "Volume Unit Converter";
            // 
            // lblInputValue
            // 
            this.lblInputValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblInputValue.AutoSize = true;
            this.lblInputValue.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputValue.Location = new System.Drawing.Point(166, 96);
            this.lblInputValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputValue.Name = "lblInputValue";
            this.lblInputValue.Size = new System.Drawing.Size(49, 18);
            this.lblInputValue.TabIndex = 29;
            this.lblInputValue.Text = "Value:";
            // 
            // btnVolumeConvert
            // 
            this.btnVolumeConvert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnVolumeConvert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVolumeConvert.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolumeConvert.ForeColor = System.Drawing.Color.White;
            this.btnVolumeConvert.Location = new System.Drawing.Point(226, 121);
            this.btnVolumeConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolumeConvert.Name = "btnVolumeConvert";
            this.btnVolumeConvert.Size = new System.Drawing.Size(167, 31);
            this.btnVolumeConvert.TabIndex = 2;
            this.btnVolumeConvert.Text = "&Convert";
            this.btnVolumeConvert.UseVisualStyleBackColor = false;
            this.btnVolumeConvert.Click += new System.EventHandler(this.btnVolumeConvert_Click);
            // 
            // btnSelectVolumeUnits
            // 
            this.btnSelectVolumeUnits.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectVolumeUnits.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSelectVolumeUnits.ForeColor = System.Drawing.Color.White;
            this.btnSelectVolumeUnits.Location = new System.Drawing.Point(400, 121);
            this.btnSelectVolumeUnits.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectVolumeUnits.Name = "btnSelectVolumeUnits";
            this.btnSelectVolumeUnits.Size = new System.Drawing.Size(167, 31);
            this.btnSelectVolumeUnits.TabIndex = 3;
            this.btnSelectVolumeUnits.Text = "&Select Units";
            this.btnSelectVolumeUnits.UseVisualStyleBackColor = false;
            this.btnSelectVolumeUnits.Click += new System.EventHandler(this.btnSelectVolumeUnits_Click);
            // 
            // txtVolumeUnit
            // 
            this.txtVolumeUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVolumeUnit.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumeUnit.Location = new System.Drawing.Point(400, 90);
            this.txtVolumeUnit.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolumeUnit.Name = "txtVolumeUnit";
            this.txtVolumeUnit.ReadOnly = true;
            this.txtVolumeUnit.Size = new System.Drawing.Size(165, 26);
            this.txtVolumeUnit.TabIndex = 0;
            this.txtVolumeUnit.TabStop = false;
            this.txtVolumeUnit.Text = "(fluid ounces)";
            this.txtVolumeUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVolumeValue
            // 
            this.txtVolumeValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVolumeValue.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolumeValue.Location = new System.Drawing.Point(226, 90);
            this.txtVolumeValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolumeValue.Name = "txtVolumeValue";
            this.txtVolumeValue.Size = new System.Drawing.Size(165, 26);
            this.txtVolumeValue.TabIndex = 1;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(233, 385);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(333, 37);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "&Return to Main Menu";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblMetric
            // 
            this.lblMetric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMetric.AutoSize = true;
            this.lblMetric.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric.Location = new System.Drawing.Point(496, 170);
            this.lblMetric.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMetric.Name = "lblMetric";
            this.lblMetric.Size = new System.Drawing.Size(124, 25);
            this.lblMetric.TabIndex = 0;
            this.lblMetric.Text = "Metric Units";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Controls.Add(this.lblMilliLiter, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLiter, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtMilliLiter, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLiter, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(433, 201);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(250, 70);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // lblMilliLiter
            // 
            this.lblMilliLiter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMilliLiter.AutoSize = true;
            this.lblMilliLiter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilliLiter.ForeColor = System.Drawing.Color.White;
            this.lblMilliLiter.Location = new System.Drawing.Point(187, 8);
            this.lblMilliLiter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMilliLiter.Name = "lblMilliLiter";
            this.lblMilliLiter.Size = new System.Drawing.Size(28, 18);
            this.lblMilliLiter.TabIndex = 8;
            this.lblMilliLiter.Text = "mL";
            // 
            // lblLiter
            // 
            this.lblLiter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLiter.AutoSize = true;
            this.lblLiter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiter.ForeColor = System.Drawing.Color.White;
            this.lblLiter.Location = new System.Drawing.Point(187, 43);
            this.lblLiter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiter.Name = "lblLiter";
            this.lblLiter.Size = new System.Drawing.Size(15, 18);
            this.lblLiter.TabIndex = 6;
            this.lblLiter.Text = "L";
            // 
            // txtMilliLiter
            // 
            this.txtMilliLiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMilliLiter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMilliLiter.Location = new System.Drawing.Point(4, 4);
            this.txtMilliLiter.Margin = new System.Windows.Forms.Padding(4);
            this.txtMilliLiter.Name = "txtMilliLiter";
            this.txtMilliLiter.ReadOnly = true;
            this.txtMilliLiter.Size = new System.Drawing.Size(175, 26);
            this.txtMilliLiter.TabIndex = 0;
            this.txtMilliLiter.TabStop = false;
            // 
            // txtLiter
            // 
            this.txtLiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLiter.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLiter.Location = new System.Drawing.Point(4, 39);
            this.txtLiter.Margin = new System.Windows.Forms.Padding(4);
            this.txtLiter.Name = "txtLiter";
            this.txtLiter.ReadOnly = true;
            this.txtLiter.Size = new System.Drawing.Size(175, 26);
            this.txtLiter.TabIndex = 0;
            this.txtLiter.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.Controls.Add(this.txtGallon, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFluidOunce, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCup, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPint, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuart, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFluidOunce, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCup, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPint, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQuart, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGallon, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 201);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 175);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // lblFluidOunce
            // 
            this.lblFluidOunce.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFluidOunce.AutoSize = true;
            this.lblFluidOunce.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFluidOunce.ForeColor = System.Drawing.Color.White;
            this.lblFluidOunce.Location = new System.Drawing.Point(187, 8);
            this.lblFluidOunce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFluidOunce.Name = "lblFluidOunce";
            this.lblFluidOunce.Size = new System.Drawing.Size(37, 18);
            this.lblFluidOunce.TabIndex = 0;
            this.lblFluidOunce.Text = "fl oz";
            // 
            // lblCup
            // 
            this.lblCup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCup.AutoSize = true;
            this.lblCup.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCup.ForeColor = System.Drawing.Color.White;
            this.lblCup.Location = new System.Drawing.Point(187, 43);
            this.lblCup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCup.Name = "lblCup";
            this.lblCup.Size = new System.Drawing.Size(15, 18);
            this.lblCup.TabIndex = 1;
            this.lblCup.Text = "c";
            // 
            // lblPint
            // 
            this.lblPint.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPint.AutoSize = true;
            this.lblPint.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPint.ForeColor = System.Drawing.Color.White;
            this.lblPint.Location = new System.Drawing.Point(187, 78);
            this.lblPint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPint.Name = "lblPint";
            this.lblPint.Size = new System.Drawing.Size(22, 18);
            this.lblPint.TabIndex = 0;
            this.lblPint.Text = "pt";
            // 
            // lblQuart
            // 
            this.lblQuart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuart.AutoSize = true;
            this.lblQuart.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuart.ForeColor = System.Drawing.Color.White;
            this.lblQuart.Location = new System.Drawing.Point(187, 113);
            this.lblQuart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuart.Name = "lblQuart";
            this.lblQuart.Size = new System.Drawing.Size(22, 18);
            this.lblQuart.TabIndex = 3;
            this.lblQuart.Text = "qt";
            // 
            // txtFluidOunce
            // 
            this.txtFluidOunce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFluidOunce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFluidOunce.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFluidOunce.Location = new System.Drawing.Point(4, 4);
            this.txtFluidOunce.Margin = new System.Windows.Forms.Padding(4);
            this.txtFluidOunce.Name = "txtFluidOunce";
            this.txtFluidOunce.ReadOnly = true;
            this.txtFluidOunce.Size = new System.Drawing.Size(175, 26);
            this.txtFluidOunce.TabIndex = 0;
            this.txtFluidOunce.TabStop = false;
            // 
            // txtCup
            // 
            this.txtCup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCup.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCup.Location = new System.Drawing.Point(4, 39);
            this.txtCup.Margin = new System.Windows.Forms.Padding(4);
            this.txtCup.Name = "txtCup";
            this.txtCup.ReadOnly = true;
            this.txtCup.Size = new System.Drawing.Size(175, 26);
            this.txtCup.TabIndex = 0;
            this.txtCup.TabStop = false;
            // 
            // txtPint
            // 
            this.txtPint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPint.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPint.Location = new System.Drawing.Point(4, 74);
            this.txtPint.Margin = new System.Windows.Forms.Padding(4);
            this.txtPint.Name = "txtPint";
            this.txtPint.ReadOnly = true;
            this.txtPint.Size = new System.Drawing.Size(175, 26);
            this.txtPint.TabIndex = 0;
            this.txtPint.TabStop = false;
            // 
            // txtQuart
            // 
            this.txtQuart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuart.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuart.Location = new System.Drawing.Point(4, 109);
            this.txtQuart.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuart.Name = "txtQuart";
            this.txtQuart.ReadOnly = true;
            this.txtQuart.Size = new System.Drawing.Size(175, 26);
            this.txtQuart.TabIndex = 0;
            this.txtQuart.TabStop = false;
            // 
            // lblImperial
            // 
            this.lblImperial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImperial.AutoSize = true;
            this.lblImperial.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImperial.Location = new System.Drawing.Point(144, 170);
            this.lblImperial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImperial.Name = "lblImperial";
            this.lblImperial.Size = new System.Drawing.Size(142, 25);
            this.lblImperial.TabIndex = 0;
            this.lblImperial.Text = "Imperial Units";
            // 
            // lblGallon
            // 
            this.lblGallon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGallon.AutoSize = true;
            this.lblGallon.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGallon.ForeColor = System.Drawing.Color.White;
            this.lblGallon.Location = new System.Drawing.Point(186, 148);
            this.lblGallon.Name = "lblGallon";
            this.lblGallon.Size = new System.Drawing.Size(29, 18);
            this.lblGallon.TabIndex = 4;
            this.lblGallon.Text = "gal";
            // 
            // txtGallon
            // 
            this.txtGallon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGallon.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGallon.Location = new System.Drawing.Point(4, 144);
            this.txtGallon.Margin = new System.Windows.Forms.Padding(4);
            this.txtGallon.Name = "txtGallon";
            this.txtGallon.ReadOnly = true;
            this.txtGallon.Size = new System.Drawing.Size(175, 26);
            this.txtGallon.TabIndex = 0;
            this.txtGallon.TabStop = false;
            // 
            // ctxMenuVolumeUnits
            // 
            this.ctxMenuVolumeUnits.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenuVolumeUnits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flOzToolStripMenuItem,
            this.cToolStripMenuItem,
            this.ptToolStripMenuItem,
            this.qtToolStripMenuItem,
            this.galToolStripMenuItem,
            this.mLToolStripMenuItem,
            this.lToolStripMenuItem});
            this.ctxMenuVolumeUnits.Name = "ctxMenuVolumeUnits";
            this.ctxMenuVolumeUnits.Size = new System.Drawing.Size(108, 172);
            // 
            // flOzToolStripMenuItem
            // 
            this.flOzToolStripMenuItem.Name = "flOzToolStripMenuItem";
            this.flOzToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.flOzToolStripMenuItem.Text = "fl oz";
            this.flOzToolStripMenuItem.Click += new System.EventHandler(this.flOzToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cToolStripMenuItem.Text = "c";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // ptToolStripMenuItem
            // 
            this.ptToolStripMenuItem.Name = "ptToolStripMenuItem";
            this.ptToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.ptToolStripMenuItem.Text = "pt";
            this.ptToolStripMenuItem.Click += new System.EventHandler(this.ptToolStripMenuItem_Click);
            // 
            // qtToolStripMenuItem
            // 
            this.qtToolStripMenuItem.Name = "qtToolStripMenuItem";
            this.qtToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.qtToolStripMenuItem.Text = "qt";
            this.qtToolStripMenuItem.Click += new System.EventHandler(this.qtToolStripMenuItem_Click);
            // 
            // galToolStripMenuItem
            // 
            this.galToolStripMenuItem.Name = "galToolStripMenuItem";
            this.galToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.galToolStripMenuItem.Text = "gal";
            this.galToolStripMenuItem.Click += new System.EventHandler(this.galToolStripMenuItem_Click);
            // 
            // mLToolStripMenuItem
            // 
            this.mLToolStripMenuItem.Name = "mLToolStripMenuItem";
            this.mLToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.mLToolStripMenuItem.Text = "mL";
            this.mLToolStripMenuItem.Click += new System.EventHandler(this.mLToolStripMenuItem_Click);
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.lToolStripMenuItem.Text = "L";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // frmVolume
            // 
            this.AcceptButton = this.btnVolumeConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReturn;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVolumeTitle);
            this.Controls.Add(this.lblInputValue);
            this.Controls.Add(this.btnVolumeConvert);
            this.Controls.Add(this.btnSelectVolumeUnits);
            this.Controls.Add(this.txtVolumeUnit);
            this.Controls.Add(this.txtVolumeValue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblMetric);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblImperial);
            this.Name = "frmVolume";
            this.Text = "Volume Unit Converter";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ctxMenuVolumeUnits.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolumeTitle;
        private System.Windows.Forms.Label lblInputValue;
        private System.Windows.Forms.Button btnVolumeConvert;
        private System.Windows.Forms.Button btnSelectVolumeUnits;
        private System.Windows.Forms.TextBox txtVolumeUnit;
        private System.Windows.Forms.TextBox txtVolumeValue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblMetric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblMilliLiter;
        private System.Windows.Forms.Label lblLiter;
        private System.Windows.Forms.TextBox txtMilliLiter;
        private System.Windows.Forms.TextBox txtLiter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFluidOunce;
        private System.Windows.Forms.Label lblCup;
        private System.Windows.Forms.Label lblPint;
        private System.Windows.Forms.Label lblQuart;
        private System.Windows.Forms.TextBox txtFluidOunce;
        private System.Windows.Forms.TextBox txtCup;
        private System.Windows.Forms.TextBox txtPint;
        private System.Windows.Forms.TextBox txtQuart;
        private System.Windows.Forms.Label lblImperial;
        private System.Windows.Forms.Label lblGallon;
        private System.Windows.Forms.TextBox txtGallon;
        private System.Windows.Forms.ContextMenuStrip ctxMenuVolumeUnits;
        private System.Windows.Forms.ToolStripMenuItem flOzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem galToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;
    }
}