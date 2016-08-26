using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductCategory.Models
{
    public class ProductViewModel
    {
        public List<Product> Products { get; set; }
        public List<Category> SearchCategories { get; set; }
        public List<Product> Get()
        {
            List<Product> prds = new List<Product>();
            Product pr = new Product();
            prds.Add(pr);
            pr.ProductId = 1;
            pr.ProductName = "Test";
            pr = new Product();
            prds.Add(pr);
            pr.ProductId = 2;
            pr.ProductName = "Sony";
            pr = new Product();
            prds.Add(pr);
            pr.ProductId = 3;
            pr.ProductName = "Samsung";
            pr = new Product();
            prds.Add(pr);
            pr.ProductId = 2;
            pr.ProductName = "Roku";

            Products = prds;
            return Products;

        }

        public List<Category> LoadSearchCategory()
        {
            List<Category> prds = new List<Category>();
            Category pr = new Category();
            prds.Add(pr);
            pr.CategoryId = 1;
            pr.CategoryName = "Elctronic";
            pr = new Category();
            prds.Add(pr);
            pr.CategoryId = 2;
            pr.CategoryName = "Household";
            pr = new Category();
            prds.Add(pr);
            pr.CategoryId = 3;
            pr.CategoryName = "Electrical";
            pr = new Category();

            prds.Add(pr); 
            pr.CategoryId = 2;
            pr.CategoryName = "Harware";

            SearchCategories = prds;
            return SearchCategories;
        }

    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
      }
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}