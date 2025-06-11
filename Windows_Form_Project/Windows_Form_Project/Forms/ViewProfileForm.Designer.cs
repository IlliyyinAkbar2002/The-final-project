namespace Windows_Form_Project.Forms
{
    partial class ViewProfileForm
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
            buttonUpdate = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            comboBoxRole = new ComboBox();
            SuspendLayout();
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(220, 300);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(120, 30);
            buttonUpdate.TabIndex = 0;
            buttonUpdate.Text = "Update Profile";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 60);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 96);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 131);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 164);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 4;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 199);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 5;
            label6.Text = "NIK";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(46, 230);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 6;
            label7.Text = "RT";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 258);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 7;
            label8.Text = "RW";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 58);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(143, 23);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 91);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(143, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(140, 126);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(143, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(140, 199);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(143, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(140, 230);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(143, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(140, 258);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(143, 23);
            textBox7.TabIndex = 14;
            // 
            // button1
            // 
            button1.Location = new Point(46, 307);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 15;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(338, 16);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 0;
            label1.Text = "My Profile";
            label1.Click += label1_Click;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Location = new Point(140, 164);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(143, 23);
            comboBoxRole.TabIndex = 11;
            // 
            // ViewProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 338);
            Controls.Add(buttonUpdate);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(comboBoxRole);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewProfileForm";
            Text = "ViewProfile";
            Load += ViewProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBoxRole;

        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label label1;
        private System.Windows.Forms.Button buttonUpdate;

    }
}