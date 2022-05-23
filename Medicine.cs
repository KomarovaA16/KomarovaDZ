    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace задание11
    {

        public class Stuff
        {

            public readonly string ItemNumber; // артикул
            public string ProductName; // наименование
            public string Prise; // цена товара

            public string NumberOfGoods; // Количество товара на складе
            public readonly Prescription Type;

            public Stuff(string item, string product, string prise, string numb, Prescription type)
            {
                ItemNumber = item;
                ProductName = product;
                Prise = prise;
                Type = type;
                NumberOfGoods = numb;
            }



            public override string ToString()
            {
                return $"{ProductName} {ItemNumber}";
            }
            public void PrintInfo()
            {
                Console.WriteLine(this);

                var type = "";
                switch (Type)
                {
                    case Prescription.underRecipe:
                        type = "По Рецепту";
                        break;
                    case Prescription.withoutRecipe:
                        type = "Без Рецепта";
                        break;

                }

                Console.WriteLine($"Наименование товара: {ProductName}. Артикул: {ItemNumber}. Количество Товара{NumberOfGoods}{type}" +
                $" \nЦена Товара: {Prise}");
            }

        }
    }
