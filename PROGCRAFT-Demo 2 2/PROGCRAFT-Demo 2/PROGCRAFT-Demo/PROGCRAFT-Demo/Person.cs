using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static PROGCRAFT_Demo.Utility;

namespace PROGCRAFT_Demo
{
    public class Person : IItemContainer
    {
        public string Name;

        public float Wallet;

        public List<Item> Inventory = new List<Item>()
        {
            new Item()
            {
                Name = "Water",
                Amount = 1,
                AmountType = "cup",
                Price = 1.04f,
                Description = "The most abundant resource on Earth."
            },

            new Item()
            {
                Name = "Chamomile",
                Amount = 1,
                AmountType = "tsp",
                Price = 1.00f,
                Description = "Matricaria recutita, dried."
            },

            new Item()
            {
                Name = "Ashwagandha",
                Amount = 1/2,
                AmountType = "tsp",
                Price = 1.02f,
                Description = "Withania somnifera, extract"
            },

            new Item()
            {
                Name = "Dried Lavender",
                Amount = 1/2,
                AmountType = "tsp",
                Price = 1.01f,
                Description = "Lavandula angustifolia, dried"
            },

            new Item()
            {
                Name = "Lemon Balm",
                Amount = 1/2,
                AmountType = "tsp",
                Price = 1.03f,
                Description = "Melissa officinalis, dried"
            },

            new Item()
            {
                Name = "Black Pepper",
                Amount = 1/2,
                AmountType = "tsp",
                Price = 1.05f,
                Description = "Piper nigrum, ground"
            },

            new Item()
            {
                Name = "Garlic",
                Amount = 4,
                AmountType = "tsp",
                Price = 1.06f,
                Description = "Allium sativum, chopped"
            },

            new Item()
            {
                Name = "Red Pepper Flakes",
                Amount = 3,
                AmountType = "tsp",
                Price = 1.07f,
                Description = "Capsicum annuum, dried"
            },

            new Item()
            {
                Name = "Hot Sauce",
                Amount = 1,
                AmountType = "cup",
                Price = 1.08f,
                Description = "Made from Chilli Peppers"
            },

            new Item()
            {
                Name = "Rose Petals",
                Amount = 1,
                AmountType = "tsp",
                Price = 1.08f,
                Description = "Rosa petals, plucked and dried"
            },

            new Item()
            {
                Name = "Honey",
                Amount = 1,
                AmountType = "cup",
                Price = 1.09f,
                Description = "Pure Apis Indica honey"
            },

            new Item()
            {
                Name = "Lotus",
                Amount = 1,
                AmountType = "tsp",
                Price = 1.10f,
                Description = "Nelumbo Nucifera, fresh"
            },

            new Item()
            {
                Name = "Gamer Tears",
                Amount = 1,
                AmountType = "cup",
                Price = 1.11f,
                Description = "Directly from the eyes of gamers."
            },

            new Item()
            {
                Name = "Toadstool",
                Amount = 1,
                AmountType = "tsp",
                Price = 1.12f,
                Description = "Amanita muscaria, chopped and dried"
            },

            new Item()
            {
                Name = "Seaweed",
                Amount = 1,
                AmountType = "tsp",
                Price = 1.13f,
                Description = "Codium fragile, sliced and dried"
            }
        };


