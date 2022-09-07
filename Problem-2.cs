using System;
class HelloWorld {
  static void Main() {
    int n=int.Parse(Console.ReadLine());
    for(int i=0,j=1;i<n;i++,j+=2)
    {
        Console.Write(j+" ");
    }
  }
}