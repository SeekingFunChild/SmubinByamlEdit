﻿namespace ByamlEdit
{
    partial class ByamlEdit
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
            this.SuspendLayout();
            // 
            // ByamlEdit
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1576, 833);
            this.Name = "ByamlEdit";
            this.Text = "ByamlEdit";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ByamlEdit_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.ByamlEdit_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
