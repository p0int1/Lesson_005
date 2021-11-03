using System;

namespace Task_4
{
    class Store
    {
        private Article[] article;

        public Store(int size)
        {
            article = new Article[size];
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < article.Length)
                    return article[index].GetInfo();
                return "Попытка обращения за пределы массива.";
            }
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                    if (article[i].Name == index)
                        return article[i].GetInfo();
                return "Товара " + index + " нет в наличии.";
            }
        }

        public void NewArticle(Article value, int index)
        {
            if (index >= 0 && index < article.Length)
                article[index] = value;
            else
                Console.WriteLine("Попытка записи за пределами массива.");
        }

    }
}
