namespace Week10
{
    partial class AddItem
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
            btnCancel = new Button();
            btnSave = new Button();
            txtBoxPrice = new TextBox();
            txtBoxDescription = new TextBox();
            txtboxItemNo = new TextBox();
            lblPrice = new Label();
            lblDescription = new Label();
            lblItemNo = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(360, 289);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(208, 289);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxPrice
            // 
            txtBoxPrice.Location = new Point(267, 208);
            txtBoxPrice.Name = "txtBoxPrice";
            txtBoxPrice.Size = new Size(125, 27);
            txtBoxPrice.TabIndex = 13;
            // 
            // txtBoxDescription
            // 
            txtBoxDescription.Location = new Point(267, 139);
            txtBoxDescription.Name = "txtBoxDescription";
            txtBoxDescription.Size = new Size(187, 27);
            txtBoxDescription.TabIndex = 12;
            // 
            // txtboxItemNo
            // 
            txtboxItemNo.Location = new Point(267, 70);
            txtboxItemNo.Name = "txtboxItemNo";
            txtboxItemNo.Size = new Size(125, 27);
            txtboxItemNo.TabIndex = 11;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(145, 215);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 20);
            lblPrice.TabIndex = 10;
            lblPrice.Text = "Price:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(145, 142);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 9;
            lblDescription.Text = "Description:";
            // 
            // lblItemNo
            // 
            lblItemNo.AutoSize = true;
            lblItemNo.Location = new Point(145, 77);
            lblItemNo.Name = "lblItemNo";
            lblItemNo.Size = new Size(66, 20);
            lblItemNo.TabIndex = 8;
            lblItemNo.Text = "Item No:";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtBoxPrice);
            Controls.Add(txtBoxDescription);
            Controls.Add(txtboxItemNo);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblItemNo);
            Name = "AddItem";
            Text = "AddItem";
            Load += AddItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtBoxPrice;
        private TextBox txtBoxDescription;
        private TextBox txtboxItemNo;
        private Label lblPrice;
        private Label lblDescription;
        private Label lblItemNo;
    }
}