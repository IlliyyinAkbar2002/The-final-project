namespace Windows_Form_Project.Forms
{
    partial class SearchUserForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonEditSelected = new System.Windows.Forms.Button();
            this.buttonEditSelected.Location = new System.Drawing.Point(20, 320);
            this.buttonEditSelected.Name = "buttonEditSelected";
            this.buttonEditSelected.Size = new System.Drawing.Size(120, 25);
            this.buttonEditSelected.Text = "Edit Selected";
            this.buttonEditSelected.UseVisualStyleBackColor = true;
            this.buttonEditSelected.Click += new System.EventHandler(this.buttonEditSelected_Click);
            this.Controls.Add(this.buttonEditSelected);

            dataGridViewUsers = new DataGridView();
            textBoxSearch = new TextBox();
            comboBoxSearchBy = new ComboBox();
            buttonSearch = new Button();
            labelSearchBy = new Label();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(20, 60);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(650, 250);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellContentClick += this.dataGridViewUsers_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(240, 20);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(200, 23);
            textBoxSearch.TabIndex = 1;
            // 
            // comboBoxSearchBy
            // 
            comboBoxSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSearchBy.FormattingEnabled = true;
            comboBoxSearchBy.Items.AddRange(new object[] { "Username", "Nama", "NIK", "RT", "RW" });
            comboBoxSearchBy.Location = new Point(100, 20);
            comboBoxSearchBy.Name = "comboBoxSearchBy";
            comboBoxSearchBy.Size = new Size(120, 23);
            comboBoxSearchBy.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(460, 19);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(80, 25);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // labelSearchBy
            // 
            labelSearchBy.AutoSize = true;
            labelSearchBy.Location = new Point(20, 24);
            labelSearchBy.Name = "labelSearchBy";
            labelSearchBy.Size = new Size(61, 15);
            labelSearchBy.TabIndex = 4;
            labelSearchBy.Text = "Search by:";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(600, 320);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(70, 25);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // SearchUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 360);
            Controls.Add(buttonBack);
            Controls.Add(labelSearchBy);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxSearchBy);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridViewUsers);
            Name = "SearchUserForm";
            Text = "Search User";
            Load += SearchUser_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearchBy;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEditSelected;

    }
}
