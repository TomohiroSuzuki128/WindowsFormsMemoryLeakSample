namespace WindowsFormsMemoryLeakSample
{
    partial class FormSecond
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
            System.Diagnostics.Debug.WriteLine($"Disposed FormSecond {count}");

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
            this.buttonAlert = new AlertButton();
            this.buttonClose = new CloseButton();
            this.SuspendLayout();
            // 
            // buttonAlert
            // 
            this.buttonAlert.Location = new System.Drawing.Point(270, 128);
            this.buttonAlert.Name = "buttonAlert";
            this.buttonAlert.Size = new System.Drawing.Size(203, 70);
            this.buttonAlert.TabIndex = 1;
            this.buttonAlert.Text = "buttonAlert";
            this.buttonAlert.UseVisualStyleBackColor = true;
            this.buttonAlert.Click += new System.EventHandler(this.buttonAlert_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(270, 230);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(203, 70);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "buttonClose";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 444);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAlert);
            this.Name = "FormSecond";
            this.Text = "FormSecond";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlert;
        private System.Windows.Forms.Button buttonClose;
    }
}