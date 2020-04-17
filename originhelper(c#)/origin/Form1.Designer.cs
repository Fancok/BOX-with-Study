namespace origin
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.open_btn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lujing_lab = new System.Windows.Forms.Label();
            this.updata_btn = new System.Windows.Forms.Button();
            this.clrom_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.帮助说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swicdn_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(12, 31);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(87, 23);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "选择更新文件";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lujing_lab
            // 
            this.lujing_lab.AutoSize = true;
            this.lujing_lab.Location = new System.Drawing.Point(109, 9);
            this.lujing_lab.Name = "lujing_lab";
            this.lujing_lab.Size = new System.Drawing.Size(83, 12);
            this.lujing_lab.TabIndex = 1;
            this.lujing_lab.Text = "拖入文件路径:";
            // 
            // updata_btn
            // 
            this.updata_btn.Location = new System.Drawing.Point(105, 31);
            this.updata_btn.Name = "updata_btn";
            this.updata_btn.Size = new System.Drawing.Size(87, 23);
            this.updata_btn.TabIndex = 2;
            this.updata_btn.Text = "装载更新文件";
            this.updata_btn.UseVisualStyleBackColor = true;
            this.updata_btn.Click += new System.EventHandler(this.updata_btn_Click);
            // 
            // clrom_btn
            // 
            this.clrom_btn.Location = new System.Drawing.Point(198, 31);
            this.clrom_btn.Name = "clrom_btn";
            this.clrom_btn.Size = new System.Drawing.Size(87, 23);
            this.clrom_btn.TabIndex = 3;
            this.clrom_btn.Text = "删除缓存";
            this.clrom_btn.UseVisualStyleBackColor = true;
            this.clrom_btn.Click += new System.EventHandler(this.clrom_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助说明ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(377, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 帮助说明ToolStripMenuItem
            // 
            this.帮助说明ToolStripMenuItem.Name = "帮助说明ToolStripMenuItem";
            this.帮助说明ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.帮助说明ToolStripMenuItem.Text = "使用说明";
            this.帮助说明ToolStripMenuItem.Click += new System.EventHandler(this.帮助说明ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // swicdn_btn
            // 
            this.swicdn_btn.Location = new System.Drawing.Point(291, 31);
            this.swicdn_btn.Name = "swicdn_btn";
            this.swicdn_btn.Size = new System.Drawing.Size(75, 23);
            this.swicdn_btn.TabIndex = 5;
            this.swicdn_btn.Text = "切换CDN";
            this.swicdn_btn.UseVisualStyleBackColor = true;
            this.swicdn_btn.Click += new System.EventHandler(this.swicdn_btn_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 60);
            this.Controls.Add(this.swicdn_btn);
            this.Controls.Add(this.clrom_btn);
            this.Controls.Add(this.updata_btn);
            this.Controls.Add(this.lujing_lab);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Origin小工具v1.0";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lujing_lab;
        private System.Windows.Forms.Button updata_btn;
        private System.Windows.Forms.Button clrom_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 帮助说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Button swicdn_btn;
    }
}