        public void InventoryAdd(string item) 
        {
            if (item == "seaweed")
            {
                Item Seaweed = new Item()
                {
                    Name = "Seaweed",
                    Amount = 1,
                    AmountType = "tsp",
                    Price = 1.13f,
                    Description = "Codium fragile, sliced and dried"
                };
                Inventory.Add(Seaweed);
                Print("Seaweed has been added to your Inventory!");
            }

            if (item == "dried lavender")
            {
                Item DriedLavender = new Item()
                {
                    Name = "Dried Lavender",
                    Amount = 1 / 2,
                    AmountType = "tsp",
                    Price = 1.01f,
                    Description = "Lavandula angustifolia, dried"

                };
                Inventory.Add(DriedLavender);
                Print("Dried Lavender has been added to your Inventory!");
            }

            if (item == "chamomile")
            {
                Item Chamomile = new Item()
                {
                    Name = "Chamomile",
                    Amount = 1,
                    AmountType = "tsp",
                    Price = 1.00f,
                    Description = "Matricaria recutita, dried."
                };
                Inventory.Add(Chamomile);
                Print("Chamomile has been added to your Inventory!");
            }

            if (item == "toadstool")
            {
                Item Toadstool = new Item()
                {
                    Name = "Toadstool",
                    Amount = 1,
                    AmountType = "tsp",
                    Price = 1.12f,
                    Description = "Amanita muscaria, chopped and dried"
                };
                Inventory.Add(Toadstool);
                Print("Toadstool has been added to your Inventory!");
            }

            if (item == "rose petals")
            {
                Item RosePetals = new Item()
                {
                    Name = "Rose Petals",
                    Amount = 1,
                    AmountType = "tsp",
                    Price = 1.08f,
                    Description = "Rosa petals, plucked and dried"
                };
                Inventory.Add(RosePetals);
                Print("Rose Petals have been added to your Inventory!");
            }

            if (item == "lotus")
            {
                Item Lotus = new Item()
                {
                    Name = "Lotus",
                    Amount = 1,
                    AmountType = "tsp",
                    Price = 1.10f,
                    Description = "Nelumbo Nucifera, fresh"
                };
                Inventory.Add(Lotus);
                Print("Lotus has been added to your Inventory!");
            }

            if (item == "gamer tears")
            {
                Item GamerTears = new Item()
                {
                    Name = "Gamer Tears",
                    Amount = 1,
                    AmountType = "cup",
                    Price = 1.11f,
                    Description = "Directly from the eyes of gamers."
                };
                Inventory.Add(GamerTears);
                Print("Gamer Tears have been added to your Inventory!");
            }

            if (item == "honey")
            {
                Item Honey = new Item()
                {
                    Name = "Honey",
                    Amount = 1,
                    AmountType = "cup",
                    Price = 1.09f,
                    Description = "Pure Apis Indica honey"
                };
                Inventory.Add(Honey);
                Print("Honey has been added to your Inventory!");
            }

            if (item == "hot sauce")
            {
                Item HotSauce = new Item()
                {
                    Name = "Hot Sauce",
                    Amount = 1,
                    AmountType = "cup",
                    Price = 1.08f,
                    Description = "Made from Chilli Peppers"
                };
                Inventory.Add(HotSauce);
                Print("Hot Sauce has been added to your Inventory!");
            }

            if (item == "red pepper flakes")
            {
                Item RedPepperFlakes = new Item()
                {
                    Name = "Red Pepper Flakes",
                    Amount = 3,
                    AmountType = "tsp",
                    Price = 1.07f,
                    Description = "Capsicum annuum, dried"
                };
                Inventory.Add(RedPepperFlakes);
                Print("Red Pepper Flakes has been added to your Inventory!");
            }

            if (item == "garlic")
            {
                Item Garlic = new Item()
                {
                    Name = "Garlic",
                    Amount = 4,
                    AmountType = "tsp",
                    Price = 1.06f,
                    Description = "Allium sativum, chopped"
                };
                Inventory.Add(Garlic);
                Print("Garlic has been added to your Inventory!");
            }

            if (item == "black pepper")
            {
                Item BlackPepper = new Item()
                {
                    Name = "Black Pepper",
                    Amount = 1 / 2,
                    AmountType = "tsp",
                    Price = 1.05f,
                    Description = "Piper nigrum, ground"
                };
                Inventory.Add(BlackPepper);
                Print("Black Pepper has been added to your Inventory!");
            }

            if (item == "lemon balm")
            {
                Item LemonBalm = new Item()
                {
                    Name = "Lemon Balm",
                    Amount = 1 / 2,
                    AmountType = "tsp",
                    Price = 1.03f,
                    Description = "Melissa officinalis, dried"
                };
                Inventory.Add(LemonBalm);
                Print("Lemon Balm has been added to your Inventory!");
            }

            if (item == "ashwagandha")
            {
                Item Ashwagandha = new Item()
                {
                    Name = "Ashwagandha",
                    Amount = 1 / 2,
                    AmountType = "tsp",
                    Price = 1.02f,
                    Description = "Withania somnifera, extract"
                };
                Inventory.Add(Ashwagandha);
                Print("Ashwagandha has been added to your Inventory!");
            }

            if (item == "water")
            {
                Item Water = new Item()
                {
                    Name = "Water",
                    Amount = 1,
                    AmountType = "cup",
                    Price = 1.04f,
                    Description = "The most abundant resource on Earth."
                };
                Inventory.Add(Water);
                Print("Water has been added to your Inventory!");
            }

            else
            {
                // ask player if they want to enter another option or return to menu  
            }

        }

        public bool CanCraft (IItemContainer itemContainer) 
        {
            //check if can craft that racipe

            foreach (Item item in Inventory)
            {
                if (itemContainer.ItemCount(item) < item.Amount)
                {
                    return false;
                }
            }

            return true; 
        }

        public void Craft(IItemContainer itemContainer) 
        {
            //check which recipe was chosen
            //check if required items are in player's inventory
            //remove required items
            //add new crafted item to inventory

            if (CanCraft(itemContainer))
            {
                foreach (Item item in Inventory)
                {
                    for (int i = 0; i < item.Amount; i++)
                    {
                        itemContainer.RemoveItem(item);
                    }
                }
            }

            if (CanCraft(itemContainer))
            {
                foreach (Item item in Inventory)
                {
                    for (int i = 0; i < item.Amount; i++)
                    {
                        itemContainer.AddItem(item);
                    }
                }
            }

        }
        
        public bool ContainsItem(Item item)
        {
            //checks if item exists in inventory

            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i].Item == item)
                {
                    return true;
                }
            }

            return false;
        }

        public bool RemoveItem(Item item)
        {
            //removes required items from inventory 

            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory.Contains(item))
                {
                    Inventory.Remove(item);
                    return true; 
                }
            }

            return false; 
        }

        public bool AddItem(Item item) 
        {
            //adds crafted item into inventory

            for (int i = 0; i < Inventory.Length; i++)
            {
                //if (Inventory[i].Item == null)
                //{
                //    Inventory[i].Item = item;
                //    return true;
                //}

                if (Inventory.Contains(item = null))
                {
                    Inventory.Add(item);
                    return true;
                }

            }

            return false; 
        }

        public int ItemCount(Item item)
        {
            //checks if inventory has required amount of items to comlete the recipe

            int number = 0;

            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i].Item == item)
                {
                    number++; 
                }
            }

            return number;
        }



        //The Player should be able to sell a completed CraftItem to the Customer if they have one or more completed CraftItems in their Inventory
        //If they don't have any completed CraftItems, the Customer shouldn't give the Player currency.
        //The Customer should have enough currency to buy at least one of each of the CraftItems.

        //The Player should be able to buy Materials from the Supplier if they have enough currency.
        //The Supplier should have a limited amount of Materials. Enough for the Player to make at least one more set of CraftItems,
        //but not an unlimited amount.
        //Each CraftItem should have a price that includes a profit (see the "Value, Profit Margin, and Probability" page). When a CraftItem is crafted
        //there should be a:
        //70% chance that it is a normal value
        //20% chance that it is above average in value
        //10% chance that it is rare in value

    }
}