namespace COMP123_S2019_Assignment5
{
    partial class OrderForm
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
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.WebCamLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ModelButton = new System.Windows.Forms.Button();
            this.ManufacturerButton = new System.Windows.Forms.Button();
            this.PlatformButton = new System.Windows.Forms.Button();
            this.OSButton = new System.Windows.Forms.Button();
            this.WebCamButton = new System.Windows.Forms.Button();
            this.GPUTypeButton = new System.Windows.Forms.Button();
            this.HDDButton = new System.Windows.Forms.Button();
            this.CPUSpeedButton = new System.Windows.Forms.Button();
            this.CPUNumberButton = new System.Windows.Forms.Button();
            this.CPUTypeButton = new System.Windows.Forms.Button();
            this.CPUBrandButton = new System.Windows.Forms.Button();
            this.MemoryButton = new System.Windows.Forms.Button();
            this.LCDSizeButton = new System.Windows.Forms.Button();
            this.ConditionButton = new System.Windows.Forms.Button();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TotalButton = new System.Windows.Forms.Button();
            this.SalesTaxButton = new System.Windows.Forms.Button();
            this.PriceButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PriceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(800, 28);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
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
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.backToolStripMenuItem.Text = "&Back";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.OSLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelButton);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerButton);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformButton);
            this.SystemComponentsGroupBox.Controls.Add(this.OSButton);
            this.SystemComponentsGroupBox.Controls.Add(this.WebCamButton);
            this.SystemComponentsGroupBox.Controls.Add(this.GPUTypeButton);
            this.SystemComponentsGroupBox.Controls.Add(this.HDDButton);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUSpeedButton);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUNumberButton);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUTypeButton);
            this.SystemComponentsGroupBox.Controls.Add(this.CPUBrandButton);
            this.SystemComponentsGroupBox.Controls.Add(this.MemoryButton);
            this.SystemComponentsGroupBox.Controls.Add(this.LCDSizeButton);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionButton);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(13, 37);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(459, 407);
            this.SystemComponentsGroupBox.TabIndex = 1;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            this.SystemComponentsGroupBox.Enter += new System.EventHandler(this.SystemComponentsGroupBox_Enter);
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.OSLabel.Location = new System.Drawing.Point(14, 378);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 17);
            this.OSLabel.TabIndex = 2;
            this.OSLabel.Text = "OS";
            // 
            // WebCamLabel
            // 
            this.WebCamLabel.AutoSize = true;
            this.WebCamLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WebCamLabel.Location = new System.Drawing.Point(14, 348);
            this.WebCamLabel.Name = "WebCamLabel";
            this.WebCamLabel.Size = new System.Drawing.Size(85, 17);
            this.WebCamLabel.TabIndex = 2;
            this.WebCamLabel.Text = "Web Cam";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(14, 319);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(88, 17);
            this.GPUTypeLabel.TabIndex = 2;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HDDLabel.Location = new System.Drawing.Point(14, 287);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(41, 17);
            this.HDDLabel.TabIndex = 2;
            this.HDDLabel.Text = "HDD";
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(14, 256);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(100, 17);
            this.CPUSpeedLabel.TabIndex = 2;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUNumberLabel.Location = new System.Drawing.Point(14, 224);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(111, 17);
            this.CPUNumberLabel.TabIndex = 2;
            this.CPUNumberLabel.Text = "CPU Number";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(14, 194);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(88, 17);
            this.CPUTypeLabel.TabIndex = 2;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(14, 162);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(96, 17);
            this.CPUBrandLabel.TabIndex = 2;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MemoryLabel.Location = new System.Drawing.Point(14, 130);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(72, 17);
            this.MemoryLabel.TabIndex = 2;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LCDSizeLabel.Location = new System.Drawing.Point(14, 100);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(82, 17);
            this.LCDSizeLabel.TabIndex = 2;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // ModelButton
            // 
            this.ModelButton.BackColor = System.Drawing.Color.White;
            this.ModelButton.Font = new System.Drawing.Font("Gulim", 10F);
            this.ModelButton.Location = new System.Drawing.Point(334, 57);
            this.ModelButton.Name = "ModelButton";
            this.ModelButton.Size = new System.Drawing.Size(110, 23);
            this.ModelButton.TabIndex = 1;
            this.ModelButton.UseVisualStyleBackColor = false;
            // 
            // ManufacturerButton
            // 
            this.ManufacturerButton.BackColor = System.Drawing.Color.White;
            this.ManufacturerButton.Location = new System.Drawing.Point(129, 57);
            this.ManufacturerButton.Name = "ManufacturerButton";
            this.ManufacturerButton.Size = new System.Drawing.Size(110, 23);
            this.ManufacturerButton.TabIndex = 1;
            this.ManufacturerButton.UseVisualStyleBackColor = false;
            // 
            // PlatformButton
            // 
            this.PlatformButton.BackColor = System.Drawing.Color.White;
            this.PlatformButton.Location = new System.Drawing.Point(334, 25);
            this.PlatformButton.Name = "PlatformButton";
            this.PlatformButton.Size = new System.Drawing.Size(110, 23);
            this.PlatformButton.TabIndex = 1;
            this.PlatformButton.UseVisualStyleBackColor = false;
            // 
            // OSButton
            // 
            this.OSButton.BackColor = System.Drawing.Color.White;
            this.OSButton.Location = new System.Drawing.Point(129, 376);
            this.OSButton.Name = "OSButton";
            this.OSButton.Size = new System.Drawing.Size(315, 23);
            this.OSButton.TabIndex = 1;
            this.OSButton.UseVisualStyleBackColor = false;
            // 
            // WebCamButton
            // 
            this.WebCamButton.BackColor = System.Drawing.Color.White;
            this.WebCamButton.Location = new System.Drawing.Point(129, 346);
            this.WebCamButton.Name = "WebCamButton";
            this.WebCamButton.Size = new System.Drawing.Size(315, 23);
            this.WebCamButton.TabIndex = 1;
            this.WebCamButton.UseVisualStyleBackColor = false;
            // 
            // GPUTypeButton
            // 
            this.GPUTypeButton.BackColor = System.Drawing.Color.White;
            this.GPUTypeButton.Location = new System.Drawing.Point(130, 317);
            this.GPUTypeButton.Name = "GPUTypeButton";
            this.GPUTypeButton.Size = new System.Drawing.Size(315, 23);
            this.GPUTypeButton.TabIndex = 1;
            this.GPUTypeButton.UseVisualStyleBackColor = false;
            // 
            // HDDButton
            // 
            this.HDDButton.BackColor = System.Drawing.Color.White;
            this.HDDButton.Location = new System.Drawing.Point(129, 285);
            this.HDDButton.Name = "HDDButton";
            this.HDDButton.Size = new System.Drawing.Size(315, 23);
            this.HDDButton.TabIndex = 1;
            this.HDDButton.UseVisualStyleBackColor = false;
            // 
            // CPUSpeedButton
            // 
            this.CPUSpeedButton.BackColor = System.Drawing.Color.White;
            this.CPUSpeedButton.Location = new System.Drawing.Point(129, 254);
            this.CPUSpeedButton.Name = "CPUSpeedButton";
            this.CPUSpeedButton.Size = new System.Drawing.Size(315, 23);
            this.CPUSpeedButton.TabIndex = 1;
            this.CPUSpeedButton.UseVisualStyleBackColor = false;
            // 
            // CPUNumberButton
            // 
            this.CPUNumberButton.BackColor = System.Drawing.Color.White;
            this.CPUNumberButton.Location = new System.Drawing.Point(129, 222);
            this.CPUNumberButton.Name = "CPUNumberButton";
            this.CPUNumberButton.Size = new System.Drawing.Size(315, 23);
            this.CPUNumberButton.TabIndex = 1;
            this.CPUNumberButton.UseVisualStyleBackColor = false;
            // 
            // CPUTypeButton
            // 
            this.CPUTypeButton.BackColor = System.Drawing.Color.White;
            this.CPUTypeButton.Location = new System.Drawing.Point(129, 192);
            this.CPUTypeButton.Name = "CPUTypeButton";
            this.CPUTypeButton.Size = new System.Drawing.Size(315, 23);
            this.CPUTypeButton.TabIndex = 1;
            this.CPUTypeButton.UseVisualStyleBackColor = false;
            // 
            // CPUBrandButton
            // 
            this.CPUBrandButton.BackColor = System.Drawing.Color.White;
            this.CPUBrandButton.Location = new System.Drawing.Point(129, 160);
            this.CPUBrandButton.Name = "CPUBrandButton";
            this.CPUBrandButton.Size = new System.Drawing.Size(315, 23);
            this.CPUBrandButton.TabIndex = 1;
            this.CPUBrandButton.UseVisualStyleBackColor = false;
            // 
            // MemoryButton
            // 
            this.MemoryButton.BackColor = System.Drawing.Color.White;
            this.MemoryButton.Location = new System.Drawing.Point(129, 128);
            this.MemoryButton.Name = "MemoryButton";
            this.MemoryButton.Size = new System.Drawing.Size(315, 23);
            this.MemoryButton.TabIndex = 1;
            this.MemoryButton.UseVisualStyleBackColor = false;
            // 
            // LCDSizeButton
            // 
            this.LCDSizeButton.BackColor = System.Drawing.Color.White;
            this.LCDSizeButton.Location = new System.Drawing.Point(129, 98);
            this.LCDSizeButton.Name = "LCDSizeButton";
            this.LCDSizeButton.Size = new System.Drawing.Size(315, 23);
            this.LCDSizeButton.TabIndex = 1;
            this.LCDSizeButton.UseVisualStyleBackColor = false;
            // 
            // ConditionButton
            // 
            this.ConditionButton.BackColor = System.Drawing.Color.White;
            this.ConditionButton.Location = new System.Drawing.Point(129, 27);
            this.ConditionButton.Name = "ConditionButton";
            this.ConditionButton.Size = new System.Drawing.Size(110, 23);
            this.ConditionButton.TabIndex = 1;
            this.ConditionButton.UseVisualStyleBackColor = false;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ModelLabel.Location = new System.Drawing.Point(271, 59);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(57, 17);
            this.ModelLabel.TabIndex = 0;
            this.ModelLabel.Text = "Model";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ManufacturerLabel.Location = new System.Drawing.Point(8, 60);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(116, 17);
            this.ManufacturerLabel.TabIndex = 0;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlatformLabel.Location = new System.Drawing.Point(252, 29);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(76, 17);
            this.PlatformLabel.TabIndex = 0;
            this.PlatformLabel.Text = "Platform";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConditionLabel.Location = new System.Drawing.Point(8, 29);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(86, 17);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP123_S2019_Assignment5.Properties.Resources.labtop;
            this.pictureBox1.Location = new System.Drawing.Point(489, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Controls.Add(this.TotalLabel);
            this.PriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.PriceGroupBox.Controls.Add(this.TotalButton);
            this.PriceGroupBox.Controls.Add(this.SalesTaxButton);
            this.PriceGroupBox.Controls.Add(this.PriceButton);
            this.PriceGroupBox.Location = new System.Drawing.Point(489, 216);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Size = new System.Drawing.Size(299, 186);
            this.PriceGroupBox.TabIndex = 3;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PriceLabel.Location = new System.Drawing.Point(18, 49);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(49, 17);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalLabel.Location = new System.Drawing.Point(18, 134);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(49, 17);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Gulim", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(18, 80);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(142, 17);
            this.SalesTaxLabel.TabIndex = 0;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // TotalButton
            // 
            this.TotalButton.BackColor = System.Drawing.Color.White;
            this.TotalButton.Location = new System.Drawing.Point(174, 132);
            this.TotalButton.Name = "TotalButton";
            this.TotalButton.Size = new System.Drawing.Size(110, 23);
            this.TotalButton.TabIndex = 1;
            this.TotalButton.UseVisualStyleBackColor = false;
            // 
            // SalesTaxButton
            // 
            this.SalesTaxButton.BackColor = System.Drawing.Color.White;
            this.SalesTaxButton.Location = new System.Drawing.Point(174, 78);
            this.SalesTaxButton.Name = "SalesTaxButton";
            this.SalesTaxButton.Size = new System.Drawing.Size(110, 23);
            this.SalesTaxButton.TabIndex = 1;
            this.SalesTaxButton.UseVisualStyleBackColor = false;
            // 
            // PriceButton
            // 
            this.PriceButton.BackColor = System.Drawing.Color.White;
            this.PriceButton.Location = new System.Drawing.Point(174, 47);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(110, 23);
            this.PriceButton.TabIndex = 1;
            this.PriceButton.UseVisualStyleBackColor = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BackButton.Location = new System.Drawing.Point(527, 415);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(83, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.White;
            this.CancelButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CancelButton.Location = new System.Drawing.Point(616, 415);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.White;
            this.FinishButton.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FinishButton.Location = new System.Drawing.Point(705, 415);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(83, 23);
            this.FinishButton.TabIndex = 1;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Button ModelButton;
        private System.Windows.Forms.Button ManufacturerButton;
        private System.Windows.Forms.Button PlatformButton;
        private System.Windows.Forms.Button ConditionButton;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebCamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Button OSButton;
        private System.Windows.Forms.Button WebCamButton;
        private System.Windows.Forms.Button GPUTypeButton;
        private System.Windows.Forms.Button HDDButton;
        private System.Windows.Forms.Button CPUSpeedButton;
        private System.Windows.Forms.Button CPUNumberButton;
        private System.Windows.Forms.Button CPUTypeButton;
        private System.Windows.Forms.Button CPUBrandButton;
        private System.Windows.Forms.Button MemoryButton;
        private System.Windows.Forms.Button LCDSizeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Button TotalButton;
        private System.Windows.Forms.Button SalesTaxButton;
        private System.Windows.Forms.Button PriceButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
    }
}