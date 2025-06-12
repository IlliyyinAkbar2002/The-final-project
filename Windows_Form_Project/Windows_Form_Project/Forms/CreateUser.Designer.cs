namespace Windows_Form_Project.Forms
{
    partial class CreateUser
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
            button1 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(63, 402);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 31;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(171, 337);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(172, 27);
            textBox7.TabIndex = 30;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(171, 299);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(172, 27);
            textBox6.TabIndex = 29;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(171, 258);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 27);
            textBox5.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(171, 161);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 27);
            textBox3.TabIndex = 26;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(171, 114);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 25;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(171, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 337);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 23;
            label8.Text = "RW";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 299);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 22;
            label7.Text = "RT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 258);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 21;
            label6.Text = "NIK";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 212);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 20;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 168);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 19;
            label4.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 121);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 18;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 73);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // button2
            // 
            button2.Location = new Point(202, 402);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 32;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 20);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 33;
            label1.Text = "Create User";

            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(173, 213);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(72, 24);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Active";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
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
            Name = "CreateUser";
            Text = "CreateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label label1;
        private CheckBox checkBox1;
    }
}