namespace Task_4
{
    class Article
    {
        public string Name { get; set; }
        public string Shop { get; set; }
        public double Price { get; set; }

        public Article(string name, string shop, double price)
        {
            Name = name;
            Shop = shop;
            Price = price;
        }

        public string GetInfo()
        {
            string info = "Товар " + Name + ", магазин " + Shop + ", цена " + Price;
            return info;
        }

    }
}
