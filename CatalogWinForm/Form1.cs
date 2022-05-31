namespace CatalogWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form.product);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void editProduct_Click(object sender, EventArgs e)
        {
            var form = new Form2((Props)listBox1.SelectedItem);
            if (form.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items[listBox1.SelectedIndex] = form.product;
            }
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}