using System;
using System.Collections.Generic;
using list_basic_operations.DTO;
using list_basic_operations.Logic;
using list_basic_operations.DAO;

namespace list_basic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTravelItinerary createTravelItinerary = new CreateTravelItinerary();
            List<Dto_TravelItinerary> travelItineraries = createTravelItinerary.CreateTravelItineraries();

            Dao_TravelItineraryNode createTravelItineraryNodes = new Dao_TravelItineraryNode();
            createTravelItineraryNodes.CreateTravelItinerariesNodes(travelItineraries);
        }
    }
}