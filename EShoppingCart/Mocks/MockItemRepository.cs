using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppingCart.Interfaces;
using EShoppingCart.Models;

namespace EShoppingCart.Mocks
{
    //the mock will inherit from the interface - IItemRepository
    public class MockItemRepository:IItemRepository
    {
        //Reference the MochCategoryRepository because the items have a property named Category
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        //Get the Items property from IItemRepository as below.
        public IEnumerable<Item> Items
        {
            get
            {
                return new List<Item>
                {
                    new Item {
                        Name = "Beer",
                        Price = 7.95M,
                        ItemDescription = "Beer is the world's oldest[1][2][3] and most widely consumed[4] alcoholic drink; it is the third most popular drink overall, after water and tea.[5] The production of beer is called brewing, which involves the fermentation of starches, mainly derived from cereal grains—most commonly malted barley, although wheat, maize (corn), and rice are widely used.[6] Most beer is flavoured with hops, which add bitterness and act as a natural preservative, though other flavourings such as herbs or fruit may occasionally be included. The fermentation process causes a natural carbonation effect, although this is often removed during processing, and replaced with forced carbonation.[7] Some of humanity's earliest known writings refer to the production and distribution of beer: the Code of Hammurabi included laws regulating beer and beer parlours.",
                        Category = _categoryRepository.Categories.First(),
                        ItemImageUrl = "http://imgh.us/beerL_2.jpg",
                        InStock = true,
                        IsPrefferedItem = true,
                        ItemImageThumbnailUrl = "http://imgh.us/beerS_1.jpeg"
                    },
                    new Item {
                        Name = "Rum & Coke",
                        Price = 12.95M,
                        ItemDescription = "The world's second most popular drink was born in a collision between the United States and Spain. It happened during the Spanish-American War at the turn of the century when Teddy Roosevelt, the Rough Riders, and Americans in large numbers arrived in Cuba. One afternoon, a group of off-duty soldiers from the U.S. Signal Corps were gathered in a bar in Old Havana. Fausto Rodriguez, a young messenger, later recalled that Captain Russell came in and ordered Bacardi (Gold) rum and Coca-Cola on ice with a wedge of lime. The captain drank the concoction with such pleasure that it sparked the interest of the soldiers around him. They had the bartender prepare a round of the captain's drink for them. The Bacardi rum and Coke was an instant hit. As it does to this day, the drink united the crowd in a spirit of fun and good fellowship. When they ordered another round, one soldier suggested that they toast ¡Por Cuba Libre! in celebration of the newly freed Cuba.",
                        Category =  _categoryRepository.Categories.First(),
                        ItemImageUrl = "http://imgh.us/rumCokeL.jpg",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "http://imgh.us/rumAndCokeS.jpg"
                    },
                    new Item {
                        Name = "Tequila ",
                        Price = 12.95M,
                        ItemDescription = "Tequila (Spanish About this sound [teˈkila] (help·info)) is a regionally specific name for a distilled beverage made from the blue agave plant, primarily in the area surrounding the city of Tequila, 65 km (40 mi) northwest of Guadalajara, and in the highlands (Los Altos) of the central western Mexican state of Jalisco. Although tequila is similar to mezcal, modern tequila differs somewhat in the method of its production, in the use of only blue agave plants, as well as in its regional specificity. Tequila is commonly served neat in Mexico and as a shot with salt and lime across the rest of the world.The red volcanic soil in the surrounding region is particularly well suited to the growing of the blue agave, and more than 300 million of the plants are harvested there each year.[1] Agave tequila grows differently depending on the region. Blue agaves grown in the highlands Los Altos region are larger in size and sweeter in aroma and taste. Agaves harvested in the lowlands, on the other hand, have a more herbaceous fragrance and flavor.",
                        Category =  _categoryRepository.Categories.First(),
                        ItemImageUrl = "http://imgh.us/tequilaL.jpg",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "http://imgh.us/tequilaS.jpg"
                    },
                    new Item
                    {
                        Name = "Juice ",
                        Price = 12.95M,
                        ItemDescription = "Naturally contained in fruit or vegetable tissue.",
                        Category = _categoryRepository.Categories.Last(),
                        ItemImageUrl = "http://imgh.us/juiceL.jpg",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "http://imgh.us/juiceS.jpg"
                    }
                };
            }
        }
        //Get the PrefferedItems property from IItemRepository as below.
        public IEnumerable<Item> PreferredItems { get; }
        public Item GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
