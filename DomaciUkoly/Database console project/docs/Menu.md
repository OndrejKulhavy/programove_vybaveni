Markdown Documentation for Menu Class
=====================================

The following code defines a `Menu` class that uses the `Spectre.Console` package to display a console-based user interface.

Class `Menu`
------------

### Properties

*   `Database database`: an instance of the `Database` class to interact with the database.
*   `bool run`: a boolean flag that determines whether to keep running the program or not.
*   `public bool Run`: a getter/setter for the `run` property.

### Constructors

*   `Menu(Database database)`: a constructor that sets the `database` property and runs the `MainMenu` method in a loop while the `run` property is true.

### Methods

*   `public void MainMenu()`: displays the main menu and prompts the user to choose a section. Based on the user's input, the method calls the corresponding menu for customers, orders, reports, technicians, vehicles, or exits the program.
*   `public void CustomersMenu()`: displays the customers menu and prompts the user to choose an action. Based on the user's input, the method calls the corresponding method to add, edit, delete, list, or add customers from JSON data, or returns to the main menu.
*   `public void OrdersMenu()`: displays the orders menu and prompts the user to choose an action. Based on the user's input, the method calls the corresponding method to add, edit, delete, or list orders, or returns to the main menu.
*   `public void ReportsMenu()`: displays the reports menu and prompts the user to choose an action. Based on the user's input, the method calls the corresponding method to add, edit, delete, or list reports, or returns to the main menu.
*   `public void TechniciansMenu()`: displays the technicians menu and prompts the user to choose an action. Based on the user's input, the method calls the corresponding method to add, edit, delete, or list technicians, or returns to the main menu.
*   `public void VehiclesMenu()`: displays the vehicles menu and prompts the user to choose an action. Based on the user's input, the method calls the corresponding method to add, edit, delete, or list vehicles, or returns to the main menu.

Usage
-----

To use this `Menu` class, you need to create an instance of the `Database` class and pass it to the `Menu` constructor. The `Menu` class will then display the main menu, and you can navigate through the different sections and perform actions on the database through the console-based user interface.