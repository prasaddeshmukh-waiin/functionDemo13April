////------------------  checked even odd number   ---------------------
//Console.Write(" enter no : ");
//int num = int.Parse(Console.ReadLine());

//if (IsoddEven(num))
//{
//    Console.WriteLine("ans :  " + num + " is even number ");
//}
//else
//{
//    Console.WriteLine("ans :  " + num + " is odd number ");

//}


//bool IsoddEven(int no)

//{
//    if (no % 2 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}





//int myFunction(int a,int b)
//{
//    Console.WriteLine("hello");
//    return 0;
//}

//myFunction(1, 7);


//void myfun()
//{
//    return;
//}

//myfun();

//------------------------------------------


//Console.WriteLine("enter no : ");
//int no=int.Parse(Console.ReadLine());

//if (IsPrime(no))
//{
//    Console.WriteLine("prime");
//}
//else
//{
//    Console.WriteLine(" not prime ");
//}

//bool IsPrime(int n)
//{


//    for(int i = 2; i < n; i++)
//    {
//        if (n % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}
//-------------------------- check even or odd -----------------------------------

//for (int i = 1; i <= 100; i++)
//{
//    if (EvenOdd(i))
//        Console.WriteLine(i + " : is even number.");
//    else
//        Console.WriteLine(i + " : is odd number.");


//    bool EvenOdd(int i)
//    {
//        if (i % 2 != 0)
//        {
//            return false;
//        }
//        return true;
//    }
//}
//------------------------------------------------------- - - - - - -




//Console.Write("enter even or odd : ");
//string num = Console.ReadLine();

//if (num == "even")
//{
//    Console.Write("how many want even number : ");
//    int even = int.Parse(Console.ReadLine());
//}
//else
//{
//    Console.Write("how many want odd number : ");
//    int odd = int.Parse(Console.ReadLine());

//}

//for (int i=1; i<100; i++)
//{




//    bool EvenNumber(int even)
//    {
//        if(even%2 == 0)
//        {
//            return true;
//        }
//        return false;
//    }

//}
//==============================================================================================
//-----------------------------------------------------------------------------

//Oraganation org = new Oraganation("prasad", "ngr", 1, 9011410653);
//org.Display();
//org.Update("shubham", "pune");
//org.setValues("raj",2);
//org.Display();


//class Oraganation
//{
//    private string Name;
//    private string Address;
//    private int Id;
//    private long Phone;


//    public void setValues(string name) 
//    {
//        this.Name=name;


//    }

//    public void setValues(string name) 
//    {
//        this.Name=name;


//    }

//    public Oraganation(string Name, string Address, int Id, long Phone)
//    {
//        this.Name = Name;
//        this.Address = Address;
//        this.Id = Id;
//        this.Phone = Phone;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"{Name} , {Address} , {Id} ,{Phone}");
//    }

//    public void Update(string Name, string Address)
//    {
//        this.Name = Name;
//        this.Address = Address;
//    }


//}


////-------------------------  print sum of array --------------------------------------------

//Console.Write("enter row : ");
//int row = int.Parse(Console.ReadLine());

//Console.Write("enter col : ");
//int col = int.Parse(Console.ReadLine());

