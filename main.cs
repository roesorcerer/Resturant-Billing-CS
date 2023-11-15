using System;

namespace Mod4Lab2
{
    struct menuItemType//struct defined
    {
        public string menuItem;//struct components
        public double menuPrice;
    };
    class BobRestaurant//Main class for Bobs Restaurant
    {
        static void getData(menuItemType[] menuList)//function to get data
        {
            //string array for item names
            string[] lunch_item_names = {
                "Ham and Cheese Sandwich", "Tuna Sandwich",
                "Soup of the Day", "Baked Potato", "Salad",
                "Chips", "French Fries", "Bowl of Fruit"
                    };
            //string for price of items
            double[] lunch_item_price = {5.00, 6.00, 2.50,
            3.00, 4.75, 2.00, 1.75, 2.50};
            for (int i = 0; i < 8; i++)
            {
                //Assign corresponding items to the menuItemList
                menuList[i].menuItem = lunch_item_names[i];
                //Assign corresponding item price to the menuItemList
                menuList[i].menuPrice = lunch_item_price[i];
            }
        }
        static void showMenu(menuItemType[] menuList) //showMenu method 
        {
            int i;
            Console.WriteLine("Welcome to Bob's Restaurant Billing System\n");
            for (i = 0; i < 8; i++)
            {
                Console.WriteLine(String.Format("{0,-4} {1,-30} ${2 : 0.00}", (i + 1), menuList[i].menuItem, menuList[i].menuPrice));
            }
        }

        //method to show the check
        static void printCheck(menuItemType[] menuList)
        {
            int opt, j = 0, i, count = 0;
            int[] menu = new int[8];
            double amount = 0, tax;
            int[] qty = new int[8];
            while (true)
            {
                count = count + 1; 
                if (count == 9) 
                    break;
                showMenu(menuList); //display the menu
                Console.WriteLine("Enter your Choice or press 0 to end input\n");
                opt = Convert.ToInt32(Console.ReadLine()); //read the choice of user

                if (opt == 0)
                    break;
                //check the validity of the option
                if (opt >= 1 && opt <= 8)
                {
                    Console.WriteLine("Enter amount you would like to purchase:\n");
                    qty[j] = Convert.ToInt32(Console.ReadLine()); //ask for quantity

                    menu[j] = opt - 1; //store the index of option into menu array

                    amount = amount + qty[j] * menuList[opt - 1].menuPrice; //update the amount
                    j = j + 1;
                }
                else
                    Console.WriteLine("Invalid Menu Item");
            }
            //display the details
            Console.WriteLine("Your Order Details:\n");
            Console.WriteLine("ITEM\t\t\t\tPRICE QUANTITY\n");
            for (i = 0; i < j; i++)
                Console.WriteLine(String.Format("{0,-30} ${1,3} {2,3}", menuList[menu[i]].menuItem, menuList[menu[i]].menuPrice, qty[i]));
            tax = amount * 0.05; //compute the tax
            Console.WriteLine("Tax : $" + "{0:0.00}", tax);
            amount = amount + tax; //update the amount
            Console.WriteLine("Total Amount to Pay $" + "{0:0.00}", amount);
        }
        static void Main(string[] args)
        {
            //declare array of menuItemType
            menuItemType[] menuList = new menuItemType[8];
            //call to methods
            getData(menuList);
            printCheck(menuList);
        }
    }
}
