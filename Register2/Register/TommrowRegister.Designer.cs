namespace Register
{
    partial class TommrowRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxsqh = new System.Windows.Forms.TextBox();
            this.textBoxRegisterID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.skinEngine = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.textBoxHospitalName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxRegType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDays = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户申请码";
            // 
            // textBoxsqh
            // 
            this.textBoxsqh.Location = new System.Drawing.Point(80, 37);
            this.textBoxsqh.Multiline = true;
            this.textBoxsqh.Name = "textBoxsqh";
            this.textBoxsqh.Size = new System.Drawing.Size(369, 67);
            this.textBoxsqh.TabIndex = 1;
            // 
            // textBoxRegisterID
            // 
            this.textBoxRegisterID.Location = new System.Drawing.Point(80, 261);
            this.textBoxRegisterID.Multiline = true;
            this.textBoxRegisterID.Name = "textBoxRegisterID";
            this.textBoxRegisterID.Size = new System.Drawing.Size(369, 108);
            this.textBoxRegisterID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "注册码";
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(229, 208);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 4;
            this.buttonRegister.Text = "注册";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(348, 208);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // skinEngine
            // 
            this.skinEngine.SerialNumber = "";
            this.skinEngine.SkinFile = null;
            // 
            // textBoxHospitalName
            // 
            this.textBoxHospitalName.Location = new System.Drawing.Point(80, 110);
            this.textBoxHospitalName.Multiline = true;
            this.textBoxHospitalName.Name = "textBoxHospitalName";
            this.textBoxHospitalName.Size = new System.Drawing.Size(369, 46);
            this.textBoxHospitalName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "医院名称";
            // 
            // comboBoxRegType
            // 
            this.comboBoxRegType.Items.AddRange(new object[] {
            "试用版",
            "正式版"});
            this.comboBoxRegType.Location = new System.Drawing.Point(80, 163);
            this.comboBoxRegType.Name = "comboBoxRegType";
            this.comboBoxRegType.Size = new System.Drawing.Size(150, 20);
            this.comboBoxRegType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "注册类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "试用天数";
            // 
            // textBoxDays
            // 
            this.textBoxDays.Location = new System.Drawing.Point(348, 161);
            this.textBoxDays.Name = "textBoxDays";
            this.textBoxDays.Size = new System.Drawing.Size(101, 21);
            this.textBoxDays.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TommrowRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxDays);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxRegType);
            this.Controls.Add(this.textBoxHospitalName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textBoxRegisterID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxsqh);
            this.Controls.Add(this.label1);
            this.Name = "TommrowRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "应该程序注册";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxsqh;
        private System.Windows.Forms.TextBox textBoxRegisterID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonExit;
        private Sunisoft.IrisSkin.SkinEngine skinEngine;
        private System.Windows.Forms.TextBox textBoxHospitalName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxRegType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDays;
        private System.Windows.Forms.Button button1;
    }
}

