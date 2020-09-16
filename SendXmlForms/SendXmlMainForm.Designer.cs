namespace SendXmlForms
{
    partial class SendXmlMainForm
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
            this.label_MqAddress = new System.Windows.Forms.Label();
            this.label_SendXml = new System.Windows.Forms.Label();
            this.textBox_MqAddress = new System.Windows.Forms.TextBox();
            this.textBox_SelectXml = new System.Windows.Forms.TextBox();
            this.button_SelectXml = new System.Windows.Forms.Button();
            this.button_SendXml = new System.Windows.Forms.Button();
            this.radioButton_XML = new System.Windows.Forms.RadioButton();
            this.radioButton_Binary = new System.Windows.Forms.RadioButton();
            this.radioButton_String = new System.Windows.Forms.RadioButton();
            this.groupBox_DataType = new System.Windows.Forms.GroupBox();
            this.button_SenAll = new System.Windows.Forms.Button();
            this.textBox_SelectDirec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_DataType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_MqAddress
            // 
            this.label_MqAddress.AutoSize = true;
            this.label_MqAddress.Location = new System.Drawing.Point(33, 48);
            this.label_MqAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MqAddress.Name = "label_MqAddress";
            this.label_MqAddress.Size = new System.Drawing.Size(83, 15);
            this.label_MqAddress.TabIndex = 0;
            this.label_MqAddress.Text = "MQ队列地址";
            // 
            // label_SendXml
            // 
            this.label_SendXml.AutoSize = true;
            this.label_SendXml.Location = new System.Drawing.Point(33, 101);
            this.label_SendXml.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SendXml.Name = "label_SendXml";
            this.label_SendXml.Size = new System.Drawing.Size(67, 15);
            this.label_SendXml.TabIndex = 1;
            this.label_SendXml.Text = "发送报文";
            // 
            // textBox_MqAddress
            // 
            this.textBox_MqAddress.Location = new System.Drawing.Point(128, 44);
            this.textBox_MqAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MqAddress.Name = "textBox_MqAddress";
            this.textBox_MqAddress.Size = new System.Drawing.Size(476, 25);
            this.textBox_MqAddress.TabIndex = 2;
            // 
            // textBox_SelectXml
            // 
            this.textBox_SelectXml.Location = new System.Drawing.Point(127, 98);
            this.textBox_SelectXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_SelectXml.Name = "textBox_SelectXml";
            this.textBox_SelectXml.Size = new System.Drawing.Size(477, 25);
            this.textBox_SelectXml.TabIndex = 3;
            // 
            // button_SelectXml
            // 
            this.button_SelectXml.Location = new System.Drawing.Point(613, 95);
            this.button_SelectXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SelectXml.Name = "button_SelectXml";
            this.button_SelectXml.Size = new System.Drawing.Size(100, 29);
            this.button_SelectXml.TabIndex = 5;
            this.button_SelectXml.Text = "选择报文";
            this.button_SelectXml.UseVisualStyleBackColor = true;
            this.button_SelectXml.Click += new System.EventHandler(this.button_SelectXml_Click);
            // 
            // button_SendXml
            // 
            this.button_SendXml.Location = new System.Drawing.Point(307, 346);
            this.button_SendXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SendXml.Name = "button_SendXml";
            this.button_SendXml.Size = new System.Drawing.Size(100, 29);
            this.button_SendXml.TabIndex = 6;
            this.button_SendXml.Text = "发送报文";
            this.button_SendXml.UseVisualStyleBackColor = true;
            this.button_SendXml.Click += new System.EventHandler(this.button_SendXml_Click);
            // 
            // radioButton_XML
            // 
            this.radioButton_XML.AutoSize = true;
            this.radioButton_XML.Location = new System.Drawing.Point(8, 40);
            this.radioButton_XML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_XML.Name = "radioButton_XML";
            this.radioButton_XML.Size = new System.Drawing.Size(82, 19);
            this.radioButton_XML.TabIndex = 7;
            this.radioButton_XML.TabStop = true;
            this.radioButton_XML.Text = "XML文件";
            this.radioButton_XML.UseVisualStyleBackColor = true;
            // 
            // radioButton_Binary
            // 
            this.radioButton_Binary.AutoSize = true;
            this.radioButton_Binary.Location = new System.Drawing.Point(176, 40);
            this.radioButton_Binary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Binary.Name = "radioButton_Binary";
            this.radioButton_Binary.Size = new System.Drawing.Size(103, 19);
            this.radioButton_Binary.TabIndex = 8;
            this.radioButton_Binary.TabStop = true;
            this.radioButton_Binary.Text = "二进制数据";
            this.radioButton_Binary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_Binary.UseVisualStyleBackColor = true;
            // 
            // radioButton_String
            // 
            this.radioButton_String.AutoSize = true;
            this.radioButton_String.Location = new System.Drawing.Point(359, 40);
            this.radioButton_String.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_String.Name = "radioButton_String";
            this.radioButton_String.Size = new System.Drawing.Size(103, 19);
            this.radioButton_String.TabIndex = 9;
            this.radioButton_String.TabStop = true;
            this.radioButton_String.Text = "字符串数据";
            this.radioButton_String.UseVisualStyleBackColor = true;
            // 
            // groupBox_DataType
            // 
            this.groupBox_DataType.Controls.Add(this.radioButton_XML);
            this.groupBox_DataType.Controls.Add(this.radioButton_String);
            this.groupBox_DataType.Controls.Add(this.radioButton_Binary);
            this.groupBox_DataType.Location = new System.Drawing.Point(128, 214);
            this.groupBox_DataType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_DataType.Name = "groupBox_DataType";
            this.groupBox_DataType.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_DataType.Size = new System.Drawing.Size(477, 91);
            this.groupBox_DataType.TabIndex = 10;
            this.groupBox_DataType.TabStop = false;
            this.groupBox_DataType.Text = "数据发送格式";
            // 
            // button_SenAll
            // 
            this.button_SenAll.Location = new System.Drawing.Point(613, 154);
            this.button_SenAll.Margin = new System.Windows.Forms.Padding(4);
            this.button_SenAll.Name = "button_SenAll";
            this.button_SenAll.Size = new System.Drawing.Size(100, 29);
            this.button_SenAll.TabIndex = 13;
            this.button_SenAll.Text = "选择目录";
            this.button_SenAll.UseVisualStyleBackColor = true;
            this.button_SenAll.Click += new System.EventHandler(this.button_SenAll_Click);
            // 
            // textBox_SelectDirec
            // 
            this.textBox_SelectDirec.Location = new System.Drawing.Point(126, 158);
            this.textBox_SelectDirec.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SelectDirec.Name = "textBox_SelectDirec";
            this.textBox_SelectDirec.Size = new System.Drawing.Size(477, 25);
            this.textBox_SelectDirec.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 161);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "报文目录";
            // 
            // SendXmlMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 409);
            this.Controls.Add(this.button_SenAll);
            this.Controls.Add(this.textBox_SelectDirec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_DataType);
            this.Controls.Add(this.button_SendXml);
            this.Controls.Add(this.button_SelectXml);
            this.Controls.Add(this.textBox_SelectXml);
            this.Controls.Add(this.textBox_MqAddress);
            this.Controls.Add(this.label_SendXml);
            this.Controls.Add(this.label_MqAddress);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SendXmlMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "发送xml报文到MQ";
            this.groupBox_DataType.ResumeLayout(false);
            this.groupBox_DataType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MqAddress;
        private System.Windows.Forms.Label label_SendXml;
        private System.Windows.Forms.TextBox textBox_MqAddress;
        private System.Windows.Forms.TextBox textBox_SelectXml;
        private System.Windows.Forms.Button button_SelectXml;
        private System.Windows.Forms.Button button_SendXml;
        private System.Windows.Forms.RadioButton radioButton_XML;
        private System.Windows.Forms.RadioButton radioButton_Binary;
        private System.Windows.Forms.RadioButton radioButton_String;
        private System.Windows.Forms.GroupBox groupBox_DataType;
        private System.Windows.Forms.Button button_SenAll;
        private System.Windows.Forms.TextBox textBox_SelectDirec;
        private System.Windows.Forms.Label label1;
    }
}

