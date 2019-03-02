namespace IronpythonDemo
{
    partial class IronPythonDemo
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
            this.components = new System.ComponentModel.Container();
            this.buttonScriptRun = new System.Windows.Forms.Button();
            this.comboBoxScript = new System.Windows.Forms.ComboBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.richTextBoxShow = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonScriptRun
            // 
            this.buttonScriptRun.Location = new System.Drawing.Point(199, 16);
            this.buttonScriptRun.Name = "buttonScriptRun";
            this.buttonScriptRun.Size = new System.Drawing.Size(75, 23);
            this.buttonScriptRun.TabIndex = 0;
            this.buttonScriptRun.Text = "脚本运行";
            this.buttonScriptRun.UseVisualStyleBackColor = true;
            this.buttonScriptRun.Click += new System.EventHandler(this.buttonScriptRun_Click);
            // 
            // comboBoxScript
            // 
            this.comboBoxScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScript.FormattingEnabled = true;
            this.comboBoxScript.Location = new System.Drawing.Point(72, 18);
            this.comboBoxScript.Name = "comboBoxScript";
            this.comboBoxScript.Size = new System.Drawing.Size(121, 20);
            this.comboBoxScript.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(16, 16);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(50, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "刷新";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // richTextBoxShow
            // 
            this.richTextBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxShow.Location = new System.Drawing.Point(12, 48);
            this.richTextBoxShow.Name = "richTextBoxShow";
            this.richTextBoxShow.ReadOnly = true;
            this.richTextBoxShow.Size = new System.Drawing.Size(305, 201);
            this.richTextBoxShow.TabIndex = 3;
            this.richTextBoxShow.Text = "";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // IronPythonDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 261);
            this.Controls.Add(this.richTextBoxShow);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.comboBoxScript);
            this.Controls.Add(this.buttonScriptRun);
            this.Name = "IronPythonDemo";
            this.Text = "IronPythonDemo";
            this.Load += new System.EventHandler(this.IronPythonDemo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScriptRun;
        private System.Windows.Forms.ComboBox comboBoxScript;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.RichTextBox richTextBoxShow;
        private System.Windows.Forms.Timer timer;
    }
}

