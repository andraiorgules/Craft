using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROGCRAFT_Demo
{
    public class Recipe : Item
    {
        public List<Item> RecipeItems { get; set; }

        public List<Recipe> Recipes = new List<Recipe>()
        {
            new Recipe() // makes 1 cup 
            {
                Name = "Chamomile Tea",
                RecipeItems = new List<Item>()
                {
                    new Item()
                    {
                        Ingredient = Water,
                        Amount = 1,
                        AmountType = "cup"
                    },

                    new Item()
                    {
                        Ingredient = Chamomile,
                        Amount = 1,
                        AmountType = "tsp"
                    }
                }
            },

            new Recipe() //makes 2 cups
            {
                Name = "Sleeping Potion",
                RecipeItems = new List<Item>()
                {
                    new Item()
                    {
                        Ingredient = ChamomileTea,
                        Amount = 1,
                        AmountType = "cup"
                    },

                    new Item()
                    {
                        Ingredient = Ashwagandha,
                        Amount = 1/2,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = DriedLavender,
                        Amount = 1/2,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = LemonBalm,
                        Amount = 1/2,
                        AmountType = "tsp"
                    },
                }



            },

            new Recipe() //makes 2 cups
            {
                Name = "Defense Potion",
                 RecipeItems = new List<Item>()
                {
                    new Item()
                    {
                        Ingredient = BlackPepper,
                        Amount = 1/2,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = Garlic,
                        Amount = 4,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = RedPepperFlakes,
                        Amount = 3,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = HotSauce,
                        Amount = 1,
                        AmountType = "cup"
                    },
                }

            },

            new Recipe() //makes 1 cup
            {
                 Name = "Love Potion",
                 RecipeItems = new List<Item>()
                {
                    new Item()
                    {
                        Ingredient = RosePetals,
                        Amount = 1,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = Honey,
                        Amount = 1,
                        AmountType = "cup"
                    },
                }
            },

            new Recipe() //makes 1 cup
            {
                 Name = "Shapeshifting Potion",
                 RecipeItems = new List<Item>()
                {
                    new Item()
                    {
                        Ingredient = Lotus,
                        Amount = 2,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = GamerTears,
                        Amount = 1,
                        AmountType = "cup"
                    },

                    new Item()
                    {
                        Ingredient = Toadstool,
                        Amount = 1,
                        AmountType = "tsp"
                    },

                    new Item()
                    {
                        Ingredient = Seaweed,
                        Amount = 1,
                        AmountType = "tsp"
                    },
                }
            },


        };

        //General algorithm to create an item from a recipe
        //how can we have one method that will take multiple inputs and return one or more outputs
        //how can we track the specific formula/recipe for each items we want to create
      

        //For reference, 48 teaspoons = 1 cup.
        //if recipe requires 1/2 tsp of something your player has 2 cups of, how will you do the conversion so that the correct amount is subtracted?
    }
}