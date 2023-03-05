using System;

class Overloading_Activity
{
    static void Main(string[]args)
    {
        int Waterbill, Electricitybill, Gasbill, tuitionfee, Expense_for_food, Car_Gas_Expense, Other_Expense;

        Console.WriteLine("                      ==========================================");
        Console.WriteLine("                      ||            EXPENSES AT HOME          || ");
        Console.WriteLine("                      ==========================================");

        Console.WriteLine("\n\n");

        Console.WriteLine("==========================================");
        Console.WriteLine("||  ENTER WATERBILL NUMBER:               ");
        Console.WriteLine("==========================================");
        Waterbill = Convert.ToInt32(Console.ReadLine());
    

        Console.WriteLine("\n\n");

        Console.WriteLine("==========================================");
        Console.WriteLine("||   ENTER ELECTRICITYBILL NUMBER: ");
        Console.WriteLine("==========================================");
        Electricitybill = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n");

        Console.WriteLine("==========================================");
        Console.WriteLine("||   ENTER GASBILL NUMBER: ");
        Console.WriteLine("==========================================");
        Gasbill = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n");

        Console.WriteLine("==========================================");
        Console.WriteLine("||   ENTER TUITIONFEE NUMBER: ");
        Console.WriteLine("==========================================");
        tuitionfee = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n");

        Console.WriteLine("==========================================");
        Console.WriteLine("||   ENTER FOODEXPENSE NUMBER: ");
        Console.WriteLine("==========================================");
        Expense_for_food = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n");
        Console.WriteLine("==========================================");
        Console.WriteLine("||   ENTER CAR GAS NUMBER: ");
        Console.WriteLine("==========================================");
        Car_Gas_Expense = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n");

        Console.WriteLine("==========================================");
        Console.WriteLine("||   ENTER OTHEREXPENSE NUMBER: ");
        Console.WriteLine("==========================================");
        Other_Expense = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n");

        Console.WriteLine("==========================================");
        Console.WriteLine("||   Waterbill + Electricitybill: ");
        Console.WriteLine("==========================================");
        Console.WriteLine(total_expense(Waterbill, Electricitybill));
        Console.WriteLine("==========================================");
        Console.WriteLine("||   Gasbill + Car_Gas_Expense + Tuitionfee: ");
        Console.WriteLine("==========================================");
        Console.WriteLine(total_expense(Gasbill, Car_Gas_Expense, tuitionfee));
        Console.WriteLine("==========================================");
        Console.WriteLine("||   Food Expense + Other_Expense: ");
        Console.WriteLine("==========================================");
        Console.WriteLine(total_expense(Expense_for_food, Other_Expense));
    }
    static int total_expense(int a, int b)
    {
        return a + b;
    }

    static int total_expense(int a, int b, int c)
    {
        return a + b + c;
    }

    static double total_expense(double a, double b)
    {
        return a + b;
    }
}