

namespace WebAPIApplication.Model
{
    public class Offer
    {
        
        private string _OfferName;
        private List<Product> _Products;
        public Offer( string offerName, List<Product> products)
        {
            
            _OfferName = offerName;
            _Products = products;
        }
    
       
    }
}
