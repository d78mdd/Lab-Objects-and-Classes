﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            for (; ; )
            {
                string input = Console.ReadLine().Trim();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ');

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                double itemPrice = double.Parse(tokens[3]);
                double priceForABox = itemQuantity * itemPrice;

                Item item = new Item()
                {
                    Name = itemName,

                    price = itemPrice
                };

                Box box = new Box()
                {
                    SerialNumber = serialNumber,

                    Item = item,

                    ItemQuantity = itemQuantity,

                    PriceForABox = priceForABox
                };

                boxes.Add(box);

            }

            // sort
            for (int i = 0; i < boxes.Count() - 1; i++)
            {
                for (int j = 0; j < boxes.Count() - 1; j++)
                {
                    double leftPrice = boxes.ElementAt(j).PriceForABox;
                    double rightPrice = boxes.ElementAt(j + 1).PriceForABox;

                    // swap
                    if (leftPrice < rightPrice)
                    {
                        Box temp = boxes.ElementAt(j);

                        {
                            Box[] boxesArr = boxes.ToArray();
                            boxesArr[j] = boxes.ElementAt(j + 1);
                            boxes = boxesArr.ToList();
                        }

                        {
                            Box[] boxesArr = boxes.ToArray();
                            boxesArr[j + 1] = temp;
                            boxes = boxesArr.ToList();
                        }
                    }
                }
            }

            // print
            foreach (Box box in boxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:F2}");
            }
        }
    }

    class Item
    {
        public string Name { get; set; }

        public double price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public double PriceForABox { get; set; }
    }
}
