using System;


namespace ProductIntro 
{

    class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.productName = "Delonghi Kahve Makinesi";
            product1.price = 7899;
            product1.descpription = "Dünyanın en güzel kahvesi için dünyanın en güzel kahve makinesi.";

            Product product2 = new Product();
            product2.productName = "MSI Gaming Laptop";
            product2.price = 35499;
            product2.descpription = "En iyi olmak için en iyisini seçin.";

            Product[] products = {product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine("Ürün Adı : "+product.productName + " -- Ürün Fiyatı : "+ product.price + " -- Ürün Açıklaması : "+ product.descpription);

            }

            Console.WriteLine("-------------------------------");

            CartManager cartManager= new CartManager();
            cartManager.Add(product1);
            cartManager.update(product2);
            cartManager.delete(product1);


        }
    }
}
   