//int[,] arr = new int[row,col];

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for(int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write("enter array value : ");
//        arr[i,j] = int.Parse(Console.ReadLine());
//    }

//}
//int sum = 0;
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        sum+=arr[i,j];
//    }

//}
//Console.Write("print sum of  the array : "+sum);


//-------------------------------  find gretest array & find prime number  -------------------------------------

//Console.Write("enter row : ");
//int row = int.Parse(Console.ReadLine());

//Console.Write("enter col : ");
//int col = int.Parse(Console.ReadLine());

//int[,] arr = new int[row, col];

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write("enter array value : ");
//        arr[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//int gretestNumber = arr.Cast<int>().Max();
//Console.Write("print array gretest number : " + gretestNumber + "\n");

//int flag = 0;
//for (int i = 2; i < gretestNumber; i++)
//{
//    if (gretestNumber % i == 0)
//    {
//        Console.Write("Number is not Prime.");
//        flag = 1;
//        break;
//    }
//}
//if (flag == 0)
//    Console.Write("Number is Prime.");

//----------------------------------------------------------------------------------------

////////Create Account class as Abstract and override some methods in saving_acoount and current_account class.  
////////A.Display account information  
////////Properties :
////////Account- AccountId , Branch Location , Balance, AccountType 
////////Saving_ account - TypeName , Interest Rate 
////////current_ account - TypeName , Interest Rate 
////////-------------------------------------------------------------------

//account s = new savingaccount(5, "ahmednagar", 5000);
//s.display();
//s.rateofinterest();
//s.display();
//account c = new current_account(10, "pune", 10000);
//c.display();
//c.rateofinterest();
//c.display();

//abstract class account
//{
//    protected int accountid;
//    protected string branch_location;
//    protected int balance;
//    protected string account_type;

//    public abstract void rateofinterest();

//    public void display()
//    {
//        Console.WriteLine(" --------------------------------------------------------------------------------------------");
//        Console.WriteLine($"| account-id: {accountid,3} | branch-location : {branch_location,-10} | balance: {balance,-10} | account-type: {account_type} |");
//    }
//}
//class savingaccount : account
//{
//    int brateofinterest = 5;
//    public savingaccount(int accountid, string branch_location, int balance)
//    {
//        this.accountid = accountid;
//        this.branch_location = branch_location;
//        this.balance = balance;
//        this.account_type = "saving";
//    }
//    public override void rateofinterest()
//    {
//        var interest = balance * brateofinterest / 100;
//        balance = balance + interest;
//    }
//}

//class current_account : account
//{
//    int brateofinterest = 3;
//    public current_account(int accountid, string branch_location, int balance)
//    {
//        this.accountid = accountid;
//        this.branch_location = branch_location;
//        this.balance = balance;
//        this.account_type = "saving";
//    }
//    public override void rateofinterest()
//    {
//        var interest = balance * brateofinterest / 100;
//        balance = balance+ interest;
//    }
//}



////////-------------------------------------------------------------------------------------------------------------------------
//12.Create two class book and library and implement has-a-relationship  between those classes 
//A. Display Books of library  B.library has many books 

//Book add = new Book("history");
//Book add1 = new Book("science");
//Lab a1 = new Lab("global labarary",add);
//Lab a2 = new Lab("global labarary", add1);
//a1.Display();
//a2.Display();

//class Lab
//{
//   public string Name;
//    public Book book;

//    public Lab(string Name,Book add)
//    {
//       this.Name = Name;
//        this.book = add;
//    }

//    public void Display()
//    {
//        Console.WriteLine($"{Name} Book of {book.BookName}");
//    }

//}

//class Book
//{

//    public string BookName;

//    public Book(string BookName)
//    {
//        this.BookName = BookName;
//    }

//}


//----------------------------------------- pattern program----------------------------------------------------------------------

//    *
//   ***
//  *****
// *******
//*********
// *******
//  *****
//   ***
//    *


//Console.Write("enter number : ");
//int n = int.Parse(Console.ReadLine());

//for (int i = 1; i <= n; i++)
//{
//    for (int j = 1; j <= (n - i); j++)
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k < i * 2; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//for (int i = n - 1; i >= 1; i--)
//{
//    for (int j = 1; j <= (n - i); j++) 
//    {
//        Console.Write(" ");
//    }
//    for (int k = 1; k < i * 2; k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//---13 ass ---------------------------------------------------------------------------------------
//Person p1 = new Person();
//p1.age = 10;
//p1.name = "A";

//Person p2 = new Person();
//p2.age = 20;
//p2.name = "B";

//p1.saysHi();
//p2.saysHi();

//swap1(p1, p2);

//p1.saysHi();
//p2.saysHi();

//void swap1(Person psn1, Person psn2)
//{
//    Person temp = psn1;
//    psn1 = psn2;
//    psn2 = temp;
//}
//public class Person
//{
//    public int age;
//    public string name;

//    public void saysHi()
//    {
//        Console.WriteLine(name + "[" + age + "] says hi");
//    }
//}


//////--14 ass --------------------------------------------------------
//14.demart owner want  to store  customer information. they want  give discount to customer based on customer type("dailly_cust","weeklly_cust","monthly_cust","other")

//using following data made a program for demart.

//    note :five class should be there in assignment.
//          used abstraction approach while solving program

//    properties need in classes:

//            customer--      cust_name,cust_phone,cust_address,total_amt,actual_paidamount,date_of_order
//               (actual_paidamount  means what amount will be paid after the given discount;)
//            dailly_cust--   discountrate,
//            weeklly_cust--  discountrate,
//            monthly_cust--  discountrate

//    1.dailly_cust have 4 % discount on purchase.
//    2. weeklly_cust have 3% discount on purchase.
//    3. monthly_cust have 2% discount on purchase.
//    4. other have not discount.

//Customer c = new Dailly_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
//c.Display();
////c.Discount();
//Console.Write($"4% discount daily Customer : ");
//c.Display();

//Customer w = new Weeklly_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
//w.Display();
////w.Discount();
//Console.Write($"3% weaklly daily Customer : ");
//w.Display();

//Customer m = new Monthly_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
//m.Display();
////m.Discount();
//Console.Write($"2% discount monthly Customer : ");
//m.Display();

//Customer o = new Other_Cust("abc", 9876543213, "ngr", 500, 500, "16-4-2022");
//o.Display();
////o.Discount();


//abstract class Customer
//{
//    protected string cust_name;
//    protected long cust_phone;
//    protected string cust_address;
//    protected int total_amt;
//    protected int actual_paidamount;
//    protected string date_of_order;

//    public Customer(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order)
//    {
//        this.cust_name = cust_name;
//        this.cust_phone = cust_phone;
//        this.cust_address = cust_address;
//        this.total_amt = total_amt;
//        this.actual_paidamount = actual_paidamount;
//        this.date_of_order = date_of_order;
//    }

//    public abstract void Discount();

//    public void Display()
//    {

//        Console.WriteLine($"{cust_name} , {cust_phone} ,{cust_address}, {total_amt} ,{actual_paidamount} ,{date_of_order}\n");
//        Discount();
//    }
//}

//class Dailly_Cust : Customer
//{
//    int daily_discount = 4;
//    public Dailly_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
//    {
//    }

//    public override void Discount()
//    {
//        var dis = total_amt * daily_discount / 100;
//        actual_paidamount = total_amt - dis;

//    }
//}

//class Weeklly_Cust : Customer
//{
//    int weeklly_cust = 3;
//    public Weeklly_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
//    {
//    }

//    public override void Discount()
//    {
//        var dis = total_amt * weeklly_cust / 100;
//        actual_paidamount = total_amt - dis;

//    }
//}

//class Monthly_Cust : Customer
//{
//    int monthly_cust = 2;
//    public Monthly_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
//    {
//    }

//    public override void Discount()
//    {
//        var dis = total_amt * monthly_cust / 100;
//        actual_paidamount = total_amt - dis;

//    }
//}


//class Other_Cust : Customer
//{

//    public Other_Cust(string cust_name, long cust_phone, string cust_address, int total_amt, int actual_paidamount, string date_of_order) : base(cust_name, cust_phone, cust_address, total_amt, actual_paidamount, date_of_order)
//    {
//    }

//    public override void Discount()
//    {
//        Console.WriteLine("other customer not Applicable discount ");
//    }
//}