namespace FinalProg;
using System;
using System.Collections.Generic;
// Aidan Pantoya Final Project CIDM 2315
public class customer
{
    public string name;
    public string state;
    public List<food> entree = new List<food>();
    public List<food> drink = new List<food>();
    public List<food> side = new List<food>();
    public float total;
}
public class food
{
    public string name;
    public float price;
}

public class Program
{
    List<customer> newOrder = new List<customer>();
    List<customer> curOrder = new List<customer>();
    List<customer> hisOrder = new List<customer>();
    List<food> Fentree = new List<food>();
    List<food> Fside = new List<food>();
    List<food> Fdrink = new List<food>();
    List<food> fOrder = new List<food>();
    static void Main()
    {
        Program p = new Program();
        int debug = 0;
        if (debug == 1)
        {
            p.homeSys();
        }
        else
        {
            Console.WriteLine("-----CIDM2315 Final Project: Aidan Pantoya-----");
            Console.WriteLine("-----Welcome To Buff Kitchen-----");
            p.userLogin();
        }
    }
    void userLogin()
    {
        
            Console.WriteLine("Please Input Username:");
            string user = Console.ReadLine();
            if (user == "Alice")
            {
            }
            else
            {
                Console.WriteLine("Invalid Username");
                return;
            }
        
            Console.WriteLine("Please Insert Password:");
            string pass = Console.ReadLine();
            if (pass == "123")
            {
                Console.WriteLine("Login Successfully.");
                 Console.WriteLine("** Hello Cashier: Alice **");
            }
            else
            {
                Console.WriteLine("Incorrect Password");
                return;
            }
        
        homeSys();
    }

