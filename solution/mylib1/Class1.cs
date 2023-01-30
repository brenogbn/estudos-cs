namespace mylib1;
public class Class1
{
    public void DoSomething()
    {
        Console.WriteLine("mylib1.Class1.DoSomething()");
    }
    public int MyProperty { get; set; }
    public int MyMethod(int x)
    {
        return x * 2;
    }
}
