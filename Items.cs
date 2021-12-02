using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.IO;
using System.Text;

namespace SpaceGame
{
    class Items
    {
        /** 
         * Constructor for Items class
         * Params:
         *  denotation {string} denotation of item (***name)
         *  price {string} price of the item
         * Returns: 
         *  None
         */
        public Items(string denotation="Template", string price="Template")
        {
            this.Denotation = denotation;
            this.Price = price;
        }
        
        // Price Property to get and set price
        public string Price { get; set; }
        // Property to check whether planet has Crystal man
        public string Denotation { get; set; }

        enum Products: int{
            // Planet1 products
            Rawhide = 1, ThickHide = 2, IronHide = 3, LayeredLeather = 4, InfusedLeather = 5,
            // Planet2 products
            // sell planet 1 core items +1g of base price
            Hemp = 3, Silkweed = 4, Wireweave = 5, Sateen = 7, InfusedSilk = 9, Rawhide_2 = 1, ThickHide_2 = 3, IronHide_2 = 4, LayeredLeather_2 = 5, InfusedLeather_2 = 6,
            // Planet3 products
            // sell planet 1 core items +1g of base price; + sell planet 2 core items +1g of base price
            IronOre = 6, SilverOre = 7, GoldOre = 8, StarmetalOre = 12, OrichalcumOre = 15, Hemp_3 = 3, Silkweed_3 = 4, Wireweave_3 = 5, Sateen_3 = 7, InfusedSilk_3 = 9,
            // Planet4 products
            //sell planet 1 core items +10g of base price;
            Rawhide_4 = 11, ThickHide_4 = 12, IronHide_4 = 13, LayeredLeather_4 = 14, InfusedLeather_4 = 15, 
            // sell planet 2 core items +20g of base price;
            Hemp_4 = 23, Silkweed_4 = 24, Wireweave_4 = 25, Sateen_4 = 27, InfusedSilk_4 = 29,
            // sell planet 3 core items +45g of base price.
            IronOre_4 = 51, SilverOre_4 = 52, GoldOre_4 = 53, StarmetalOre_4 = 57, OrichalcumOre_4 = 60,
            // Planet 5
            // sell crystal 
            Crystal = 250

        }
        // List of the products and prices for the planet
        public List<string> productList = new List<string>();
    }

    // Class that makes up the galaxy for the current Game
    class Products
    {
        /**
         * Constructor for the Items class
         * Params:
         *  filaPath {string} the path to the file that holds the info for the planets
         */
        public Products(string filePath)
        {
            Items_Creation tools = new Items_Creation();
            List<Dictionary<string,string>> planetsList = tools.ReadXMLFile(filePath, "Item");
            foreach (Dictionary<string, string> item in productList)
            {
                this.productsInTradingPost.Add(item["denotation"], new Items(item["denotation"], item["price"]));
            }
        }
        // List of planets in the Galaxy
        public Dictionary<string, Items> productsInTradingPost = new Dictionary<string, Items>();
        // Property to show which planet the player is on currently
        public string CurrentPlanet { get; set; }
    }
}
