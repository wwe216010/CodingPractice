namespace DelegatePractice2
{
    partial class Form_Father
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
            this.label1 = new System.Windows.Forms.Label();
            this.uC_Child1 = new DelegatePractice2.UC_Child();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // uC_Child1
            // 
            this.uC_Child1.Location = new System.Drawing.Point(47, 12);
            this.uC_Child1.Name = "uC_Child1";
            this.uC_Child1.Size = new System.Drawing.Size(150, 150);
            this.uC_Child1.TabIndex = 0;
            // 
            // Form_Father
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uC_Child1);
            this.Name = "Form_Father";
            this.Text = "Form_Father";
            this.Load += new System.EventHandler(this.Form_Father_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC_Child uC_Child1;
        private System.Windows.Forms.Label label1;

    }
}