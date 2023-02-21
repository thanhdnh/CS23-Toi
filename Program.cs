class Program
{
  public static void Main(string[] args)
  {
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    int tong = 0;
    int n = 10;
    for(int i=1; i<=n; i=i+2)
      tong += i;
    System.Console.WriteLine("Tổng: {0}", tong);
    //1+3+5+7+9

    int tong2 = 0;
    for(int i=1; i<=n; i++)
      if(i%2!=0)
        tong2 += i;
    System.Console.WriteLine("Tổng: {0}", tong2);

    int tong3 = 0;
    for(int i=1; i<=n; i++){
      if(i%2==0)
        continue;
      tong3+=i;
    }
    System.Console.WriteLine("Tổng: {0}", tong3);
  }
}