using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HotelReservations.Models;
using HotelReservations.Dao;

namespace HotelReservations.Controllers
{
    [Route("/")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelDao hotelDao;
        private IReservationDao reservationDao;

        public HotelsController()
        {
            hotelDao = new HotelFakeDao();
            reservationDao = new ReservationFakeDao();
        }

        [HttpGet("hotels")]
        public List<Hotel> ListHotels()
        {
            return hotelDao.List();
        }

        [HttpGet("hotels/{id}")]
        public Hotel GetHotel(int id)
        {
            Hotel hotel = hotelDao.Get(id);

            if (hotel != null)
            {
                return hotel;
            }

            return null;
        }
        [HttpGet("hotels/{hotelId}/reservations")]
        public List<Reservation> GetReservations(int hotelId)
        {
            return reservationDao.FindByHotel(hotelId);
        }
        [HttpGet("reservations")]
        public List<Reservation> GetReservations()
        {
            return reservationDao.List();
        }

        [HttpPost("reservations")]
        public ActionResult<Reservation> CreateReservation(Reservation newReservation)
        {
            Reservation res = reservationDao.Create(newReservation);
            return Created($"/reservations/{res.Id}", res);
        }

        [HttpPut("reservations/{resId}")]
        public ActionResult<Reservation> UpdateReservation(int resId, Reservation updatedReservation)
        { 
            //Make sure the Id's match
            if(resId != updatedReservation.Id)
            {
                return UnprocessableEntity();
            }

            updatedReservation = reservationDao.Update(updatedReservation);
            return Ok(updatedReservation);
        }

        [HttpDelete("reservations/{resId}")]
        public ActionResult DeleteReservation(int resId)
        {
            if(reservationDao.Delete(resId))
            {
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }




    }
}
