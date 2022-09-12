namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            var name = textBoxName.Text;
            var price = Convert.ToDecimal(textBoxPrice.Text);
            var affectedRows = new ProductBusiness().AddProduct(name, price);
            var message = affectedRows > 0 ? "Başarılı" : "Başarısız";
            MessageBox.Show(message);

        }

    }
}