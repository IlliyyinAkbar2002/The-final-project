namespace Windows_Form_Project.Forms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            namaTextBox = new TextBox();
            nikTextBox = new TextBox();
            rtTextBox = new TextBox();
            rwTextBox = new TextBox();
            registerButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(140, 30);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.PlaceholderText = "Username";
            usernameTextBox.Size = new Size(200, 23);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(140, 65);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.Size = new Size(200, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // namaTextBox
            // 
            namaTextBox.Location = new Point(140, 100);
            namaTextBox.Name = "namaTextBox";
            namaTextBox.PlaceholderText = "Nama Lengkap";
            namaTextBox.Size = new Size(200, 23);
            namaTextBox.TabIndex = 2;
            // 
            // nikTextBox
            // 
            nikTextBox.Location = new Point(140, 135);
            nikTextBox.Name = "nikTextBox";
            nikTextBox.PlaceholderText = "NIK (16 digit)";
            nikTextBox.Size = new Size(200, 23);
            nikTextBox.TabIndex = 3;
            // 
            // rtTextBox
            // 
            rtTextBox.Location = new Point(140, 170);
            rtTextBox.Name = "rtTextBox";
            rtTextBox.PlaceholderText = "RT";
            rtTextBox.Size = new Size(90, 23);
            rtTextBox.TabIndex = 4;
            // 
            // rwTextBox
            // 
            rwTextBox.Location = new Point(250, 170);
            rwTextBox.Name = "rwTextBox";
            rwTextBox.PlaceholderText = "RW";
            rwTextBox.Size = new Size(90, 23);
            rwTextBox.TabIndex = 5;
            // 
            // registerButton
            // 
            registerButton.Location = new Point(140, 210);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(90, 30);
            registerButton.TabIndex = 6;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(250, 210);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 30);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 270);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(namaTextBox);
            Controls.Add(nikTextBox);
            Controls.Add(rtTextBox);
            Controls.Add(rwTextBox);
            Controls.Add(registerButton);
            Controls.Add(cancelButton);
            Name = "RegisterForm";
            Text = "Form Pendaftaran";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private TextBox namaTextBox;
        private TextBox nikTextBox;
        private TextBox rtTextBox;
        private TextBox rwTextBox;
        private Button registerButton;
        private Button cancelButton;
    }
}
