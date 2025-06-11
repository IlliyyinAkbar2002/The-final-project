using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Windows_Form_Project.Forms
{
    public partial class SelectStatusForm : Form
    {
        public string SelectedStatus { get; private set; }

        public SelectStatusForm(string[] options)
        {
            InitializeComponent();

            comboBoxStatus.Items.AddRange(options);
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.SelectedIndex = 0; // default selection
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SelectedStatus = comboBoxStatus.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
