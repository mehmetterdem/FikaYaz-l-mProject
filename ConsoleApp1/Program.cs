using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager product = new ProductManager(new EfProductDal());
            product.Add(new Product { Name = "deneme" });
        }
    }
}
