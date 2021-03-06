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

        public AuctionsController(IAuctionDao auctionDao)
        {
            dao = auctionDao;
        }

        [HttpGet]
        public List<Auction> List(string title_like = "", double currentBid_lte = 0)
        {
            if (title_like != "")
            {
                return dao.SearchByTitle(title_like);
            }
            if (currentBid_lte > 0)
            {
                return dao.SearchByPrice(currentBid_lte);
            }

            return dao.List();
        }

        [HttpGet("{id}")]
        public ActionResult<Auction> Get(int id)
        {
            Auction auction = dao.Get(id);
            if (auction != null)
            {
                return Ok(auction);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult<Auction> Create(Auction auction)
        {
            Auction newAuction = dao.Create(auction);
            if(auction != null)
            {
                return Created("auctions", newAuction);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Auction> Update(Auction updatedAuction, int id)
        {
            Auction existingId = dao.Get(id);
           
            if(existingId == null)
            {
                return NotFound("Requested ID does not exist.");
            }
            else
            { 
                Auction auction = dao.Update(id, updatedAuction);
                return Ok(auction);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Auction existingId = dao.Get(id);

            if(existingId == null)
            {
                return NotFound("Requested ID does not exist.");
            }
            dao.Delete(id);
            return NoContent();
        }

    }
}
