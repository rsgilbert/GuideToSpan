var a = Enumerable.Range(1, 5).ToArray();
// Console.WriteLine(WorkWithSum.Sum(a, 2, 2));
Span<int> s = new Span<int>(a, 2, 2);
// Console.WriteLine(WorkWithSum.Sum(s));

// unsafe
// {
//     int* ptr = stackalloc int[2000];
//     WorkWithSum.Sum(new Span<int>(ptr, 1000));
// }


// string st = string.Create(34, Guid.NewGuid(), (span, s) => 
// {
//      Console.WriteLine(span.ToString());
//     span[0] = 'M';
//     span[1] = 'T';
//     span[2] = 'Z';
//     Console.WriteLine(s);
//     Console.WriteLine(span.ToString());
//    s.TryFormat(span[2..], out _, "N");
//     Console.WriteLine(span.ToString());
// });
// Console.WriteLine(st.Length);
// Console.WriteLine("X"+st+"X");


// int i = 20;

// Console.WriteLine(Use(ref i));
// Console.WriteLine(i);

// static ref int Use(ref int myInt)
// {
//     myInt = 12;
//     return ref myInt;
// }

// int i = 42;
// var span = new MySpan<int>(ref i);
// span[0]++;
// Console.WriteLine(i); // 43


int[] arr = [9,8,7];
var sp2 = new MySpan<int>(arr);
// int i = -3;
// long j = -4294967296;
// Console.WriteLine((uint) i);
// Console.WriteLine((uint) j);
// Console.WriteLine(int.MaxValue);
// Console.WriteLine((long)int.MaxValue * 2);
// Console.WriteLine(sp2[1]);
// Console.WriteLine(sp2[2]);
// Console.WriteLine(sp2[3]);
// Console.WriteLine(sp2[4]);

// MySpan<char> myWords = new MySpan<char>("Hey Gilbert".ToCharArray());
// while(myWords.Length > 0)
// {
//     Console.WriteLine(myWords[0]);
//     myWords ;= myWords.Slice(1);
// }


MyReadonlySpan<string> namesSpan = new(["Gilbert", "Jane", "Emily"]);
Console.WriteLine(namesSpan[1]);
// namesSpan[2] = "Peter";
Console.WriteLine(namesSpan[2]);
