using System;
using System.Collections.Generic;
using System.Text;
using list_basic_operations.DTO;

namespace list_basic_operations.DAO
{
    public class Dao_TravelItinerary
    {
        public List<Dto_TravelItinerary> CreateTravelItinerary(List<int> code_airline, List<string> airline, 
            List<string> checkin, List<string> checkout, List<string> origin, List<string> destination)
        {
            List<Dto_TravelItinerary> travelItineraries = new List<Dto_TravelItinerary>();

            for (int i = 0; i < airline.Count; i++)
            {
                travelItineraries.Add(new Dto_TravelItinerary()
                {
                    code_airline = code_airline[i],
                    airline = airline[i],
                    checkin = checkin[i],
                    checkout = checkout[i],
                    origin = origin[i],
                    destination = destination[i]
                });
            }

            return travelItineraries;
        }
    }
}
