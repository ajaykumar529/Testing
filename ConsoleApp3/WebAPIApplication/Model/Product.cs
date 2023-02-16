using System.ComponentModel.DataAnnotations;

namespace WebAPIApplication.Model
{
    public class Product
    {
        
        private string _ProductName;
        private string _ProductDescription;
        
        private decimal _ProductPrice;    
        

        public Product(string productName, string productDescription, decimal productPrice)
        {
           
            _ProductName = productName;
            _ProductDescription = productDescription;
            _ProductPrice = productPrice;   
        }
    }
}
