using System.Collections.Generic;

namespace refractor3_demo
{
    public class Store
    {
        private List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public void GetCostOfProducts()
        {
            foreach (var product in _products)
            {
                int numberOfProduct = product.GetQty();
                string productName = product.GetName();
                double cost = product.GetTotalCost();
                double costWithDiscount = product.GetTotalCost() / product.GetQty();
                double costWithoutDiscount = product.GetPrice() + product.GetShippingCost();

                System.Console.WriteLine("Total cost for {0} is {1:N2}", productName, cost);
                System.Console.WriteLine("Cost per product {0:N2}", costWithDiscount);
                System.Console.WriteLine("Savings per product {0:N2}", costWithoutDiscount - costWithDiscount);

                // BAD CODE
                // System.Console.WriteLine("Total cost for {0} is {1:N2}", product.GetName(), product.GetTotalCost());
                // System.Console.WriteLine("Cost per product {0:N2}", product.GetTotalCost() / product.GetQty());
                // System.Console.WriteLine("Savings per product {0:N2}", (product.GetPrice() + product.GetShippingCost()) - (product.GetTotalCost() / product.GetQty()));
                // END BAD CODE
            }
        }
    }
}
