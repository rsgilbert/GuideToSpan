var a = Enumerable.Range(1, 5).ToArray();
// Console.WriteLine(WorkWithSum.Sum(a, 2, 2));
Span<int> s = new Span<int>(a, 2, 2);
// Console.WriteLine(WorkWithSum.Sum(s));

// unsafe
// {
//     int* ptr = stackalloc int[2000];
//     WorkWithSum.Sum(new Span<int>(ptr, 1000));
// }


string st = string.Create(34, Guid.NewGuid(), (span, s) => 
{
     Console.WriteLine(span.ToString());
    span[0] = 'M';
    span[1] = 'T';
    span[2] = 'Z';
    Console.WriteLine(s);
    Console.WriteLine(span.ToString());
   s.TryFormat(span[2..], out _, "N");
    Console.WriteLine(span.ToString());
});
Console.WriteLine(st.Length);
Console.WriteLine("X"+st+"X");