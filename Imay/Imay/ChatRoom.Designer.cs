namespace Imay
{
    partial class ChatRoom
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.pLeft = new System.Windows.Forms.Panel();
            this.Bear = new Imay.ucContact();
            this.Bean = new Imay.ucContact();
            this.pRight = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.pLeft);
            this.scMain.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.pRight);
            this.scMain.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.scMain.Size = new System.Drawing.Size(911, 575);
            this.scMain.SplitterDistance = 247;
            this.scMain.TabIndex = 0;
            // 
            // pLeft
            // 
            this.pLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLeft.Controls.Add(this.Bear);
            this.pLeft.Controls.Add(this.Bean);
            this.pLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLeft.Location = new System.Drawing.Point(3, 3);
            this.pLeft.Name = "pLeft";
            this.pLeft.Padding = new System.Windows.Forms.Padding(3, 3, 1, 3);
            this.pLeft.Size = new System.Drawing.Size(241, 569);
            this.pLeft.TabIndex = 0;
            // 
            // Bear
            // 
            this.Bear.ContactName = "Bear";
            this.Bear.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bear.Location = new System.Drawing.Point(3, 35);
            this.Bear.Name = "Bear";
            this.Bear.Size = new System.Drawing.Size(235, 32);
            this.Bear.TabIndex = 1;
            // 
            // Bean
            // 
            this.Bean.ContactName = "Bean";
            this.Bean.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bean.Location = new System.Drawing.Point(3, 3);
            this.Bean.Name = "Bean";
            this.Bean.Size = new System.Drawing.Size(235, 32);
            this.Bean.TabIndex = 0;
            // 
            // pRight
            // 
            this.pRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRight.Location = new System.Drawing.Point(3, 3);
            this.pRight.Name = "pRight";
            this.pRight.Padding = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.pRight.Size = new System.Drawing.Size(654, 569);
            this.pRight.TabIndex = 0;
            // 
            // ChatRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 575);
            this.Controls.Add(this.scMain);
            this.Name = "ChatRoom";
            this.Text = "ChatRoom";
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Panel pLeft;
        private System.Windows.Forms.Panel pRight;
        private ucContact Bean;
        private ucContact Bear;
    }
}