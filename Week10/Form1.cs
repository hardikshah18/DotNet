using System.Windows.Forms;

namespace Week10
{
    public partial class Form1 : Form
    {

        public List<Inventory> inventory = new List<Inventory>();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadInventory()
        {
            inventory = InventoryDB.GetItems();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            listBoxInventory.Items.Clear();
            foreach (var item in inventory)
            {
                listBoxInventory.Items.Add( item.ItemNo + " | " + 
                    item.Description + " | " + item.Price ); // Display the 'Description' property in ListBox
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddItem addItemForm = new AddItem();

            if (addItemForm.ShowDialog() == DialogResult.OK)
            {
                inventory.Add(addItemForm.newItem);
                InventoryDB.SaveItems(inventory);
                UpdateListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxInventory.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?",
                    "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    int selectedIndex = listBoxInventory.SelectedIndex;
                    inventory.RemoveAt(selectedIndex);
                    InventoryDB.SaveItems(inventory);
                    UpdateListBox();

                }
            }
        }

        private void listBoxInventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
