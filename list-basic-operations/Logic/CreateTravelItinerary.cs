using System;
using System.Collections.Generic;
using System.Text;
using list_basic_operations.DTO;
using list_basic_operations.DAO;

namespace list_basic_operations.Logic
{
    class CreateTravelItinerary
    {
        public List<Dto_TravelItinerary> CreateTravelItineraries()
        {
            List<int> code_airline = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7
            };

            List<string> airline = new List<string>()
            {
                "Viva Air Colombia", "Avianca", "LATAM Airlines", "Easyfly", 
                "Viva Air Colombia", "Copa Airlines", "Avianca"
            };

            List<string> checkin = new List<string>()
            {
                "2021/03/10", "2021/03/11", "2021/03/12", "2021/03/13", 
                "2021/03/14", "2021/03/15", "2021/03/16"
            };

            List<string> checkout = new List<string>()
            {
                "2021/03/11", "2021/03/12", "2021/03/13",
                "2021/03/14", "2021/03/15", "2021/03/16", "2021/03/17"
            };

            List<string> origin = new List<string>()
            {
                "PEI", "BOG", "BOG", "MIA", "CUN", "GER", "MDE"
            };

            List<string> destination = new List<string>()
            {
                "BOG", "MDE", "MIA", "PTY", "MIA", "NYC", "BOG"
            };

            Dao_TravelItinerary Obj_dao_TravelItinerary = new Dao_TravelItinerary();
            List<Dto_TravelItinerary> list_TravelItineraries = Obj_dao_TravelItinerary.CreateTravelItinerary(code_airline, 
                airline, checkin, checkout, origin, destination);

            return list_TravelItineraries;
        }
    }
}
