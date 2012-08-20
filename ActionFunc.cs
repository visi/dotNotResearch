using System;

public class Name
{
    private string instanceName;
    public Name(string name)
    {
        this.instanceName = name;
    }
    public void DisplayToWindow()
    {
        Console.WriteLine(this.instanceName);
    }
}

public class testTestDelegate
{
    //public static void Main()
    //{
    //    Name testName = new Name("Koani");
    //    //Action a = testName.DisplayToWindow;
    //    //a();
    //    Action a = () => testName.DisplayToWindow();
    //    a();
        
    //}
}