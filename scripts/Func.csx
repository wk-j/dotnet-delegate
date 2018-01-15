
Func<string> func = () =>
{
    Console.WriteLine("Body");
    return "Hello";
};


func += () =>
{
    Console.WriteLine("Call 1");
    return "1";
};

func += () =>
{
    Console.WriteLine("Call 2");
    return "2";
};

func();

