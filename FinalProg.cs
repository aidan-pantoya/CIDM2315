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
        int occur = 1;
        int login = 0;
        while (login == 0)
        {
            Console.WriteLine("Please Input Username:");
            string user = Console.ReadLine();
            if (user == "Alice")
            {
                login = 1;
                occur = 1;
            }
            else
            {
                Console.WriteLine("Invalid Username Provided\n");
                occur++;
            }
        }
        int secure = 3;
        while (login == 1)
        {
            if (secure < 3 && secure > 0)
            {
                Console.WriteLine("NOTICE: You have " + secure + " more attempts to login.");
            }
            if (secure == 0) { Console.WriteLine("Login attempted too many times. System Locked Down"); 
            return; }
            Console.WriteLine("Please Insert Password:");
            string pass = Console.ReadLine();
            if (pass == "123")
            {
                login++;
            }
            else
            {
                Console.WriteLine("Incorrect Password");
                secure--;
                occur++;
            }
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

        Console.WriteLine("** Hello Cashier: Alice **\n*******************************\nPlease select:\n");
        Console.WriteLine("1. Start New Order\n2. Check Submitted Orders\n3. Remove Finished Orders\n4. Log Out\n*************************\n\nUser Input:");
        int see = 0;
        int inp = 0;

        while (inp == 0)
        {
            string input = Console.ReadLine();
            if (input == "1")
            {
                inp++; 
                createOrder();
            }
            else if (input == "2")
            {
                inp++; 
                vOrders();
            }
            else if (input == "3")
            {
                inp++; 
                orderHistory();
            }
            else if (input == "4")
            {
                inp++; 
                LogOut();
            }
            else
            {
                Console.WriteLine("Invalid Input");
                see++;
            }
        }
    }
    customer hold = null;
    void createOrder()
    {
        Console.WriteLine("***************\nBuff Kitchen\nHello Cashier: Alice\n***************");

        customer cus = new customer();
        string cusName;

        if (hold == null)
        {
            Console.WriteLine("--> Input Customer Name:");
            cusName = Console.ReadLine();
            cus.name = cusName;
            hold = cus;
        }
        else { cus = hold; cusName = hold.name; }

        Console.WriteLine("****Order For: " + cusName + "*****");
        Console.WriteLine("Order Summary:\n");
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
        fOrder.Clear();
        string toal = cus.total.ToString("0.00");

        Console.WriteLine("\n----Order Total: $" + cus.total+"----");
        Console.WriteLine("\n1. Add Entree\n2. Add Side\n3. Add Drink");
        Console.WriteLine("\n4. Complete Order\n5. Exit Order\n");
        Console.WriteLine("User Input:");

        string input = Console.ReadLine();

        if (input == "1")
        {
            addEntree();
        }
        else if (input == "2")
        {
            addSide();
        }
        else if (input == "3")
        {
            addDrink();
        }
        else if (input == "4")
        {

            completeOrder();
        }
        else if (input == "5")
        {
            exitOrder();
        }
        else
        {
        }
    }

    void addEntree()
    {
        Console.WriteLine("***************\nBuff Kitchen\nHello Cashier: Alice\n**********************\n");
        Console.WriteLine("****Order For: " + hold.name + "*****\n");
        Console.WriteLine("Add Entrees to Order\n********************\n");
        foreach (food f in Fentree)
        {
            int num = Fentree.IndexOf(f) + 1;
            Console.WriteLine($"{num}. Food: {f.name} \tPrice: {f.price}");
        }
        Console.WriteLine("\nUser Input:");
        string sel = Console.ReadLine();
        int ind = Int32.Parse(sel); ind--;
        hold.entree.Add(Fentree[ind]); fOrder.Add(Fentree[ind]); createOrder();
    }

    void addSide()
    {
        Console.WriteLine("**********************\nBuff Kitchen\nHello Cashier: Alice\n***********************\n");
        Console.WriteLine("****Order For: " + hold.name + "*****\n");
        Console.WriteLine("Add Sides to Order\n*************************\n");
        foreach (food f in Fside)
        {
            int num = Fside.IndexOf(f) + 1;
            Console.WriteLine($"{num}. Food: {f.name} \tPrice: {f.price}");
        }
        Console.WriteLine("\nUser Input:");
        string sel = Console.ReadLine();
        int ind = Int32.Parse(sel); ind--;
        hold.side.Add(Fside[ind]); fOrder.Add(Fside[ind]); createOrder();
    }

    void addDrink()
    {
        Console.WriteLine("*****************\nBuff Kitchen\nHello Cashier: Alice\n******************\n");
        Console.WriteLine("****Order For: " + hold.name + "*****\n");
        Console.WriteLine("Add Drinks to Order\n*****************\n");
        foreach (food f in Fdrink)
        {
            int num = Fdrink.IndexOf(f) + 1;
            Console.WriteLine($"{num}. Drink: {f.name} \tPrice: {f.price}");
        }
        Console.WriteLine("\nUser Input:");
        string sel = Console.ReadLine();
        int ind = Int32.Parse(sel); ind--;
        hold.drink.Add(Fdrink[ind]); fOrder.Add(Fdrink[ind]); createOrder();
    }

    void completeOrder()
    {
        Console.WriteLine("Are you sure you want to complete the order? y/n");
        string input = Console.ReadLine();
        if (input == "y")
        {
            curOrder.Add(hold); hold = null; homeSys();
        }
        else { createOrder(); }

    }

    void exitOrder()
    {
        Console.WriteLine("Are you sure you want to exit the order? The order will not be saved. y/n");
        string input = Console.ReadLine();
        if (input == "y")
        {
            hold = null; homeSys();
        }
        else { createOrder(); }
    }

    void vOrders()
    {
        Console.WriteLine("*****************\nBuff Kitchen\nHello Cashier: Alice\n******************\n");
        if (curOrder.Count == 0)
        {
            Console.WriteLine("No Current Orders in System == 'Exit' to return");
            Console.WriteLine("\nUser Input: ");
            string ex = Console.ReadLine();
            if (ex == "Exit") { homeSys(); }
        }

        foreach (customer c in curOrder)
        {
            Console.WriteLine("Order " + (curOrder.IndexOf(c) + 1));
            Console.WriteLine("Customer: " + c.name);
            Console.Write("Entrees: ");
            foreach (food e in c.entree) { Console.Write(e.name + ", "); }
            Console.Write("\nSides: ");
            foreach (food s in c.side) { Console.Write(s.name + ", "); }
            Console.Write("\nDrinks: ");
            foreach (food d in c.drink) { Console.Write(d.name + ", "); }
            Console.WriteLine("\n----Order Total: $" + c.total + "----\n");
        }
        Console.WriteLine("\n************************\n");
        Console.WriteLine("1. Finish Order\n2. Cancel Order\n3. Return to Menu");
        Console.WriteLine("\nUser Input: ");
        string ord = Console.ReadLine();

        if (ord == "1")
        {
            Console.WriteLine("Which order would you like to complete?");
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
        else if (ord == "2")
        {
            Console.WriteLine("Which order would you like to cancel?");
            string com = Console.ReadLine();
            Console.WriteLine($"Are you sure you want to cancel order {com}? y/n");
            string ans = Console.ReadLine();
            if (ans == "y")
            {
                int sel = Int32.Parse(com);
                sel--;
                int completed = 0;
                foreach (customer c in curOrder)
                {
                    if (sel == curOrder.IndexOf(c)) { completed++; 
                    curOrder.Remove(c); 
                    hisOrder.Add(c); 
                    c.state = "Cancelled"; 
                    vOrders(); }
                }
                if (completed == 0) { vOrders(); }
            }
            else { vOrders(); }
        }
        else if (ord == "3")
        {
            homeSys();
        }
        else
        {
            vOrders();
        }
    }

    void orderHistory()
    {
        Console.WriteLine("*****************\nBuff Kitchen\nHello Cashier: Alice\n******************\n");
        if (hisOrder.Count == 0)
        {
            Console.WriteLine("No Order History in System == 'Exit' to return");
            Console.WriteLine("\nUser Input: ");
            string ex = Console.ReadLine();
            if (ex == "Exit") { homeSys(); }
        }

        foreach (customer c in hisOrder)
        {
            Console.WriteLine($"Order === {c.state}");
            Console.WriteLine("  Customer: " + c.name);
            Console.Write("  Entrees: ");
            foreach (food e in c.entree) { Console.Write(e.name + ", "); }
            Console.Write("\n  Sides: ");
            foreach (food s in c.side) { Console.Write(s.name +", "); }
            Console.Write("\n  Drinks: ");
            foreach (food d in c.drink) { Console.Write(d.name + ", "); }
            Console.WriteLine("\n----Order Total: $" + c.total + "----\n");
        }
        Console.WriteLine("\n************************\n");
        Console.WriteLine("1. Return to Menu");
        Console.WriteLine("\nUser Input: ");
        string ord = Console.ReadLine();
        if (ord == "1") { homeSys(); }
        else { orderHistory(); }
    }

    void LogOut()
    {
        Console.WriteLine("*********\nBuff Kitchen\n*********\n\nUser (Alice) Logged Out\n\n*Press any key to return*");
        Console.ReadLine();
        Main();
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