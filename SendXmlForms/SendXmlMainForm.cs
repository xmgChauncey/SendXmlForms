using System;
using System.Configuration;
using System.IO;
using System.Messaging;
using System.Windows.Forms;
using System.Xml;

namespace SendXmlForms
{
    public partial class SendXmlMainForm : Form
    {
        bool IsSendAll;
        public SendXmlMainForm()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            string mqAddress = ConfigurationManager.AppSettings["MqAddress"].ToString();
            this.textBox_MqAddress.Text = mqAddress;
            this.textBox_MqAddress.Refresh();
        }
        private void button_SendXml_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox_MqAddress.Text))
            {
                MessageBox.Show("请填写MQ消息队列地址！");
                return;
            }

            if (!this.radioButton_XML.Checked && !this.radioButton_Binary.Checked && !this.radioButton_String.Checked)
            {
                MessageBox.Show("请选择发送到消息队列的数据格式！");
                return;
            }

            if (IsSendAll)
            {
                if (string.IsNullOrEmpty(this.textBox_SelectDirec.Text))
                {
                    MessageBox.Show("请选择发送目录！");
                    return;
                }
                try
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(this.textBox_SelectDirec.Text);

                    FileInfo[] fileInfos = directoryInfo.GetFiles("*.xml");

                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        SendXmlFileToMsmq(fileInfo.FullName);
                    }
                    MessageBox.Show("报文发送成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("报文发送失败！" + ex.ToString());
                }
            }
            else
            {
                if (string.IsNullOrEmpty(this.textBox_SelectXml.Text))
                {
                    MessageBox.Show("请选择发送的XML文件！");
                    return;
                }

                try
                {
                    SendXmlFileToMsmq(this.textBox_SelectXml.Text);
                    MessageBox.Show("报文发送成功！");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("报文发送失败！" + ex.ToString());
                }
            }

        }

        private void button_SelectXml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML文件|*.xml|所有文件|*.*";
            openFileDialog.RestoreDirectory = false;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    this.textBox_SelectXml.Text = fileName;
                    this.textBox_SelectDirec.Text = string.Empty;
                    this.button_SendXml.Text = "发送报文";

                    IsSendAll = false;
                    this.textBox_SelectDirec.Refresh();
                    this.textBox_SelectXml.Refresh();
                    this.button_SendXml.Refresh();
                }
            }
        }

        private void button_SenAll_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "请选择文件路径";
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox_SelectDirec.Text = folderBrowserDialog.SelectedPath;
                this.textBox_SelectXml.Text = string.Empty;
                this.button_SendXml.Text = "发送全部";

                IsSendAll = true;
                this.textBox_SelectDirec.Refresh();
                this.textBox_SelectXml.Refresh();
                this.button_SendXml.Refresh();
            }
        }

        private void SendXmlFileToMsmq(string fileName)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(fileName);

            MessageQueue queue = new MessageQueue(this.textBox_MqAddress.Text.Trim());
            System.Messaging.Message message = new System.Messaging.Message();
            MessageQueueTransaction mqTransaction = new MessageQueueTransaction();

            if (this.radioButton_XML.Checked)
            {
                message.Body = xmlDocument;
                message.Formatter = new XmlMessageFormatter();
            }
            else if (this.radioButton_String.Checked)
            {
                message.Body = xmlDocument.OuterXml;
                message.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
            }
            else
            {
                message.Body = xmlDocument.OuterXml;
                message.Formatter = new BinaryMessageFormatter();
            }

            try
            {
                message.Label = fileName;
                mqTransaction.Begin();
                queue.Send(message, mqTransaction);
                mqTransaction.Commit();
            }
            catch (Exception ex)
            {
                mqTransaction.Abort();
                throw ex;
            }
        }
    }
}
