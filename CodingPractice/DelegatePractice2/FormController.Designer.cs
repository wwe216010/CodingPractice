namespace DelegatePractice2
{
    partial class FormController
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
            this.btnFather = new System.Windows.Forms.Button();
            this.btnMother = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFather
            // 
            this.btnFather.Location = new System.Drawing.Point(12, 12);
            this.btnFather.Name = "btnFather";
            this.btnFather.Size = new System.Drawing.Size(125, 38);
            this.btnFather.TabIndex = 0;
            this.btnFather.Text = "ShowFather";
            this.btnFather.UseVisualStyleBackColor = true;
            this.btnFather.Click += new System.EventHandler(this.btnFather_Click);
            // 
            // btnMother
            // 
            this.btnMother.Location = new System.Drawing.Point(12, 72);
            this.btnMother.Name = "btnMother";
            this.btnMother.Size = new System.Drawing.Size(125, 43);
            this.btnMother.TabIndex = 1;
            this.btnMother.Text = "ShowMother";
            this.btnMother.UseVisualStyleBackColor = true;
            this.btnMother.Click += new System.EventHandler(this.btnMother_Click);
            // 
            // FormController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.btnMother);
            this.Controls.Add(this.btnFather);
            this.Name = "FormController";
            this.Text = "FormController";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFather;
        private System.Windows.Forms.Button btnMother;
    }
}