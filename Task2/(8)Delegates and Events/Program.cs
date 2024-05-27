using System;

class Program
{
    static void Main(string[] args)
    {
        problem.DemonstrateDelegate();
        problem.ImplementCallbackWithDelegate();
        problem.UseMulticastDelegate();
        problem.DefineAndRaiseEvent();
        problem.HandleEvent();
        problem.CreateCustomEventHandler();
        problem.UseBuiltInEventHandler();
        problem.UseAnonymousMethods();
        problem.UseLambdaExpressions();
        problem.ChainMultipleDelegates();
    }
}
class problem
{
    public delegate void MyDelegate(string message);

    public static void DemonstrateDelegate()
    {
        MyDelegate del = new MyDelegate(ShowMessage);
        del("Hello from delegate!");
    }

    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void ImplementCallbackWithDelegate()
    {
        MyDelegate del = new MyDelegate(CallbackMethod);
        ExecuteWithCallback(del);
    }

    public static void ExecuteWithCallback(MyDelegate callback)
    {
        Console.WriteLine("Executing some operation...");
        callback("Callback executed!");
    }

    public static void CallbackMethod(string message)
    {
        Console.WriteLine(message);
    }

    public static void UseMulticastDelegate()
    {
        MyDelegate del1 = new MyDelegate(ShowMessage1);
        MyDelegate del2 = new MyDelegate(ShowMessage2);

        MyDelegate multicastDel = del1 + del2;
        multicastDel("Hello from multicast delegate!");
    }

    public static void ShowMessage1(string message)
    {
        Console.WriteLine("First delegate: " + message);
    }

    public static void ShowMessage2(string message)
    {
        Console.WriteLine("Second delegate: " + message);
    }

    public static event MyDelegate MyEvent;

    public static void DefineAndRaiseEvent()
    {
        MyEvent += new MyDelegate(EventHandlingMethod);
        MyEvent("Event triggered!");
    }

    public static void EventHandlingMethod(string message)
    {
        Console.WriteLine(message);
    }

    public static void HandleEvent()
    {
        MyEvent += new MyDelegate(EventHandlingMethod);
        MyEvent("Handling event!");
    }

    public static event EventHandler CustomEvent;

    public static void CreateCustomEventHandler()
    {
        CustomEvent += new EventHandler(CustomEventHandlerMethod);
        CustomEvent(null, EventArgs.Empty);
    }

    public static void CustomEventHandlerMethod(object sender, EventArgs e)
    {
        Console.WriteLine("Custom event handler executed.");
    }

    public static void UseBuiltInEventHandler()
    {
        EventHandler builtInEvent = new EventHandler(BuiltInEventHandlingMethod);
        builtInEvent(null, EventArgs.Empty);
    }

    public static void BuiltInEventHandlingMethod(object sender, EventArgs e)
    {
        Console.WriteLine("Built-in event handler executed.");
    }

    public static void UseAnonymousMethods()
    {
        MyDelegate del = delegate (string message)
        {
            Console.WriteLine("Anonymous method: " + message);
        };
        del("Hello from anonymous method!");
    }

    public static void UseLambdaExpressions()
    {
        MyDelegate del = (message) => { Console.WriteLine("Lambda expression: " + message); };
        del("Hello from lambda expression!");
    }

    public static void ChainMultipleDelegates()
    {
        MyDelegate del1 = new MyDelegate(ShowMessage1);
        MyDelegate del2 = new MyDelegate(ShowMessage2);
        MyDelegate chainedDel = del1 + del2;
        chainedDel("Hello from chained delegates!");
    }
}
