Console.Write("Insert a number for week day: ");
int N = int.Parse(Console.ReadLine());
if (N == 6 || N == 7)
 {
   Console.WriteLine($"{N} -> yes");
 }
 else
  {
   Console.WriteLine($"{N} -> no");
  }