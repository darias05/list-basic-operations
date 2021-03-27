using System;
using System.Collections.Generic;
using System.Text;
using list_basic_operations.DTO;

namespace list_basic_operations.DAO
{
    public class Dao_TravelItineraryNode
    {
        public Dto_TravelItineraryNode Head;
        public Dto_TravelItineraryNode obj_travelItinerary;

        public void CreateTravelItinerariesNodes(List<Dto_TravelItinerary> TravelItineraries)
        {
            Console.WriteLine("¿Que codigo de hotel quieres insertar?");
            int insert = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Despues de que codigo lo quieres hacer?");
            int after = int.Parse(Console.ReadLine());

            for (int i = 0; i < TravelItineraries.Count; i++)
            {
                AddItinireray(TravelItineraries[i], insert, after);
            }

            PrintTravelItinerary();
        }

        public void AddItinireray(Dto_TravelItinerary travelItinerary, int insert, int after)
        {
            Dto_TravelItineraryNode travelItineraryNode = new Dto_TravelItineraryNode();
            travelItineraryNode.travelItinerary = travelItinerary;

            if (insert < after)
            {
                if (travelItinerary.code_airline == insert || travelItinerary.code_airline == after)
                {
                    if (travelItinerary.code_airline == insert)
                    {
                        obj_travelItinerary = travelItineraryNode;
                    }
                    else
                    {
                        if (Head == null)
                        {
                            Head = travelItineraryNode;
                            Dto_TravelItineraryNode last = Head;
                            last.Next = obj_travelItinerary;
                        }
                        else
                        {
                            Dto_TravelItineraryNode last = Head;
                            while (last.Next != null)
                            {
                                last = last.Next;
                            }
                            last.Next = travelItineraryNode;
                            last = last.Next;
                            last.Next = obj_travelItinerary;
                        }
                    }
                }
                else
                {
                    if (Head == null)
                    {
                        Head = travelItineraryNode;
                    }
                    else
                    {
                        Dto_TravelItineraryNode last = Head;
                        while (last.Next != null)
                        {
                            last = last.Next;
                        }
                        last.Next = travelItineraryNode;
                    }
                }
            }
            else
            {
                if (travelItinerary.code_airline == insert)
                {
                    Dto_TravelItineraryNode last = Head;

                    for (int i = 1; i < after; i++)
                    {
                        last = last.Next;
                    }

                    Dto_TravelItineraryNode Next = last.Next;
                    last.Next = travelItineraryNode;
                    last.Next.Next = Next;
                }
                else
                {
                    if (Head == null)
                    {
                        Head = travelItineraryNode;
                    }
                    else
                    {
                        Dto_TravelItineraryNode last = Head;
                        while (last.Next != null)
                        {
                            last = last.Next;
                        }
                        last.Next = travelItineraryNode;
                    }
                }
            }
        }

        public void PrintTravelItinerary()
        {
            Dto_TravelItineraryNode travel = Head;
            while (travel != null)
            {
                Console.WriteLine($"Code airline: {travel.travelItinerary.code_airline} - Airline: {travel.travelItinerary.airline} -" +
                    $" Checkin: {travel.travelItinerary.checkin} - Checkout: {travel.travelItinerary.checkout} -" +
                    $" Origin: {travel.travelItinerary.origin} - Destination: {travel.travelItinerary.destination}");
                travel = travel.Next;
            }
        }
    }
}
