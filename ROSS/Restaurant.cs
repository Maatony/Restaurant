using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROSS
{
    public class Restaurant
    {
        private List<Guest> GuestList { get; set; }
        private int Cash { get; set; }

        public Restaurant()
        {
            GuestList = new List<Guest>();
            Cash = 0;
        }
        public void AddGuest()
        {
            GuestList.Add(new Guest());
            Console.WriteLine($"Guest {GuestList.Count} added");
        }

        public void OrderMeal(int guestNumber, Meal meal)
        {
            if(IsValidGuestNumber(guestNumber))
                GuestList[guestNumber - 1].AddMeal(meal);
        }

        public void OrderMenu(int guestNumber)
        {
            if (IsValidGuestNumber(guestNumber))
                GuestList[guestNumber - 1].AddMenu();
        }

        public void Pay(int guestNumber)
        {
            if (IsValidGuestNumber(guestNumber) && GuestList[guestNumber - 1].GetHunger() >= GuestList[guestNumber - 1].GetSaturation())
            {
                int cashBefore = Cash;
                Cash += GuestList[guestNumber - 1].PayBill();
                Console.WriteLine($"Guest {guestNumber} paid {Cash - cashBefore} and left restaurant.");
                GuestList.RemoveAt(guestNumber-1);
            }
            else
                Console.WriteLine($"Guest {guestNumber} is still hungry.");
        }

        public void CloseBill()
        {
             if (GuestList.Count > 0)
             {
                int actualGuest = 0;
                for (int i = 0; i < GuestList.Count;)
                {
                    int cashBefore = Cash;
                    Cash += GuestList[0].PayBill();
                    Console.WriteLine($"Guest {actualGuest+1} paid {Cash - cashBefore} and left restaurant.");
                    GuestList.RemoveAt(0);
                    actualGuest++;
                }
            }
        }

        private bool IsValidGuestNumber(int guestNumber)
        {
            if (guestNumber - 1 < 0 || guestNumber - 1 > GuestList.Count)
                return false;
            return true;
        }

        public void PrintGuestList()
        {
            if (GuestList.Count > 0)
            {
                for (int i = 0; i < GuestList.Count; i++)
                {
                    Console.WriteLine($"Orders for guest {i + 1}:");
                    Console.WriteLine(GuestList[i].ToString());
                }
            }
            else
                Console.WriteLine("No guest in restaurant yet.");
        }
    }
}