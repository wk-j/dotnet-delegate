

Action<string> action = (input) => Console.WriteLine("Body");

action += (input) => Console.WriteLine("Call 1");
action += (input) => Console.WriteLine("Call 2");

action("Hello");

// Body
// Call 1
// Call 2

