using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PROGCRAFT_Demo.Utility;
using static PROGCRAFT_Demo.Person;

namespace PROGCRAFT_Demo
{
    public class NPC 
    {
        public string Name;
        public string Profession;


        public List<Item> Store = new List<Item>()
        {
            //items are added from the external "store" file
            //code for it is in game class because it is used for the specific Trader NPC created there
        };

        public void Sell(Person player)
        {
            Print("What would you like to buy?");
            Print($"Funds: {player.Wallet}");
            string choice = Console.ReadLine();

            try
            {
                //if the player types something not on the list
            }
            catch
            {
                //notify them that the item is not on the list
                //direct them to the purchase screen again
            }

            try
            {
                //if the player does not have enough money to purchase the item
            }
            catch
            {
                //notify them that they don't have enough money
                //direct them to the purchase screen again
            }

            choice = choice.ToLower();
            player.InventoryAdd(choice);
            //add code to remove purchased item from NPC/store inventory

            float price = DeterminePrice(choice);
            player.Wallet -= price;
           
            Print($"Funds: {player.Wallet}");
        }

        public float DeterminePrice(string item) 
        {
            if (item == "seaweed")
            {
                return 1.13f;
            }

            if (item == "dried lavender")
            {
                return 1.01f;
            }

            if(item == "chamomile")
            {
                return 1.00f;
            }

            if(item == "toadstool")
            {
                return 1.12f;
            }

            if(item == "rose petals")
            {
                return 1.08f;
            }

            if(item == "lotus")
            {
                return 1.10f;
            }

            if(item == "gamer tears")
            {
                return 1.11f;
            }

            if (item == "honey")
            {
                return 1.09f;
            }

            if (item == "hot sauce")
            {
                return 1.08f;
            }

            if (item == "red pepper flakes")
            {
                return 1.07f;
            }

            if (item == "garlic")
            {
                return 1.06f;
            }

            if (item == "black pepper")
            {
                return 1.05f;
            }

            if (item == "lemon balm")
            {
                return 1.03f;
            }

            if (item == "ashwagandha")
            {
                return 1.02f;
            }

            if (item == "water")
            {
                return 1.04f;
            }

            return 0;
        }
    }
}
