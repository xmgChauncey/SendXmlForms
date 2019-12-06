using System;
using System.Configuration;
using System.Messaging;
using System.Windows.Forms;
using System.Xml;

namespace SendXmlForms
{
    public partial class SendXmlMainForm : Form
    {
        public SendXmlMainForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            string mqAddress= ConfigurationManager.AppSettings["MqAddress"].ToString();
            this.textBox_MqAddress.Text = mqAddress;
            this.textBox_MqAddress.Refresh();
        }
        private void button_SendXml_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBox_MqAddress.Text))
            {
                MessageBox.Show("请填写MQ消息队列地址！");
                return;
            }

            if(string.IsNullOrEmpty(this.textBox_SelectXml.Text))
            {
                MessageBox.Show("请选择发送的XML文件！");
                return;
            }

            if(!this.radioButton_XML.Checked && !this.radioButton_Binary.Checked && !this.radioButton_String.Checked)
            {
                MessageBox.Show("请选择发送到消息队列的数据格式！");
                return;
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(this.textBox_SelectXml.Text.Trim());

            MessageQueue queue=new MessageQueue(this.textBox_MqAddress.Text.Trim());
            System.Messaging.Message message = new System.Messaging.Message();
            MessageQueueTransaction mqTransaction = new MessageQueueTransaction();

            if(this.radioButton_XML.Checked)
            {
                message.Body = xmlDocument;
                message.Formatter = new XmlMessageFormatter();
            }
            else if(this.radioButton_String.Checked)
            {
                message.Body = xmlDocument.OuterXml;
                message.Formatter = new XmlMessageFormatter(new Type[] { typeof(string)});
            }
            else
            {
                message.Body = xmlDocument.OuterXml;
                message.Formatter = new BinaryMessageFormatter();
            }

            try
            {
                
                message.Label = System.IO.Path.GetFileName(this.textBox_SelectXml.Text.Trim());
                mqTransaction.Begin();
                queue.Send(message, mqTransaction);
                mqTransaction.Commit();

                MessageBox.Show("报文发送成功");
            }
            catch (Exception ex)
            {
                mqTransaction.Abort();
                MessageBox.Show("XML报文发送失败");
            }

        }

        private void button_SelectXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";//注意这里写路径时要用c:\\而不是c:\
            openFileDialog.Filter = "XML文件|*.xml|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                if(!string.IsNullOrEmpty(fileName))
                {
                    this.textBox_SelectXml.Text = fileName;
                    this.textBox_SelectXml.Refresh();
                }
            }
        }
    }
}
