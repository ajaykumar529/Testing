using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIApplication.Services;

namespace WebAPIApplication.Controllers
{
    [ApiController]
    [Route("[Offer]")]
    public class OfferAPIController : Controller
    {
        iOfferService _iOfferService;
        OfferAPIController(iOfferService iOfferService)
        {
            _iOfferService = iOfferService;
        }

        // GET: GetTodayOffers
        [HttpGet]
        public async Task<ActionResult> getTodayOffers()
        {
            var Offers=await _iOfferService.GetTodaysOffersAsync();
            return Ok(Offers);
        }

        // GET: GetAllProducts with Filter
        [HttpGet]
        public async Task<ActionResult> getAllProducts()
        {
            var products = await _iOfferService.GetAllProductsAsync();
            return Ok(products);
        }

        // GET: OfferAPIController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OfferAPIController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OfferAPIController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OfferAPIController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OfferAPIController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OfferAPIController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OfferAPIController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
