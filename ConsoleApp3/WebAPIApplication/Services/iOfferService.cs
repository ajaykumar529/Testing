using WebAPIApplication.Model;

namespace WebAPIApplication.Services
{
    public interface iOfferService
    {
        Task<List<Product>> GetAllProductsAsync()

        Task<List<Offer>> GetTodaysOffersAsync();
    }
}
