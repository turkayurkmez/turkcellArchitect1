// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Bir nesne, gelişime AÇIK değişime KAPALI olmalıdır.

OrderManagement orderManagement = new OrderManagement
{
    Customer = new Customer { Name = "Türkay", Cart = new Premium() }
};

var discounted = orderManagement.GetDiscountedPrice(1000);
Console.WriteLine(discounted);

public abstract class Carts
{
    public abstract decimal GetDiscountedPrice(decimal price);


}
public class Standard : Carts
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .95m;
    }
}

public class Silver : Carts
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .90m;
    }
}

public class Gold : Carts
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .85m;
    }
}

public class Premium : Carts
{
    public override decimal GetDiscountedPrice(decimal price)
    {
        return price * .75m;
    }
}
public class Customer
{
    public string Name { get; set; }
    public Carts Cart { get; set; }
}
public class OrderManagement
{
    public Customer Customer { get; set; }
    public decimal GetDiscountedPrice(decimal price)
    {
        return Customer.Cart.GetDiscountedPrice(price);

        //switch (Customer.Cart)
        //{
        //    case Carts.Standard:
        //        return price * 0.95m;
        //    case Carts.Silver:
        //        return price * 0.90m;
        //    case Carts.Gold:
        //        return price * 0.85m;
        //    case Carts.Premium:
        //        return price * 0.80m;
        //    default:
        //        return price;
        //}

    }
}