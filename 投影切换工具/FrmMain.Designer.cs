namespace WindowsFormsApp1
{
    partial class FrmMain
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
            this.Btn_Local = new System.Windows.Forms.Button();
            this.Btn_clone = new System.Windows.Forms.Button();
            this.Btn_extend = new System.Windows.Forms.Button();
            this.Btn_external = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Local
            // 
            this.Btn_Local.Location = new System.Drawing.Point(20, 32);
            this.Btn_Local.Name = "Btn_Local";
            this.Btn_Local.Size = new System.Drawing.Size(90, 43);
            this.Btn_Local.TabIndex = 0;
            this.Btn_Local.Text = "仅本机(&I)";
            this.Btn_Local.UseVisualStyleBackColor = true;
            this.Btn_Local.Click += new System.EventHandler(this.Btn_Local_Click);
            // 
            // Btn_clone
            // 
            this.Btn_clone.Location = new System.Drawing.Point(117, 32);
            this.Btn_clone.Name = "Btn_clone";
            this.Btn_clone.Size = new System.Drawing.Size(90, 43);
            this.Btn_clone.TabIndex = 1;
            this.Btn_clone.Text = "复制屏幕(&C)";
            this.Btn_clone.UseVisualStyleBackColor = true;
            this.Btn_clone.Click += new System.EventHandler(this.Btn_clone_Click);
            // 
            // Btn_extend
            // 
            this.Btn_extend.Location = new System.Drawing.Point(214, 32);
            this.Btn_extend.Name = "Btn_extend";
            this.Btn_extend.Size = new System.Drawing.Size(90, 43);
            this.Btn_extend.TabIndex = 2;
            this.Btn_extend.Text = "扩展屏幕(&E)";
            this.Btn_extend.UseVisualStyleBackColor = true;
            this.Btn_extend.Click += new System.EventHandler(this.Btn_extend_Click);
            // 
            // Btn_external
            // 
            this.Btn_external.Location = new System.Drawing.Point(311, 32);
            this.Btn_external.Name = "Btn_external";
            this.Btn_external.Size = new System.Drawing.Size(90, 43);
            this.Btn_external.TabIndex = 3;
            this.Btn_external.Text = "仅第二屏(&D)";
            this.Btn_external.UseVisualStyleBackColor = true;
            this.Btn_external.Click += new System.EventHandler(this.Btn_external_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 113);
            this.Controls.Add(this.Btn_external);
            this.Controls.Add(this.Btn_extend);
            this.Controls.Add(this.Btn_clone);
            this.Controls.Add(this.Btn_Local);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "投影切换工具";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Local;
        private System.Windows.Forms.Button Btn_clone;
        private System.Windows.Forms.Button Btn_extend;
        private System.Windows.Forms.Button Btn_external;
    }
}

