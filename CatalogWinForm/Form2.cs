using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogWinForm
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Props product)
        {
            InitializeComponent();
            productName.Text = product.Name;
            originCountry.Text = product.Country;
            productCost.Text = product.Cost.ToString();
        }
        public Props product = new Props();

        private void form2Ok_Click(object sender, EventArgs e)
        {
            product.Name = productName.Text;
            product.Country = originCountry.Text;
            product.Cost = Convert.ToInt32(productCost.Text);
            DialogResult = DialogResult.OK;
        }

    }
}
