# Bob's Restaurant Billing System

## Introduction

This is a simple console application for Bob's Restaurant Billing System, written in C#. It allows you to select items from a menu, specify the quantity you want to order, and then calculates the total cost of your order, including tax.

## Code Overview

The code consists of a C# program with the following main components:

### `menuItemType` Struct

A struct named `menuItemType` is defined to represent menu items. It has two components:
- `menuItem`: A string representing the name of the menu item.
- `menuPrice`: A double representing the price of the menu item.

### `BobRestaurant` Class

The `BobRestaurant` class contains the main logic of the program. Here's an overview of the key methods and functionalities:

#### `getData(menuItemType[] menuList)`

This method initializes the `menuList` array with menu items and their prices. It populates the `menuList` array using predefined arrays for item names and prices.

#### `showMenu(menuItemType[] menuList)`

This method displays the restaurant menu, including item names and prices, in a formatted manner.

#### `printCheck(menuItemType[] menuList)`

This method allows the user to select items from the menu, specify quantities, and calculates the total cost of the order. It also calculates and displays tax on the order.

#### `Main(string[] args)`

The `Main` method is the entry point of the program. It declares an array of `menuItemType`, calls the `getData` method to initialize the menu, and then calls the `printCheck` method to take orders and generate the bill.

## How to Use

To use this program, follow these steps:

1. Compile and run the program using a C# development environment.
2. The program will display the menu with item names and prices.
3. Enter the number corresponding to the item you want to order or enter `0` to finish ordering.
4. If you enter a valid item number, you will be prompted to enter the quantity you want to order.
5. Continue adding items and quantities until you are ready to finish your order by entering `0`.
6. The program will display a summary of your order, including item names, prices, quantities, tax, and the total amount to pay.

## Author

This README file was created by [Rowan Stratton].
