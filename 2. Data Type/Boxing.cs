using System;

class Boxing {
    public static void Main() {
        int a=10, b;
        object o;
        o=a; //boxing
        Console.WriteLine(o);
        b=(int)o; //unboxing
        Console.WriteLine(b);
    }
}