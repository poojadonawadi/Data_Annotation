using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotation_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("------Data Annotation------");
            //Console.WriteLine("Enter the name:");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter the age:");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the email:");
            //string email = Console.ReadLine();

            //var userDetails = new UserDetails
            //{
            //    Name = name,
            //    Age = age,
            //    Email = email
            //};

            //var context = new ValidationContext(userDetails);
            //var results = new List<ValidationResult>();
            //var isValid = Validator.TryValidateObject(userDetails, context, results, true);

            //if (isValid)
            //{
            //    Console.WriteLine("user data is valid");
            //    Console.WriteLine($"Name: {userDetails.Name}, Age: {age}, Email: {email}");
            //}
            //else
            //{
            //    Console.WriteLine("Validation Errors");
            //    foreach (var error in results)
            //    {
            //        Console.WriteLine($"{error.ErrorMessage}");
            //    }
            //}

            //Console.WriteLine("------------------------------------------");
            
            
            Console.WriteLine("----Product Management Details-----");
            Console.WriteLine("Enter the Product name");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter the Price of the product");
            int productPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product quantity");
            int quantity = int.Parse(Console.ReadLine());

            var productDetails = new ProductManagementSystem
            {
                ProductName = productName,
                ProductPrice = productPrice,
                ProductQuantity = quantity
            };

            var context = new ValidationContext(productDetails);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(productDetails, context, results, true);

            if (isValid)
            {
                Console.WriteLine("Product data is valid");
                Console.WriteLine($"ProductName:{productName}, Price: {productPrice}$, Quantity: {quantity}");
            }
            else
            {
                Console.WriteLine("Data is invalid");
                foreach(var error in  results)
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }                
        }
    }
}
