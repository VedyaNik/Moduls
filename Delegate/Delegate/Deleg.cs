using System;


namespace Delegat
{
    public delegate void Count(int a, int b);
    public delegate Count DelDel(Count fun1, Count fun2);
    public class Delegates
    {
        public static DelDel DelFuncDec = (fun1, fun2) => fun1 - fun2;
        public static DelDel DelFuncInc = (fun1, fun2) => fun1 + fun2;
        public static Count functionSum = (i1, i2) => Console.WriteLine(i1 + i2);
        public static Count functionDif = (i1, i2) => Console.WriteLine(i1 - i2);
        public static Count functionProd = (i1, i2) => Console.WriteLine(i1 * i2);
        public static Count functionDiv = (i1, i2) => Console.WriteLine(i1 / i2);
    }
}
