class Program
{
  public static void Main(string[] args)
  {
    int nguoi, may; //0 - keo, 1 - bua, 2 - bao
    Random rand = new Random();
    nguoi = rand.Next(3); may = rand.Next(3);
    string panguoi = (nguoi==0?"Keo":(nguoi==1?"Bua":"Bao"));
    string pamay = (may==0?"Keo":(may==1?"Bua":"Bao"));
    System.Console.WriteLine($"May: {pamay} | Nguoi: {panguoi}");
    switch(nguoi){
      case 0://keo
        if(may==0) System.Console.WriteLine("Hoa");
        if(may==1) System.Console.WriteLine("May thang");
        if(may==2) System.Console.WriteLine("Nguoi thang");
        break;
      case 1://bua
        if(may==0) System.Console.WriteLine("Nguoi thang");
        if(may==1) System.Console.WriteLine("Hoa");
        if(may==2) System.Console.WriteLine("May thang");
        break;
      case 2://bao
        if(may==0) System.Console.WriteLine("May thang");
        if(may==1) System.Console.WriteLine("Nguoi thang");
        if(may==2) System.Console.WriteLine("Hoa");
        break;
      default:
        System.Console.WriteLine("Khong xac dinh!");
        break;
    }
  }
}