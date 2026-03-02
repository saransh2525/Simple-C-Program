// See https://aka.ms/new-console-template for more information
class Abc
{
    public void print(){
        Console.WriteLine("hello print1");
            }
    public void print2()
    {
        Console.WriteLine("hello print2");
            }
    public void print3()
    {
        Console.WriteLine("hello print3");
            }
}
class Xyz
{
    public static void Main(String[] args)
    {
        Abc obj = new Abc();
        obj.print();
        obj.print2();
        obj.print3();
    }
}
