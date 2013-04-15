namespace RGB
{
    partial class GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.toolbar = new System.Windows.Forms.Panel();
            this.pixelNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixelNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolbar.BackColor = System.Drawing.SystemColors.Control;
            this.toolbar.Controls.Add(this.pixelNUD);
            this.toolbar.Controls.Add(this.label1);
            this.toolbar.Controls.Add(this.exportButton);
            this.toolbar.Controls.Add(this.convertButton);
            this.toolbar.Controls.Add(this.textBox);
            this.toolbar.Controls.Add(this.loadButton);
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(624, 26);
            this.toolbar.TabIndex = 0;
            // 
            // pixelNUD
            // 
            this.pixelNUD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pixelNUD.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pixelNUD.Location = new System.Drawing.Point(444, 4);
            this.pixelNUD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.pixelNUD.Name = "pixelNUD";
            this.pixelNUD.Size = new System.Drawing.Size(39, 20);
            this.pixelNUD.TabIndex = 5;
            this.pixelNUD.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pixelNUD.ValueChanged += new System.EventHandler(this.pixelNUD_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pixel Size:";
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Enabled = false;
            this.exportButton.Location = new System.Drawing.Point(558, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(63, 20);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertButton.Enabled = false;
            this.convertButton.Location = new System.Drawing.Point(489, 3);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(63, 20);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(72, 3);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(305, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.loadButton.Location = new System.Drawing.Point(3, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(63, 20);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(624, 4);
            this.progressBar.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.toolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Pixelizer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pixelNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown pixelNUD;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;


    }
}

