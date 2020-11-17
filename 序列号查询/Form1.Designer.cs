namespace 序列号查询
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Rbox_show = new System.Windows.Forms.RichTextBox();
            this.tbox_error = new System.Windows.Forms.TextBox();
            this.checkBox_PN = new System.Windows.Forms.CheckBox();
            this.checkBox_Features = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CBox_device = new System.Windows.Forms.ComboBox();
            this.label_DEFAULT = new System.Windows.Forms.Label();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbox_xuliehao = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Rbox_show
            // 
            this.Rbox_show.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Rbox_show.Font = new System.Drawing.Font("宋体", 15F);
            this.Rbox_show.Location = new System.Drawing.Point(2, 163);
            this.Rbox_show.Name = "Rbox_show";
            this.Rbox_show.Size = new System.Drawing.Size(804, 305);
            this.Rbox_show.TabIndex = 2;
            this.Rbox_show.Text = "";
            // 
            // tbox_error
            // 
            this.tbox_error.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_error.Font = new System.Drawing.Font("宋体", 15F);
            this.tbox_error.ForeColor = System.Drawing.Color.Red;
            this.tbox_error.Location = new System.Drawing.Point(95, 480);
            this.tbox_error.Name = "tbox_error";
            this.tbox_error.Size = new System.Drawing.Size(711, 30);
            this.tbox_error.TabIndex = 3;
            // 
            // checkBox_PN
            // 
            this.checkBox_PN.AutoSize = true;
            this.checkBox_PN.Font = new System.Drawing.Font("宋体", 15F);
            this.checkBox_PN.Location = new System.Drawing.Point(117, 95);
            this.checkBox_PN.Name = "checkBox_PN";
            this.checkBox_PN.Size = new System.Drawing.Size(108, 24);
            this.checkBox_PN.TabIndex = 4;
            this.checkBox_PN.Text = "型号查询";
            this.checkBox_PN.UseVisualStyleBackColor = true;
            this.checkBox_PN.CheckedChanged += new System.EventHandler(this.checkBox_PN_CheckedChanged);
            // 
            // checkBox_Features
            // 
            this.checkBox_Features.AutoSize = true;
            this.checkBox_Features.Font = new System.Drawing.Font("宋体", 15F);
            this.checkBox_Features.Location = new System.Drawing.Point(248, 95);
            this.checkBox_Features.Name = "checkBox_Features";
            this.checkBox_Features.Size = new System.Drawing.Size(108, 24);
            this.checkBox_Features.TabIndex = 5;
            this.checkBox_Features.Text = "功能查询";
            this.checkBox_Features.UseVisualStyleBackColor = true;
            this.checkBox_Features.CheckedChanged += new System.EventHandler(this.checkBox_Features_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(-3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "功能选择：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(-3, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "类型选择：";
            // 
            // CBox_device
            // 
            this.CBox_device.Font = new System.Drawing.Font("宋体", 15F);
            this.CBox_device.FormattingEnabled = true;
            this.CBox_device.Location = new System.Drawing.Point(117, 128);
            this.CBox_device.Name = "CBox_device";
            this.CBox_device.Size = new System.Drawing.Size(230, 28);
            this.CBox_device.TabIndex = 8;
            this.CBox_device.SelectedIndexChanged += new System.EventHandler(this.CBox_device_SelectedIndexChanged);
            // 
            // label_DEFAULT
            // 
            this.label_DEFAULT.AutoSize = true;
            this.label_DEFAULT.Font = new System.Drawing.Font("宋体", 15F);
            this.label_DEFAULT.Location = new System.Drawing.Point(0, 66);
            this.label_DEFAULT.Name = "label_DEFAULT";
            this.label_DEFAULT.Size = new System.Drawing.Size(109, 20);
            this.label_DEFAULT.TabIndex = 9;
            this.label_DEFAULT.Text = "默认序列号";
            // 
            // btn_clearall
            // 
            this.btn_clearall.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_clearall.Location = new System.Drawing.Point(353, 126);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(94, 31);
            this.btn_clearall.TabIndex = 10;
            this.btn_clearall.Text = "清空";
            this.btn_clearall.UseVisualStyleBackColor = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_save.Location = new System.Drawing.Point(453, 126);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 31);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(0, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "提示框：";
            // 
            // gbox_xuliehao
            // 
            this.gbox_xuliehao.Font = new System.Drawing.Font("宋体", 9F);
            this.gbox_xuliehao.Location = new System.Drawing.Point(2, 0);
            this.gbox_xuliehao.Name = "gbox_xuliehao";
            this.gbox_xuliehao.Size = new System.Drawing.Size(530, 56);
            this.gbox_xuliehao.TabIndex = 13;
            this.gbox_xuliehao.TabStop = false;
            this.gbox_xuliehao.Text = "型号显示框";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 524);
            this.Controls.Add(this.label_DEFAULT);
            this.Controls.Add(this.gbox_xuliehao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_clearall);
            this.Controls.Add(this.CBox_device);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_Features);
            this.Controls.Add(this.checkBox_PN);
            this.Controls.Add(this.tbox_error);
            this.Controls.Add(this.Rbox_show);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "型号查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Rbox_show;
        private System.Windows.Forms.TextBox tbox_error;
        private System.Windows.Forms.CheckBox checkBox_PN;
        private System.Windows.Forms.CheckBox checkBox_Features;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox CBox_device;
        private System.Windows.Forms.Label label_DEFAULT;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox gbox_xuliehao;
    }
}

