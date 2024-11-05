string fizz = "Fizz";
string buzz = "Buzz";

for (int i = 1; i <= 100; i++) {
    if ((i % 3 == 0) && (i % 5 == 0))
        System.Console.WriteLine($"{i} - {fizz}{buzz}");
    else if (i % 3 == 0)
        System.Console.WriteLine($"{i} - {fizz}");
    else if (i % 5 == 0)
        System.Console.WriteLine($"{i} - {buzz}");
    else
        System.Console.WriteLine("" + i);
}
