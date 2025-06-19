namespace Windows_Form_Project.Forms
{
    partial class LandingPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPageForm));
            loginButton = new Button();
            registerButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 15F);
            loginButton.ImageAlign = ContentAlignment.TopCenter;
            loginButton.Location = new Point(12, 58);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(98, 40);
            loginButton.TabIndex = 0;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // registerButton
            // 
            registerButton.Font = new Font("Segoe UI", 15F);
            registerButton.Location = new Point(12, 115);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(98, 41);
            registerButton.TabIndex = 1;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveBorder;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 37);
            label1.TabIndex = 2;
            label1.Text = "Selamat Datang di Lapor Desa";
            // 
            // LandingPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(547, 338);
            Controls.Add(label1);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Name = "LandingPageForm";
            Text = "Home";
            Load += LandingPageForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private Button registerButton;
        private Label label1;
    }
}