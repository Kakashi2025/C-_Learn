using C__Learn;
using static System.Runtime.InteropServices.JavaScript.JSType;
//public class A
//{
//    //Private members are visible only in derived classes
//    //that are nested in their base class. Otherwise,
//    //they are not visible in derived classes.
//    private int _value = 10;

//    public class B : A
//    {
//        public int GetValue()
//        {
//            return _value;
//        }
//    }
//}

//public class C : A
//{
//    // if you remove the comments from the C.GetValue method and attempt to compile the example,
//    // it produces compiler error CS0122: "'A._value' is inaccessible due to its protection level."
//    //    public int GetValue()
//    //    {
//    //        return _value;
//    //    }
//}

//public class AccessExample
//{
//    //public static void Main(string[] args)
//    //{
//    //    var b = new A.B();
//    //    Console.WriteLine(b.GetValue());
//    //}

//}
// The example displays the following output:
//       10

var heatingDegreeDays = new HeatingDegreeDays(65, data);
Console.WriteLine(heatingDegreeDays);

var coolingDegreeDays = new CoolingDegreeDays(65, data);
Console.WriteLine(coolingDegreeDays);

foreach (var item in data)
        Console.WriteLine(item);



var account = new BankAccount("<name>", 1000);
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);

var giftCard = new GiftCardAccount("gift card", 100, 50);
giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
giftCard.PerformMonthEndTransactions();
// can make additional deposits:
giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
Console.WriteLine(giftCard.GetAccountHistory());

var savings = new InterestEarningAccount("savings account", 10000);
savings.MakeDeposit(750, DateTime.Now, "save some money");
savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
savings.PerformMonthEndTransactions();
Console.WriteLine(savings.GetAccountHistory());

