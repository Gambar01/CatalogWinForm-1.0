namespace CatalogWinForm
{
    partial class Form2
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
            this.productName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.originCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.form2Ok = new System.Windows.Forms.Button();
            this.form2Cancel = new System.Windows.Forms.Button();
            this.productCost = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.Location = new System.Drawing.Point(12, 27);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(368, 23);
            this.productName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origin Country :";
            // 
            // originCountry
            // 
            this.originCountry.Location = new System.Drawing.Point(12, 97);
            this.originCountry.Name = "originCountry";
            this.originCountry.Size = new System.Drawing.Size(368, 23);
            this.originCountry.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Cost :";
            // 
            // form2Ok
            // 
            this.form2Ok.Location = new System.Drawing.Point(12, 224);
            this.form2Ok.Name = "form2Ok";
            this.form2Ok.Size = new System.Drawing.Size(75, 23);
            this.form2Ok.TabIndex = 6;
            this.form2Ok.Text = "OK";
            this.form2Ok.UseVisualStyleBackColor = true;
            this.form2Ok.Click += new System.EventHandler(this.form2Ok_Click);
            // 
            // form2Cancel
            // 
            this.form2Cancel.Location = new System.Drawing.Point(305, 224);
            this.form2Cancel.Name = "form2Cancel";
            this.form2Cancel.Size = new System.Drawing.Size(75, 23);
            this.form2Cancel.TabIndex = 7;
            this.form2Cancel.Text = "Cancel";
            this.form2Cancel.UseVisualStyleBackColor = true;
            // 
            // productCost
            // 
            this.productCost.Location = new System.Drawing.Point(12, 171);
            this.productCost.Mask = "00000";
            this.productCost.Name = "productCost";
            this.productCost.Size = new System.Drawing.Size(368, 23);
            this.productCost.TabIndex = 8;
            this.productCost.ValidatingType = typeof(int);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.form2Cancel;
            this.ClientSize = new System.Drawing.Size(402, 281);
            this.Controls.Add(this.productCost);
            this.Controls.Add(this.form2Cancel);
            this.Controls.Add(this.form2Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.originCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productName);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox productName;
        private Label label1;
        private Label label2;
        private TextBox originCountry;
        private Label label3;
        private Button form2Ok;
        private Button form2Cancel;
        private MaskedTextBox productCost;
    }
}