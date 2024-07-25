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

