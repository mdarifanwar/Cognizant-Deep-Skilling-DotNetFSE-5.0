namespace KafkaChatWindows
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox lstMessages;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtMessage = new TextBox();
            btnSend = new Button();
            lstMessages = new ListBox();

            SuspendLayout();

            txtMessage.Location = new System.Drawing.Point(20, 20);
            txtMessage.Size = new System.Drawing.Size(250, 30);

            btnSend.Location = new System.Drawing.Point(280, 20);
            btnSend.Size = new System.Drawing.Size(100, 30);
            btnSend.Text = "Send";
            btnSend.Click += btnSend_Click;

            lstMessages.Location = new System.Drawing.Point(20, 70);
            lstMessages.Size = new System.Drawing.Size(360, 220);

            ClientSize = new System.Drawing.Size(410, 320);

            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(lstMessages);

            Text = "Kafka Chat";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}