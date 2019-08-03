namespace COMP123_S2019_Assignment5
{
    partial class StartForm
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
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartFormTextBox = new System.Windows.Forms.TextBox();
            this.DollorComputerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DollorComputerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.Location = new System.Drawing.Point(46, 267);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(211, 44);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "Start a New Order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.Location = new System.Drawing.Point(46, 317);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(211, 44);
            this.LoadOrderButton.TabIndex = 0;
            this.LoadOrderButton.Text = "Load a Saved Order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            this.LoadOrderButton.Click += new System.EventHandler(this.LoadOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(46, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(211, 44);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit the Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartFormTextBox
            // 
            this.StartFormTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StartFormTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StartFormTextBox.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartFormTextBox.Location = new System.Drawing.Point(46, 23);
            this.StartFormTextBox.Name = "StartFormTextBox";
            this.StartFormTextBox.Size = new System.Drawing.Size(211, 23);
            this.StartFormTextBox.TabIndex = 2;
            this.StartFormTextBox.Text = "Order Your Computer";
            this.StartFormTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DollorComputerPictureBox
            // 
            this.DollorComputerPictureBox.Image = global::COMP123_S2019_Assignment5.Properties.Resources.splashscreen;
            this.DollorComputerPictureBox.Location = new System.Drawing.Point(46, 68);
            this.DollorComputerPictureBox.Name = "DollorComputerPictureBox";
            this.DollorComputerPictureBox.Size = new System.Drawing.Size(211, 174);
            this.DollorComputerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DollorComputerPictureBox.TabIndex = 1;
            this.DollorComputerPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.ControlBox = false;
            this.Controls.Add(this.StartFormTextBox);
            this.Controls.Add(this.DollorComputerPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start Form";
            ((System.ComponentModel.ISupportInitialize)(this.DollorComputerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox DollorComputerPictureBox;
        private System.Windows.Forms.TextBox StartFormTextBox;
    }
}

