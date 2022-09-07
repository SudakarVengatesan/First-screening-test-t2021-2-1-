using System;
class Samples {
  static void Main() {
    int a=int.Parse(Console.ReadLine()); 
   if(a%2==1)
   {
       for(int i=1,j=1;i<=a;i++,j+=2)
       {
           Console.Write(j+" ");
       }
   }
   if(a%2==0)
   {
       for(int i=1,j=1;i<=(a-1);i++,j+=2)
       {
           Console.Write(j+" ");
       }
   }
  }
}
