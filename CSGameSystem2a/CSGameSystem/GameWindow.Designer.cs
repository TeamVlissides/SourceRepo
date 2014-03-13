namespace CSGameSystem
{
    partial class GUIWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.viewTextOutput = new System.Windows.Forms.TextBox();
            this.UpButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.executeActionButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.viewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewTextOutput
            // 
            this.viewTextOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewTextOutput.Location = new System.Drawing.Point(485, 45);
            this.viewTextOutput.Multiline = true;
            this.viewTextOutput.Name = "viewTextOutput";
            this.viewTextOutput.ReadOnly = true;
            this.viewTextOutput.Size = new System.Drawing.Size(300, 139);
            this.viewTextOutput.TabIndex = 1;
            this.viewTextOutput.Text = "Welcome to the Dungeon Battle System Game\r\n\r\n";
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(605, 304);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(52, 42);
            this.UpButton.TabIndex = 4;
            this.UpButton.Text = "UP";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(653, 347);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(52, 42);
            this.RightButton.TabIndex = 5;
            this.RightButton.Text = "RIGHT";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(605, 390);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(52, 42);
            this.DownButton.TabIndex = 6;
            this.DownButton.Text = "DOWN";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // LeftButton
            // 
            this.LeftButton.Location = new System.Drawing.Point(556, 347);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(52, 42);
            this.LeftButton.TabIndex = 7;
            this.LeftButton.Text = "LEFT";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // executeActionButton
            // 
            this.executeActionButton.Location = new System.Drawing.Point(102, 208);
            this.executeActionButton.Name = "executeActionButton";
            this.executeActionButton.Size = new System.Drawing.Size(104, 20);
            this.executeActionButton.TabIndex = 8;
            this.executeActionButton.Text = "Execute Action";
            this.executeActionButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Attack",
            "White Magic",
            "Black Magic",
            "Summon",
            "E. Skill"});
            this.comboBox1.Location = new System.Drawing.Point(82, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Attack";
            // 
            // viewPanel
            // 
            this.viewPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewPanel.Controls.Add(this.comboBox1);
            this.viewPanel.Controls.Add(this.executeActionButton);
            this.viewPanel.Location = new System.Drawing.Point(474, 22);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(324, 433);
            this.viewPanel.TabIndex = 10;
            this.viewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.viewPanel_Paint);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(744, 488);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(70, 24);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GUIWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 524);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.viewTextOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "GUIWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dungeon & Battle System Game";
            this.Load += new System.EventHandler(this.GUIWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GUIWindow_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GUIWindow_KeyUp);
            this.viewPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox viewTextOutput;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button executeActionButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.Button exitButton;
    }
}

