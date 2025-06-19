namespace Windows_Form_Project.Forms
{
    partial class PostDetailDialog
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostDetailDialog));
            textBoxDetails = new TextBox();
            buttonClose = new Button();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // textBoxDetails
            // 
            textBoxDetails.Location = new Point(12, 12);
            textBoxDetails.Multiline = true;
            textBoxDetails.Name = "textBoxDetails";
            textBoxDetails.ReadOnly = true;
            textBoxDetails.ScrollBars = ScrollBars.Vertical;
            textBoxDetails.Size = new Size(460, 240);
            textBoxDetails.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(397, 260);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 35);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.Location = new Point(12, 260);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(378, 35);
            flowLayoutPanelButtons.TabIndex = 1;
            // 
            // PostDetailDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(484, 311);
            Controls.Add(buttonClose);
            Controls.Add(flowLayoutPanelButtons);
            Controls.Add(textBoxDetails);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PostDetailDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Post Details";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
