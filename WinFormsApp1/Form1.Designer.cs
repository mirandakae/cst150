namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.introductionButton = new System.Windows.Forms.Button();
            this.objectionButton = new System.Windows.Forms.Button();
            this.motivationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // introductionButton
            // 
            this.introductionButton.Location = new System.Drawing.Point(45, 65);
            this.introductionButton.Name = "introductionButton";
            this.introductionButton.Size = new System.Drawing.Size(86, 23);
            this.introductionButton.TabIndex = 0;
            this.introductionButton.Text = "Introduction";
            this.introductionButton.UseVisualStyleBackColor = true;
            this.introductionButton.Click += new System.EventHandler(this.introductionButton_Click);
            // 
            // objectionButton
            // 
            this.objectionButton.Location = new System.Drawing.Point(198, 65);
            this.objectionButton.Name = "objectionButton";
            this.objectionButton.Size = new System.Drawing.Size(75, 23);
            this.objectionButton.TabIndex = 1;
            this.objectionButton.Text = "Objection";
            this.objectionButton.UseVisualStyleBackColor = true;
            this.objectionButton.Click += new System.EventHandler(this.objectionButton_Click);
            // 
            // motivationButton
            // 
            this.motivationButton.Location = new System.Drawing.Point(348, 65);
            this.motivationButton.Name = "motivationButton";
            this.motivationButton.Size = new System.Drawing.Size(75, 23);
            this.motivationButton.TabIndex = 2;
            this.motivationButton.Text = "Motivation";
            this.motivationButton.UseVisualStyleBackColor = true;
            this.motivationButton.Click += new System.EventHandler(this.motivationButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.motivationButton);
            this.Controls.Add(this.objectionButton);
            this.Controls.Add(this.introductionButton);
            this.Name = "Form1";
            this.Text = "First time";
            this.ResumeLayout(false);

        }

        #endregion

        private Button introductionButton;
        private Button objectionButton;
        private Button motivationButton;
    }
}