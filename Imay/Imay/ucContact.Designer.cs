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
            this.pName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pImage = new System.Windows.Forms.Panel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.pName.SuspendLayout();
            this.pImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pName);
            this.panel.Controls.Add(this.pImage);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(184, 42);
            this.panel.TabIndex = 0;
            // 
            // pName
            // 
            this.pName.Controls.Add(this.lblName);
            this.pName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pName.Location = new System.Drawing.Point(44, 0);
            this.pName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(140, 42);
            this.pName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Bean";
            // 
            // pImage
            // 
            this.pImage.Controls.Add(this.picImage);
            this.pImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pImage.Location = new System.Drawing.Point(0, 0);
            this.pImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pImage.Name = "pImage";
            this.pImage.Size = new System.Drawing.Size(44, 42);
            this.pImage.TabIndex = 0;
            // 
            // picImage
            // 
            this.picImage.BackgroundImage = global::Imay.Properties.Resources.Icon;
            this.picImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(44, 42);
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // ucContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucContact";
            this.Size = new System.Drawing.Size(184, 42);
            this.panel.ResumeLayout(false);
            this.pName.ResumeLayout(false);
            this.pName.PerformLayout();
            this.pImage.ResumeLayout(false);
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
