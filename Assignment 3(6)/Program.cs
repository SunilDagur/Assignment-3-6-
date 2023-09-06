using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class MyBaseClass
{
    public string BaseProperty { get; set; }
}
class MyDerivedClass : MyBaseClass
{
    public void AccessBaseProperty()
    {
        BaseProperty = "Accessed from the derived class";
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDerivedClass derivedObject = new MyDerivedClass();

        derivedObject.AccessBaseProperty();

        Console.WriteLine("Property value from the derived class: " + derivedObject.BaseProperty);
    }
}