namespace Week10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnExit = new Button();
            btnDelete = new Button();
            btnAddItem = new Button();
            listBoxInventory = new ListBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(642, 244);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(642, 151);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(642, 65);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(94, 29);
            btnAddItem.TabIndex = 9;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // listBoxInventory
            // 
            listBoxInventory.FormattingEnabled = true;
            listBoxInventory.Location = new Point(42, 65);
            listBoxInventory.Name = "listBoxInventory";
            listBoxInventory.Size = new Size(480, 224);
            listBoxInventory.TabIndex = 8;
            listBoxInventory.SelectedIndexChanged += listBoxInventory_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAddItem);
            Controls.Add(listBoxInventory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnDelete;
        private Button btnAddItem;
        private ListBox listBoxInventory;
    }
}
