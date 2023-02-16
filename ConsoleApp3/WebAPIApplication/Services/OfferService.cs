using WebAPIApplication.Model;

namespace WebAPIApplication.Services
{
    public class OfferService
    {
        private List<Product> _inventory;
        private List<Product> InventoryCreation()
        {
            List<Product> inventory = new List<Product>();
            Product product = new Product("P1","P1 Desc",1000);
            inventory.Add(product);
            product = new Product("P2", "P2 Desc", 200);
            inventory.Add(product);
            product = new Product("P3", "P3 Desc", 400);
            inventory.Add(product);
            product = new Product("P4", "P4 Desc", 700);
            inventory.Add(product);
            product = new Product("P5", "P5 Desc", 600);
            inventory.Add(product);
            product = new Product("P6", "P6 Desc", 800);
            inventory.Add(product);
            return inventory;  
        }
        public OfferService()
        {
            _inventory = InventoryCreation();
        }   
        public Task<List<Product>> GetAllProductsAsync()
        {            
            return Task.Run(()=> _inventory);
        }
        public  Task<List<Offer>> GetTodaysOffersAsync()
        {
            return Task.Run(() => getOffers());           
            
        }

        private List<Offer> getOffers()
        {
            List<Offer> todaysOffers = new List<Offer>();
            Offer offer = new Offer("Combo1", _inventory.OrderBy(x => Guid.NewGuid()).Take(3).ToList());
            todaysOffers.Add(offer);
            offer = new Offer("Combo2", _inventory.OrderBy(x => Guid.NewGuid()).Take(3).ToList());
            todaysOffers.Add(offer);
            offer = new Offer("Combo3", _inventory.OrderBy(x => Guid.NewGuid()).Take(3).ToList());
            todaysOffers.Add(offer);
            offer = new Offer("Combo4", _inventory.OrderBy(x => Guid.NewGuid()).Take(3).ToList());
            todaysOffers.Add(offer);
            return todaysOffers;
        }
    }
}
