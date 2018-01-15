

Action<string> action = (value) => Console.WriteLine(value);

action += (value) => Console.WriteLine("Call 1");
action += (value) => Console.WriteLine("Call 2");

action("Hello");

// Hello
// Call 1
// Call 2



