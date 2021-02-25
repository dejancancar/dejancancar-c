using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AuctionApp.Models;
using AuctionApp.DAO;

namespace AuctionApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuctionsController : ControllerBase
    {
        private readonly IAuctionDao dao;

        public AuctionsController(IAuctionDao auctionDao = null)
        {
            if (auctionDao == null)
            {
                dao = new AuctionDao();
            }
            else
            {
                dao = auctionDao;
            }
        }
        [HttpGet]
        public List<Auction> GetAuctions(string title_like = "", double currentBid_lte = 0)
        {
            List<Auction> auctions = dao.List();
            if (title_like != "" && currentBid_lte != 0)
            {
                return dao.SearchByTitleAndPrice(title_like, currentBid_lte);
            }
            else if (currentBid_lte != 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }
            else if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            else
            {
            return auctions;
            }


        }

        [HttpGet("{id}")]
        public Auction GetAuctionById(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return auction;
            }
            return null;
        }

        [HttpPost]
        public ActionResult<Auction> CreateAuction(Auction newAuction)
        {
            Auction auction = dao.Create(newAuction);
            return Created($"/auctions/{auction.Id}", auction);
        }


    }
}
