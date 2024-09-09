var a = Enumerable.Range(1, 5).ToArray();
// Console.WriteLine(WorkWithSum.Sum(a, 2, 2));
Span<int> s = new Span<int>(a, 2, 2);
Console.WriteLine(WorkWithSum.Sum(s));

