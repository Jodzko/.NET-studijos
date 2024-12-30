using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Org.BouncyCastle.Math;
using Projektas_Restoranas;
using System.IO;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace testing_restaurant
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {           
        }

        [Test]
        public void Test1()
        {
            int expected = 47;
            int actual = Reader.SerialNumberGetter(Order.SerialNumberPath);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test2()
        {
            string[] expected =
            {

                "1 Coffee-(Black) - 2.50",
                "2 Latte - 3.75",
                "3 Cappuccino - 3.50",
                "4 Espresso - 2.00",
                "5 Americano - 2.80",
                "6 Mocha - 4.00",
                "7 Iced-Coffee - 3.25",
                "8 Hot-Chocolate - 3.00",
                "9 Green-Tea - 2.20",
                "10 Herbal-Tea - 2.50",
                "11 Fruit-Smoothie - 4.50",
                "12 Lemonade - 2.75"
            };
            string[] actual = PrintingService.ShowDrinkMenu(Order.drinksMenuPath);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test3()
        {
            string[] expected =
            {
                "1 Cheeseburger - 8.50",
                "2 Veggie-Burger - 7.75",
                "3 Grilled-Chicken-Sandwich - 9.00",
                "4 Margherita-Pizza - 10.25",
                "5 Pepperoni-Pizza - 11.00",
                "6 Caesar-Salad - 6.50",
                "7 Greek-Salad - 7.00",
                "8 Fish&Chips - 12.00",
                "9 Chicken-Tenders-(4-pieces) - 7.25",
                "10 Pasta-Alfredo - 11.50",
                "11 Vegetable-Stir-Fry - 8.75",
                "12 Fries-(Large) - 4.00",
            };
            string[] actual = PrintingService.ShowFoodMenu(Order.foodMenuPath);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test4()
        {
            var newTable = new Table(11, 10);
            Table.ListOfTables.Add(newTable);
            var expected = newTable;
            var actual = OperationConsole.FindTable(11);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test5()
        {
            var newTable = new Table(11, 10);
            Table.ListOfTables.Add(OperationConsole.FindTable(11));
            var newOrder = new Order(newTable);
            Order.ListOfActiveOrders.Add(newOrder);
            var expected = newOrder;
            var actual = OrderOperations.FindOrder(11, out bool breaking);
            Assert.AreEqual(expected, actual);
        }
    }
}