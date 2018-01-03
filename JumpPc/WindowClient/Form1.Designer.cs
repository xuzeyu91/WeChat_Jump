namespace WindowClient
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_screen = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_init = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_left = new System.Windows.Forms.Button();
            this.pic_logo2 = new System.Windows.Forms.PictureBox();
            this.pic_logo1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_screen
            // 
            this.btn_screen.Location = new System.Drawing.Point(112, 10);
            this.btn_screen.Name = "btn_screen";
            this.btn_screen.Size = new System.Drawing.Size(75, 23);
            this.btn_screen.TabIndex = 3;
            this.btn_screen.Text = "获取屏幕";
            this.btn_screen.UseVisualStyleBackColor = true;
            this.btn_screen.Click += new System.EventHandler(this.btn_screen_Click);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(457, 10);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(47, 23);
            this.btn_right.TabIndex = 8;
            this.btn_right.Text = "向右";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(24, 10);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 11;
            this.btn_init.Text = "初始化";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "距离：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "时间：";
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(407, 10);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(44, 23);
            this.btn_left.TabIndex = 14;
            this.btn_left.Text = "向左";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // pic_logo2
            // 
            this.pic_logo2.Image = global::WindowClient.Properties.Resources.结束;
            this.pic_logo2.Location = new System.Drawing.Point(142, 704);
            this.pic_logo2.Name = "pic_logo2";
            this.pic_logo2.Size = new System.Drawing.Size(32, 32);
            this.pic_logo2.TabIndex = 10;
            this.pic_logo2.TabStop = false;
            this.pic_logo2.Visible = false;
            // 
            // pic_logo1
            // 
            this.pic_logo1.Image = global::WindowClient.Properties.Resources.开始__1_;
            this.pic_logo1.Location = new System.Drawing.Point(55, 704);
            this.pic_logo1.Name = "pic_logo1";
            this.pic_logo1.Size = new System.Drawing.Size(32, 32);
            this.pic_logo1.TabIndex = 9;
            this.pic_logo1.TabStop = false;
            this.pic_logo1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 782);
            this.Controls.Add(this.btn_left);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.pic_logo2);
            this.Controls.Add(this.pic_logo1);
            this.Controls.Add(this.btn_right);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_screen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "企鹅跳跳";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_screen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.PictureBox pic_logo1;
        private System.Windows.Forms.PictureBox pic_logo2;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_left;
    }
}

