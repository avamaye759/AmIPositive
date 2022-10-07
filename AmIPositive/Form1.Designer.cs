namespace AmIPositive
{
    partial class Form1
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
            this.integerInput = new System.Windows.Forms.TextBox();
            this.integerLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.signOutput = new System.Windows.Forms.Label();
            this.divisOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // integerInput
            // 
            this.integerInput.Location = new System.Drawing.Point(294, 96);
            this.integerInput.Name = "integerInput";
            this.integerInput.Size = new System.Drawing.Size(100, 20);
            this.integerInput.TabIndex = 0;
            // 
            // integerLabel
            // 
            this.integerLabel.Location = new System.Drawing.Point(146, 93);
            this.integerLabel.Name = "integerLabel";
            this.integerLabel.Size = new System.Drawing.Size(100, 23);
            this.integerLabel.TabIndex = 1;
            this.integerLabel.Text = "Input an integer";
            this.integerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(331, 144);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(63, 35);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // signOutput
            // 
            this.signOutput.Location = new System.Drawing.Point(149, 269);
            this.signOutput.Name = "signOutput";
            this.signOutput.Size = new System.Drawing.Size(245, 23);
            this.signOutput.TabIndex = 3;
            this.signOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // divisOutput
            // 
            this.divisOutput.Location = new System.Drawing.Point(149, 310);
            this.divisOutput.Name = "divisOutput";
            this.divisOutput.Size = new System.Drawing.Size(245, 23);
            this.divisOutput.TabIndex = 4;
            this.divisOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 391);
            this.Controls.Add(this.divisOutput);
            this.Controls.Add(this.signOutput);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.integerLabel);
            this.Controls.Add(this.integerInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox integerInput;
        private System.Windows.Forms.Label integerLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label signOutput;
        private System.Windows.Forms.Label divisOutput;
    }
}

