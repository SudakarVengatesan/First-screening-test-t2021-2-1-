using System;
class HelloWorld {
  static void Main() {
    
    int a=int.Parse(Console.ReadLine());
    int[] num=new int[a];
    int[] div=new int[9]{0,0,0,0,0,0,0,0,0};
    int[] count=new int[9]{1,2,3,4,5,6,7,8,9};
    for(int i=0;i<a;i++)
    {
        num[i]=int.Parse(Console.ReadLine());
    }
    
    for(int i=0;i<a;i++)
    {
       for(int j=0;j<9;j++)
       {
          if((num[i]%count[j])==0)
          {
              div[j]+=1;
          }
       }
    }
    
    for(int i=0;i<9;i++)
    {
        Console.Write(count[i]+":"+div[i]+",");
    }
