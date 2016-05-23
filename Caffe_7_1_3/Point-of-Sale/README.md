# Point-of-Sale
C# application that models a simple point-of-sale system (otherwise known as the cashier-checkout system).
--Install SQL server first. Before you run the code make sure the data connection is properly set
/*
 8-4 Final: Final Project
Students should complete a program to design a Windows Presentation Foundation (WPF)
 * C# application that models a simple point-of-sale system (otherwise known as the cashier-checkout system).
 * Your project must include the following items: 
 * Your solution must define an interface (called ISellableItem)
   for items that can be sold via a point-of-sale system for a coffee shop. 
   The actual details of the interface are up to you, 
   but you should define appropriate methods that would be commonly 
   implemented by any item that could be "sold."
       
 * Define two or more classes that implement your interface. 
 * Each of these classes needs to represent a specific item in the coffee shop's inventory, 
 * such as 
 * coffee 
 * drinks, 
 * pastries, 
 * mugs, 
 * gift 
 * cards, 
 * -shirts, 
 * coffee makers, etc.

 * Define one main window with the following:

 * One background image with opacity set to 0.1 or 0.2. 
 * (You choose the background image, but make sure it's appropriate and don't use copyrighted images.)

 * A pull-down selector or other suitable user interface control that lets the user select one "ISellableItem"
 * object from a list.
 * All of the choices for the pull-down selector must be read in from a data file. 
 * (This means that whatever is defined in your data file must correspond to one of your defined classes.
 * Use object serialization for this part of the assignment.)
 * 

 * A group of three radio button widgets that lets the user specify a 
 * purchase, 
 * a credit/return, or
 * a price check.
 * 

 * A "scan" button that will simulate scanning the selected item for purchase,
 * credit/return, 
 * or price check 
 * (as selected by the previous radio buttons).
 *

 * An "exit" button that will gracefully exit the application.

 * When the user selects an item, 
 * chooses purchase, 
 * credit/return, or 
 * price check, and 
 * clicks on the "scan" button, 
 * your application must initiate logic that simulates that function. 
 * When finished, your application must signal an event to which your main window will be subscribed. 
 * When that event is signaled, your main window logic should display a simple
 * “MessageBox” indicating which item was scanned and for what reason.

 * Optional Enrichment:
 * Implement a simple SQL database to store your inventory 
 * (instead of just a data file). When the user selects 
 * "Purchase" for an item,
 * decrement the current inventory levels of the selected item. 
 * The current inventory level for each item will be in the database.
 * Once an inventory level reaches zero, remove that item (or grey it out) in the “ComboBox.”  
 * Student must use LINQ to update the SQL database.
 
  For additional details, refer to the Final Project document in the Assignment Guidelines and Rubrics section of the course.
 * 
 */
