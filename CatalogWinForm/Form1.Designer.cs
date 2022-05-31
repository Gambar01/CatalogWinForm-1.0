namespace CatalogWinForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addProduct = new System.Windows.Forms.Button();
            this.editProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.clearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(371, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(12, 412);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(371, 23);
            this.addProduct.TabIndex = 1;
            this.addProduct.Text = "Add Product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.button1_Click);
            // 
            // editProduct
            // 
            this.editProduct.Location = new System.Drawing.Point(12, 441);
            this.editProduct.Name = "editProduct";
            this.editProduct.Size = new System.Drawing.Size(371, 23);
            this.editProduct.TabIndex = 2;
            this.editProduct.Text = "Edit Product";
            this.editProduct.UseVisualStyleBackColor = true;
            this.editProduct.Click += new System.EventHandler(this.editProduct_Click);
            // 
            // removeProduct
            // 
            this.removeProduct.Location = new System.Drawing.Point(12, 470);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(371, 23);
            this.removeProduct.TabIndex = 3;
            this.removeProduct.Text = "Remove Product";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(12, 499);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(371, 23);
            this.clearList.TabIndex = 4;
            this.clearList.Text = "Clear List";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 540);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.editProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox listBox1;
        private Button addProduct;
        private Button editProduct;
        private Button removeProduct;
        private Button clearList;
    }
}