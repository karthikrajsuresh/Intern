using System;

public class MyClass
{
    public int publicField;        // Accessible from anywhere
    private int privateField;       // Accessible only within MyClass
    protected int protectedField; // Accessible within MyClass and derived classes
    internal int internalField;     // Accessible within the same assembly
    protected internal int protectedInternalField; // Accessible within the same assembly or by derived classes
    private protected int privateProtectedField; // Accessible within the same assembly by derived classes
}

class Program
{
    static void Main()
    {
        MyClass myObj = new MyClass();

        // Accessing fields
        myObj.publicField = 10;               // Ok
        //myObj.privateField = 20;           // Error: privateField is inaccessible
        //myObj.protectedField = 30;         // Error: protectedField is inaccessible
        myObj.internalField = 40;             // Ok
        myObj.protectedInternalField = 50;    // Ok
        //myObj.privateProtectedField = 60;   // Error: privateProtectedField is inaccessible
    }
}
