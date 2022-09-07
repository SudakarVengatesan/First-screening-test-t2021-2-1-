using System;
class Cal{
    public void Add(double a,double b)
    {
         Console.WriteLine(a+b);
    }
    public void Sub(double a,double b)
    {
        Console.WriteLine(a-b);
    }
    public void Mul(double a,double b)
    {
         Console.WriteLine(a*b);
    }
    public void Div(double a,double b)
    {
         Console.WriteLine(a/b);
    }
}

class exe {
  static void Main() {
    double a,b;
    string op;
    a=double.Parse(Console.ReadLine());
    b=double.Parse(Console.ReadLine());
    op=Console.ReadLine();
    Cal obj=new Cal();
    if(op=="Addition"||op=="addition")
    {
        obj.Add(a,b);
    }
    
    if(op=="Subtraction"||op=="subtraction")
    {
        obj.Sub(a,b);
    }
    if(op=="Multiplication"||op=="multiplication")
    {
        obj.Mul(a,b);
    }
    if(op=="Division"||op=="division")
    {
        obj.Div(a,b);
    }
  }
}
