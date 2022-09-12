namespace SingleResponsibility
{
    public class ProductBusiness
    {
        public int AddProduct(string name, decimal price)
        {
            var connectionString = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";

            var commandText = "INSERT into Products (ProductName,UnitPrice) values (@name,@price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            var affectedRows = new DbHelper(connectionString).ExecuteCommand(commandText, parameters);




            return affectedRows;
        }
    }
}
