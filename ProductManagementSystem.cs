using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Annotation_Practice
{
    internal class ProductManagementSystem
    {
        [Required(ErrorMessage ="The Product name is requires")]
        [StringLength(50, MinimumLength =10, ErrorMessage ="The Product lengtn should be between 10 to 50")]
        public string ProductName { get; set; }
        [Required(ErrorMessage="Product price is required")]
        [Range(5, 15, ErrorMessage ="The product price between 5$ to 15$")]
        public int ProductPrice { get; set; }
        [Required(ErrorMessage ="The product quantity is requred")]
        [Range(50, 1000, ErrorMessage="The quantity of product should be betweem 50 to 1000")]
        public int ProductQuantity { get; set; }

    }
}
