// See https://aka.ms/new-console-template for more information



//delegate int MyDel(int x, int y);
//class Program
//{
//    public static int add(int  x,int y)
//    {
//        return x + y;
//    }
//    public static int mul(int x, int y)
//    {
//        return x * y;
//    }
//    static void Main(String[] args)
//    {
//        MyDel del = new MyDel(add);
//        int result = del(10, 30);
//        Console.WriteLine(result);
//        del = mul;
//        result = del(10, 30);
//        Console.WriteLine(result);
//    }
//}


//delegate void MyDel(int x, int y); // Multicast example your delegate should be void 
//class Program
//{
//    public static void add(int x, int y)
//    {
//        Console.WriteLine(x + y);
//    }
//    public static void mul(int x, int y)
//    {
//        Console.WriteLine(x * y);
//    }
//    static void Main(String[] args)
//    {
//        MyDel del = new MyDel(add);
//        del += mul;
//        del(10, 30);
//    }
//}

public delegate void Mydel(string msg);
class strdeclare {
    public static void Msg1(string msg)
    {
        Console.WriteLine("Msg1 : " + msg);
    }
    public static void Msg2(string msg)
    {
        Console.WriteLine("Msg2 : " + msg);
    }

public static void Main(String[] args) 
{
        Mydel del = Msg1;
        del += Msg2;
        del("Hello");

    }
}