using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class ProductManager
    {   
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +"Sepetinize Eklendi!");
        }

        public void Update(Product product) //void; void metodu,
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }
       
       
    }
}
