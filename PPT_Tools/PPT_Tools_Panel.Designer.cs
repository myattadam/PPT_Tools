namespace PPT_Tools
{
    partial class PPT_Tools_Panel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCopyLayout = new System.Windows.Forms.Button();
            this.BtnPasteLayout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCopyLayout
            // 
            this.BtnCopyLayout.Location = new System.Drawing.Point(3, 3);
            this.BtnCopyLayout.Name = "BtnCopyLayout";
            this.BtnCopyLayout.Size = new System.Drawing.Size(80, 23);
            this.BtnCopyLayout.TabIndex = 2;
            this.BtnCopyLayout.Text = "Copy Layout";
            this.BtnCopyLayout.UseVisualStyleBackColor = true;
            this.BtnCopyLayout.Click += new System.EventHandler(this.BtnCopyLayout_Click);
            // 
            // BtnPasteLayout
            // 
            this.BtnPasteLayout.Location = new System.Drawing.Point(3, 32);
            this.BtnPasteLayout.Name = "BtnPasteLayout";
            this.BtnPasteLayout.Size = new System.Drawing.Size(80, 23);
            this.BtnPasteLayout.TabIndex = 3;
            this.BtnPasteLayout.Text = "Paste Layout";
            this.BtnPasteLayout.UseVisualStyleBackColor = true;
            this.BtnPasteLayout.Click += new System.EventHandler(this.BtnPasteLayout_Click);
            // 
            // PPT_Tools_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnPasteLayout);
            this.Controls.Add(this.BtnCopyLayout);
            this.Name = "PPT_Tools_Panel";
            this.Size = new System.Drawing.Size(269, 437);
            this.Load += new System.EventHandler(this.PPT_Tools_Panel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCopyLayout;
        private System.Windows.Forms.Button BtnPasteLayout;
    }
}