    int cf = 0;
    void homeSys()
    {

        if (cf == 0)
        {
            createFoods(); cf++;
        }

        Console.WriteLine("*******************************\nPlease select:");
        Console.WriteLine("1. Start New Order\n2. Check Submitted Orders\n3. Remove Finished Orders\n4. Log out system\n*************************");
       
            string input = Console.ReadLine();
            if (input == "1")
            {
                createOrder();
            }
            else if (input == "2")
            { 
                vOrders();
            }
            else if (input == "3")
            { 
                removeOrder();
            }
            else if (input == "4")
            { 
                LogOut();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
    }
    customer hold = null;
    void createOrder()
    {
        customer cus = new customer();
        string cusName;

        if (hold == null)
        {
            Console.WriteLine("-->Customer Name:");
            cusName = Console.ReadLine();
            cus.name = cusName;
            hold = cus;
        }
        else { cus = hold; cusName = hold.name; }

        Console.WriteLine("-->Select Entree:");
        foreach (food f in Fentree)
        {
            int num = Fentree.IndexOf(f) + 1;
            Console.WriteLine($"{num} - Food: {f.name} \tPrice: {f.price}");
        }
        string sel = Console.ReadLine();
        int ind = Int32.Parse(sel); ind--;
        hold.entree.Add(Fentree[ind]); fOrder.Add(Fentree[ind]); 
            Console.WriteLine("-->Select Side:");
        foreach (food f in Fside)
        {
            int num = Fside.IndexOf(f) + 1;
            Console.WriteLine($"{num}. Food: {f.name} \tPrice: {f.price}");
        }
         string se = Console.ReadLine();
        int indd = Int32.Parse(se); indd--;
        hold.side.Add(Fside[indd]); fOrder.Add(Fside[indd]); 
        
        
             Console.WriteLine("-->Select Drink:");
        foreach (food f in Fdrink)
        {
            int num = Fdrink.IndexOf(f) + 1;
            Console.WriteLine($"{num}. Drink: {f.name} \tPrice: {f.price}");
        }
        string sell = Console.ReadLine();
        int inddd = Int32.Parse(sell); inddd--;
        hold.drink.Add(Fdrink[inddd]); fOrder.Add(Fdrink[inddd]); 

         Console.WriteLine("****Order For: " + cusName + "*****");
        Console.WriteLine("-------Order Summary-------");
        if (cus.entree.Count > 0)
        {
            Console.WriteLine("Entrees: ");
            foreach (var c in cus.entree)
            {
                Console.Write(c.name + ", ");
            }
        }
        else { Console.WriteLine("Entrees: None"); }

        if (cus.side.Count > 0)
        {
            Console.WriteLine("\nSides: ");
            foreach (var c in cus.side)
            {
                Console.Write(c.name +", ");
            }
        }
        else { Console.WriteLine("\nSides: None"); }

        if (cus.drink.Count > 0)
        {
            Console.WriteLine("\nDrinks: ");
            foreach (var c in cus.drink)
            {
                Console.Write(c.name +", ");
            }
        }
        else { Console.WriteLine("\nDrinks: None"); }

        foreach (food f in fOrder)
        {
            cus.total = cus.total + f.price;
        }
        string toal = cus.total.ToString("0.00");

        Console.WriteLine("\n----Total: $" + cus.total+"----");
             curOrder.Add(hold); hold = null; homeSys();
            
    }
    void vOrders()
    {
        if (curOrder.Count == 0)
        {
            Console.WriteLine("No Current Orders");
            homeSys(); 
        }
        Console.WriteLine("-----Orders:-----");
        foreach (customer c in curOrder)
        {
            Console.WriteLine("-->" + (curOrder.IndexOf(c) + 1) + "- Customer: " + c.name + "\tTotal: $" + c.total);
        }
        Console.WriteLine("------------------");
        homeSys();
    }

    void removeOrder()
    {
        if (curOrder.Count == 0)
        {
            Console.WriteLine("No Current Orders");
            homeSys(); 
        }
        Console.WriteLine("-----Orders:-----");
        foreach (customer c in curOrder)
        {
            Console.WriteLine("-->" + (curOrder.IndexOf(c) + 1) + "- Customer: " + c.name + "\tTotal: $" + c.total);
        }
        Console.WriteLine("------------------");
         Console.WriteLine("----Input order ID to remove a finished order:----");
            string com = Console.ReadLine();
            int sel = Int32.Parse(com);
            sel--;
            int completed = 0;
            foreach (customer c in curOrder)
            {
                if (sel == curOrder.IndexOf(c)) { completed++; 
                curOrder.Remove(c); 
                hisOrder.Add(c); 
                c.state = "Finished"; 
                vOrders(); }
            }
            if (completed == 0) { vOrders(); }
    }

    void LogOut()
    {
        Console.WriteLine("Log out system");
        return;
    }

    void createFoods()
    {
        food chiksan = new food();
        chiksan.name = "Chicken Sandwich";
        chiksan.price = 5.99f;
        Fentree.Add(chiksan);
        food chiknug = new food();
        chiknug.name = "Chicken Nuggets";
        chiknug.price = 8.99f;
        Fentree.Add(chiknug);
        food chikstr = new food();
        chikstr.name = "Chicken Strips";
        chikstr.price = 9.99f;
        Fentree.Add(chikstr);
        food beefbur = new food();
        beefbur.name = "Beef Burger";
        beefbur.price = 6.99f;
        Fentree.Add(beefbur);

        food potfri = new food();
        potfri.name = "Potato Fries";
        potfri.price = 3.99f;
        Fside.Add(potfri);
        food salad = new food();
        salad.name = "Salad";
        salad.price = 4.99f;
        Fside.Add(salad);
        food frucup = new food();
        frucup.name = "Fruit Cup";
        frucup.price = 9.99f;
        Fside.Add(frucup);
        food potchip = new food();
        potchip.name = "Potato Chips";
        potchip.price = 2.99f;
        Fside.Add(potchip);

        food icetea = new food();
        icetea.name = "Iced Tea";
        icetea.price = 2.99f;
        Fdrink.Add(icetea);
        food soda = new food();
        soda.name = "Soda";
        soda.price = 1.99f;
        Fdrink.Add(soda);
        food lemon = new food();
        lemon.name = "Lemonade";
        lemon.price = 2.99f;
        Fdrink.Add(lemon);
        food coff = new food();
        coff.name = "Coffee";
        coff.price = 3.99f;
        Fdrink.Add(coff);
    }
}