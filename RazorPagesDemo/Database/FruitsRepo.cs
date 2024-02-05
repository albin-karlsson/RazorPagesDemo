using RazorPagesDemo.Models;

namespace RazorPagesDemo.Database
{
    public static class FruitsRepo
    {
        public static List<Fruit> Fruits { get; set; } = new List<Fruit>
        {
            new Fruit(1, "Apple", "A red or green fruit that is round and crunchy."),
            new Fruit(2, "Banana", "A long yellow fruit that is soft and sweet."),
            new Fruit(3, "Orange", "A round citrus fruit with a tough skin."),
            new Fruit(4, "Pear", "A green or yellow fruit that is narrow at the stem."),
            new Fruit(5, "Grape", "A small round fruit that grows in clusters."),
            new Fruit(6, "Mango", "A tropical stone fruit that is sweet and juicy."),
            new Fruit(7, "Strawberry", "A red heart-shaped fruit with a sweet flavor."),
            new Fruit(8, "Blueberry", "A small blue fruit that is round and sweet."),
            new Fruit(9, "Pineapple", "A tropical fruit with rough, spiky skin and sweet yellow flesh."),
            new Fruit(10, "Watermelon", "A large fruit with a hard green rind and sweet red flesh."),
            new Fruit(11, "Peach", "A round fruit with fuzzy skin and sweet yellow flesh."),
            new Fruit(12, "Cherry", "A small round fruit with a pit and a sweet flavor.")
        };
    }
}

