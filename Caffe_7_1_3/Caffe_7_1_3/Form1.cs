using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;



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

namespace Caffe_7_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //make instance of the database to use tables

            db_classesDataContext db = new db_classesDataContext();

            //create a list of food

            var ProdsInStore = from p in db.StoreItems
                              where p.ItemType == "Food"
                               select p.ItemName;
            var FoodPrice = from p in db.StoreItems
                              where p.ItemType == "Food"
                               select p.ItemPrice;

            
            foreach (string ffood in ProdsInStore){
                foreach (decimal fdec in FoodPrice){
            List<Food> prods = new List<Food>()
                            {

                 new Food (){ItemName = ffood, price = fdec}};
                };
                
            
           // comboBoxFood.Items.Add(ffood);
                comboBoxAllItems.Items.Add(ffood);
            }



            //create a list of beverages

            var Bevs = from a in db.StoreItems
                       where a.ItemType == "Beverages"
                       select a.ItemName;
               var BevsPrice = from a in db.StoreItems
                       where a.ItemType == "Beverages"
                       select a.ItemPrice;
            foreach (string bbevs in Bevs)
            {          foreach (decimal dec in BevsPrice){
                List<Beverages> prods = new List<Beverages>()
                {

                 new Beverages (){ItemName = bbevs, price = dec}};
                };
                //comboBoxBev.Items.Add(bbevs);
                comboBoxAllItems.Items.Add(bbevs);
            }

            //create a list of giftcards

            var Gift = from b in db.StoreItems
                       where b.ItemType == "GiftCard"
                       select b.ItemName;
            var GiftPrice = from b in db.StoreItems
                            where b.ItemType == "GiftCard"
                            select b.ItemPrice;
            foreach (string ggift in Gift)
            {foreach(decimal gdec in GiftPrice ){
                List<GiftCards> prods = new List<GiftCards>(){
                new GiftCards(){ItemName = ggift, price =gdec }
                };
            };
                
                //comboBoxGiftCard.Items.Add(ggift);
            comboBoxAllItems.Items.Add(ggift);
            }

          

        }


        public class Beverages:IISellableItem {

            public decimal price { get; set; }

         public string ItemName { get; set; }

        }

        public class Food:IISellableItem
        {

            public decimal price { get; set; }

            public string ItemName { get; set; }

        }

        public class GiftCards: IISellableItem
        {

            public decimal price { get; set; }

            public string ItemName { get; set; }

        }

          public class PriceCheck: IISellableItem
        {

            public decimal price { get; set; }

            public string ItemName { get; set; }

        }



        interface IISellableItem
        {
            decimal price { get; set; }
            string ItemName { get; set; }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radioButtonCredit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonPriceCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string allItems = comboBoxAllItems.SelectedItem.ToString();

            db_classesDataContext db = new db_classesDataContext();



            var allPricess = from b in db.StoreItems
                             where b.ItemName == allItems
                             select b.ItemPrice;
            foreach (decimal gdec in allPricess)
            {
                List<PriceCheck> prods = new List<PriceCheck>(){
                new PriceCheck(){price =gdec }
                };

                decimal pricess = gdec;//allPricess.ToString();

                progressBar1.Value = 0;
                for (int i = 99; i < 100; i ++)
                {
                    int b = 100 - i;
                    MessageBox.Show("Please press the key enter "+ b +" time(s) to scann the item") ;
                    progressBar1.Value = i;
                    if(i > 100 ){
                        break;

                    }
                    
                    //i += 2;

                }
                

                if (radioButtonBuy.Checked && allItems != null)
                {

                    MessageBox.Show("You Scanned Item " + allItems + " for purchase");
                }


                if (radioButtonCredit.Checked && allItems != null)
                {

                    MessageBox.Show("You Scanned Item " + allItems + " for refound or credit of "+ pricess + " dollars(s)");

                }
                if (radioButtonPriceCheck.Checked && allItems != null) { MessageBox.Show("You Scanned Item " + allItems + " to check the price. The price is " + pricess + " dollar(s)"); }

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
       

    }
}
