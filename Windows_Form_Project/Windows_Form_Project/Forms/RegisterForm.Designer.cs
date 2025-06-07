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
            this.usernameTextBox = new TextBox();
            this.passwordTextBox = new TextBox();
            this.namaTextBox = new TextBox();
            this.nikTextBox = new TextBox();
            this.rtTextBox = new TextBox();
            this.rwTextBox = new TextBox();
            this.registerButton = new Button();
            this.cancelButton = new Button();
            this.SuspendLayout();

            // Username TextBox
            usernameTextBox.Location = new Point(140, 30);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(200, 23);
            usernameTextBox.PlaceholderText = "Username";

            // Password TextBox
            passwordTextBox.Location = new Point(140, 65);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(200, 23);
            passwordTextBox.PlaceholderText = "Password";
            passwordTextBox.UseSystemPasswordChar = true;

            // Nama TextBox
            namaTextBox.Location = new Point(140, 100);
            namaTextBox.Name = "namaTextBox";
            namaTextBox.Size = new Size(200, 23);
            namaTextBox.PlaceholderText = "Nama Lengkap";

            // NIK TextBox
            nikTextBox.Location = new Point(140, 135);
            nikTextBox.Name = "nikTextBox";
            nikTextBox.Size = new Size(200, 23);
            nikTextBox.PlaceholderText = "NIK (16 digit)";

            // RT TextBox
            rtTextBox.Location = new Point(140, 170);
            rtTextBox.Name = "rtTextBox";
            rtTextBox.Size = new Size(90, 23);
            rtTextBox.PlaceholderText = "RT";

            // RW TextBox
            rwTextBox.Location = new Point(250, 170);
            rwTextBox.Name = "rwTextBox";
            rwTextBox.Size = new Size(90, 23);
            rwTextBox.PlaceholderText = "RW";

            // Register Button
            registerButton.Location = new Point(140, 210);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(90, 30);
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += new EventHandler(registerButton_Click);

            // Cancel Button
            cancelButton.Location = new Point(250, 210);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 30);
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += new EventHandler(cancelButton_Click);

            // RegisterForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(400, 270);
            this.Controls.Add(usernameTextBox);
            this.Controls.Add(passwordTextBox);
            this.Controls.Add(namaTextBox);
            this.Controls.Add(nikTextBox);
            this.Controls.Add(rtTextBox);
            this.Controls.Add(rwTextBox);
            this.Controls.Add(registerButton);
            this.Controls.Add(cancelButton);
            this.Name = "RegisterForm";
            this.Text = "Form Pendaftaran";
            this.ResumeLayout(false);
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
