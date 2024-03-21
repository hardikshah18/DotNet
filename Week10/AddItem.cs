using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10
{
    public partial class AddItem : Form
    {
        public Inventory newItem { get; private set; }

        public AddItem()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtboxItemNo.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxDescription.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxPrice.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                 newItem = new Inventory
                {
                    ItemNo = int.Parse(txtboxItemNo.Text),
                    Description = txtBoxDescription.Text,
                    Price = double.Parse(txtBoxPrice.Text)
                };
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }
    }
}
