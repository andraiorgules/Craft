using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROGCRAFT_Demo
{
    public class Item 
    { 
        public enum Ingredients
        {
            Water,
            Chamomile,
            Ashwagandha,
            DriedLavender,
            LemonBalm,
            BlackPepper,
            Garlic,
            RedPepperFlakes,
            HotSauce,
            RosePetals,
            Honey,
            Lotus,
            GamerTears,
            Toadstool,
            Seaweed
        };

        public int Amount { get; set; }
        public Ingredients Ingredient { get; set; }

        public string Name;
        public string Description;
        public float Price;
        public string AmountType = "cup(s)";

        //For reference, 48 teaspoons = 1 cup.
        //if recipe requires 1/2 tsp of something your player has 2 cups of, how will you do the conversion so that the correct amount is subtracted?


    }
}