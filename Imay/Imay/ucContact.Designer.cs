namespace Imay
{
    partial class ucContact
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.pImage = new System.Windows.Forms.Panel();
            this.pName = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.pImage.SuspendLayout();
            this.pName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pName);
            this.panel.Controls.Add(this.pImage);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 32);
            this.panel.TabIndex = 0;
            // 
            // pImage
            // 
            this.pImage.Controls.Add(this.picImage);
            this.pImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pImage.Location = new System.Drawing.Point(0, 0);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(35, 32);
            this.pImage.TabIndex = 0;
            // 
            // pName
            // 
            this.pName.Controls.Add(this.lblName);
            this.pName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pName.Location = new System.Drawing.Point(35, 0);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(215, 32);
            this.pName.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Image = global::Imay.Properties.Resources.Icon;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(35, 32);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Bean";
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(250, 32);
            this.panel.ResumeLayout(false);
            this.pImage.ResumeLayout(false);
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel pName;
        private System.Windows.Forms.Panel pImage;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Label lblName;
    }
}
