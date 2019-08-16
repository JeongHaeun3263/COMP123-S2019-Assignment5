namespace COMP123_S2019_Assignment5
{
    partial class ProductInfoForm
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
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ManufacturerButton = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelButton = new System.Windows.Forms.Button();
            this.OSLabel = new System.Windows.Forms.Label();
            this.OSButton = new System.Windows.Forms.Button();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.PlatformButton = new System.Windows.Forms.Button();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.ProductIDButton = new System.Windows.Forms.Button();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ConditionButton = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CostButton = new System.Windows.Forms.Button();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.WebCamButton = new System.Windows.Forms.Button();
            this.CPUSpeedButton = new System.Windows.Forms.Button();
            this.CPUTypeButton = new System.Windows.Forms.Button();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.GPUTypeButton = new System.Windows.Forms.Button();
            this.CPUNumberButton = new System.Windows.Forms.Button();
            this.CPUBrandButton = new System.Windows.Forms.Button();
            this.HDDButton = new System.Windows.Forms.Button();
            this.LCDSizeButton = new System.Windows.Forms.Button();
            this.MemoryButton = new System.Windows.Forms.Button();
            this.ClickNextLabel = new System.Windows.Forms.Label();
            this.SelectAnotherProductButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.ProductInfoMenuStrip.TabIndex = 0;
            this.ProductInfoMenuStrip.Text = "Product Info Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(285, 26);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerButton);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelButton);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSButton);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformButton);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(13, 120);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(775, 119);
            this.ProductInfoGroupBox.TabIndex = 1;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(23, 76);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(116, 17);
            this.ManufacturerLabel.TabIndex = 2;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ManufacturerButton
            // 
            this.ManufacturerButton.BackColor = System.Drawing.Color.White;
            this.ManufacturerButton.Location = new System.Drawing.Point(147, 74);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(130, 23);
            this.ManufacturerButton.TabIndex = 3;
            this.ManufacturerButton.UseVisualStyleBackColor = false;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ModelLabel.Location = new System.Drawing.Point(345, 76);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(57, 17);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Model";
            // 
            // ModelButton
            // 
            this.ModelButton.BackColor = System.Drawing.Color.White;
            this.ModelButton.Location = new System.Drawing.Point(409, 73);
            this.ModelButton.Name = "ModelButton";
            this.ModelButton.Size = new System.Drawing.Size(358, 23);
            this.ModelButton.TabIndex = 3;
            this.ModelButton.UseVisualStyleBackColor = false;
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OSLabel.Location = new System.Drawing.Point(370, 40);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 17);
            this.OSLabel.TabIndex = 2;
            this.OSLabel.Text = "OS";
            // 
            // OSButton
            // 
            this.OSButton.BackColor = System.Drawing.Color.White;
            this.OSButton.Location = new System.Drawing.Point(409, 37);
            this.OSButton.Name = "OSButton";
            this.OSButton.Size = new System.Drawing.Size(358, 23);
            this.OSButton.TabIndex = 3;
            this.OSButton.UseVisualStyleBackColor = false;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlatformLabel.Location = new System.Drawing.Point(63, 41);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(76, 17);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platform";
            // 
            // PlatformButton
            // 
            this.PlatformButton.BackColor = System.Drawing.Color.White;
            this.PlatformButton.Location = new System.Drawing.Point(147, 38);
            this.PlatformButton.Name = "PlatformButton";
            this.PlatformButton.Size = new System.Drawing.Size(130, 23);
            this.PlatformButton.TabIndex = 3;
            this.PlatformButton.UseVisualStyleBackColor = false;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductIDLabel.Location = new System.Drawing.Point(60, 57);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(93, 17);
            this.ProductIDLabel.TabIndex = 2;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // ProductIDButton
            // 
            this.ProductIDButton.BackColor = System.Drawing.Color.White;
            this.ProductIDButton.Location = new System.Drawing.Point(160, 54);
            this.ProductIDButton.Name = "ProductIDButton";
            this.ProductIDButton.Size = new System.Drawing.Size(130, 23);
            this.ProductIDButton.TabIndex = 3;
            this.ProductIDButton.UseVisualStyleBackColor = false;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConditionLabel.Location = new System.Drawing.Point(329, 56);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(86, 17);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // ConditionButton
            // 
            this.ConditionButton.BackColor = System.Drawing.Color.White;
            this.ConditionButton.Location = new System.Drawing.Point(421, 54);
            this.ConditionButton.Name = "ConditionButton";
            this.ConditionButton.Size = new System.Drawing.Size(130, 23);
            this.ConditionButton.TabIndex = 3;
            this.ConditionButton.UseVisualStyleBackColor = false;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CostLabel.Location = new System.Drawing.Point(597, 57);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(47, 17);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost";
            // 
            // CostButton
            // 
            this.CostButton.BackColor = System.Drawing.Color.White;
            this.CostButton.Location = new System.Drawing.Point(650, 54);
            this.CostButton.Name = "CostButton";
            this.CostButton.Size = new System.Drawing.Size(130, 23);
            this.CostButton.TabIndex = 3;
            this.CostButton.UseVisualStyleBackColor = false;
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebCamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebCamButton);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedButton);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeButton);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeButton);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberButton);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandButton);
            this.TechSpecsGroupBox.Controls.Add(this.HDDButton);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeButton);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryButton);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(13, 260);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(775, 136);
            this.TechSpecsGroupBox.TabIndex = 5;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WebCamLabel.Location = new System.Drawing.Point(551, 104);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(85, 17);
            this.WebCamLabel.TabIndex = 2;
            this.WebCamLabel.Text = "Web Cam";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(286, 104);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(100, 17);
            this.CPUSpeedLabel.TabIndex = 2;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(24, 103);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(88, 17);
            this.CPUTypeLabel.TabIndex = 2;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(550, 70);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(88, 17);
            this.GPUTypeLabel.TabIndex = 2;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(275, 70);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(111, 17);
            this.CPUNumberLabel.TabIndex = 2;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(16, 67);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(96, 17);
            this.CPUBrandLabel.TabIndex = 2;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // WebCamButton
            // 
            this.WebCamButton.BackColor = System.Drawing.Color.White;
            this.WebCamButton.Location = new System.Drawing.Point(638, 102);
            this.WebCamButton.Name = "WebCamButton";
            this.WebCamButton.Size = new System.Drawing.Size(130, 23);
            this.WebCamButton.TabIndex = 3;
            this.WebCamButton.UseVisualStyleBackColor = false;
            // 
            // CPUSpeedButton
            // 
            this.CPUSpeedButton.BackColor = System.Drawing.Color.White;
            this.CPUSpeedButton.Location = new System.Drawing.Point(393, 102);
            this.CPUSpeedButton.Name = "CPUSpeedButton";
            this.CPUSpeedButton.Size = new System.Drawing.Size(130, 23);
            this.CPUSpeedButton.TabIndex = 3;
            this.CPUSpeedButton.UseVisualStyleBackColor = false;
            // 
            // CPUTypeButton
            // 
            this.CPUTypeButton.BackColor = System.Drawing.Color.White;
            this.CPUTypeButton.Location = new System.Drawing.Point(119, 103);
            this.CPUTypeButton.Name = "CPUTypeButton";
            this.CPUTypeButton.Size = new System.Drawing.Size(130, 23);
            this.CPUTypeButton.TabIndex = 3;
            this.CPUTypeButton.UseVisualStyleBackColor = false;
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HDDLabel.Location = new System.Drawing.Point(590, 35);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(41, 17);
            this.HDDLabel.TabIndex = 2;
            this.HDDLabel.Text = "HDD";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(304, 35);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(82, 17);
            this.LCDSizeLabel.TabIndex = 2;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoryLabel.Location = new System.Drawing.Point(40, 34);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(72, 17);
            this.MemoryLabel.TabIndex = 2;
            this.MemoryLabel.Text = "Memory";
            // 
            // GPUTypeButton
            // 
            this.GPUTypeButton.BackColor = System.Drawing.Color.White;
            this.GPUTypeButton.Location = new System.Drawing.Point(637, 68);
            this.GPUTypeButton.Name = "GPUTypeButton";
            this.GPUTypeButton.Size = new System.Drawing.Size(130, 23);
            this.GPUTypeButton.TabIndex = 3;
            this.GPUTypeButton.UseVisualStyleBackColor = false;
            // 
            // CPUNumberButton
            // 
            this.CPUNumberButton.BackColor = System.Drawing.Color.White;
            this.CPUNumberButton.Location = new System.Drawing.Point(392, 68);
            this.CPUNumberButton.Name = "CPUNumberButton";
            this.CPUNumberButton.Size = new System.Drawing.Size(130, 23);
            this.CPUNumberButton.TabIndex = 3;
            this.CPUNumberButton.UseVisualStyleBackColor = false;
            // 
            // CPUBrandButton
            // 
            this.CPUBrandButton.BackColor = System.Drawing.Color.White;
            this.CPUBrandButton.Location = new System.Drawing.Point(118, 69);
            this.CPUBrandButton.Name = "CPUBrandButton";
            this.CPUBrandButton.Size = new System.Drawing.Size(130, 23);
            this.CPUBrandButton.TabIndex = 3;
            this.CPUBrandButton.UseVisualStyleBackColor = false;
            // 
            // HDDButton
            // 
            this.HDDButton.BackColor = System.Drawing.Color.White;
            this.HDDButton.Location = new System.Drawing.Point(637, 32);
            this.HDDButton.Name = "HDDButton";
            this.HDDButton.Size = new System.Drawing.Size(130, 23);
            this.HDDButton.TabIndex = 3;
            this.HDDButton.UseVisualStyleBackColor = false;
            // 
            // LCDSizeButton
            // 
            this.LCDSizeButton.BackColor = System.Drawing.Color.White;
            this.LCDSizeButton.Location = new System.Drawing.Point(392, 32);
            this.LCDSizeButton.Name = "LCDSizeButton";
            this.LCDSizeButton.Size = new System.Drawing.Size(130, 23);
            this.LCDSizeButton.TabIndex = 3;
            this.LCDSizeButton.UseVisualStyleBackColor = false;
            // 
            // MemoryButton
            // 
            this.MemoryButton.BackColor = System.Drawing.Color.White;
            this.MemoryButton.Location = new System.Drawing.Point(118, 33);
            this.MemoryButton.Name = "MemoryButton";
            this.MemoryButton.Size = new System.Drawing.Size(130, 23);
            this.MemoryButton.TabIndex = 3;
            this.MemoryButton.UseVisualStyleBackColor = false;
            // 
            // ClickNextLabel
            // 
            this.ClickNextLabel.AutoSize = true;
            this.ClickNextLabel.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ClickNextLabel.Location = new System.Drawing.Point(12, 413);
            this.ClickNextLabel.Name = "ClickNextLabel";
            this.ClickNextLabel.Size = new System.Drawing.Size(281, 15);
            this.ClickNextLabel.TabIndex = 6;
            this.ClickNextLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // SelectAnotherProductButton
            // 
            this.SelectAnotherProductButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SelectAnotherProductButton.Location = new System.Drawing.Point(361, 409);
            this.SelectAnotherProductButton.Name = "SelectAnotherProductButton";
            this.SelectAnotherProductButton.Size = new System.Drawing.Size(200, 23);
            this.SelectAnotherProductButton.TabIndex = 7;
            this.SelectAnotherProductButton.Text = "Select Another Product";
            this.SelectAnotherProductButton.UseVisualStyleBackColor = true;
            this.SelectAnotherProductButton.Click += new System.EventHandler(this.SelectAnotherProductButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CancelButton.Location = new System.Drawing.Point(582, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NextButton.Location = new System.Drawing.Point(694, 409);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(94, 23);
            this.NextButton.TabIndex = 9;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectAnotherProductButton);
            this.Controls.Add(this.ClickNextLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.CostButton);
            this.Controls.Add(this.ConditionButton);
            this.Controls.Add(this.ProductIDButton);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoForm";
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Button ProductIDButton;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Button ConditionButton;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Button CostButton;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Button ManufacturerButton;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button ModelButton;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Button OSButton;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Button PlatformButton;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Button WebCamButton;
        private System.Windows.Forms.Button CPUSpeedButton;
        private System.Windows.Forms.Button CPUTypeButton;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Button GPUTypeButton;
        private System.Windows.Forms.Button CPUNumberButton;
        private System.Windows.Forms.Button CPUBrandButton;
        private System.Windows.Forms.Button HDDButton;
        private System.Windows.Forms.Button LCDSizeButton;
        private System.Windows.Forms.Button MemoryButton;
        private System.Windows.Forms.Label ClickNextLabel;
        private System.Windows.Forms.Button SelectAnotherProductButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}