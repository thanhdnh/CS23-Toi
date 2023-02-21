class Program
{
  public static void Main(string[] args)
  {
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    int nguoi, may; //0 - keo, 1 - bua, 2 - bao
    Random rand = new Random();
    nguoi = rand.Next(3); may = rand.Next(3);
    string panguoi = (nguoi==0?"Kéo":(nguoi==1?"Búa":"Bao"));
    string pamay = (may==0?"Kéo":(may==1?"Búa":"Bao"));
    System.Console.WriteLine($"Máy: {pamay} | Người: {panguoi}");
    switch(nguoi){
      case 0://keo
        if(may==0) System.Console.WriteLine("Hoà");
        if(may==1) System.Console.WriteLine("Máy thắng!");
        if(may==2) System.Console.WriteLine("Người thắng!");
        break;
      case 1://bua
        if(may==0) System.Console.WriteLine("Người thắng!");
        if(may==1) System.Console.WriteLine("Hoà");
        if(may==2) System.Console.WriteLine("Máy thắng!");
        break;
      case 2://bao
        if(may==0) System.Console.WriteLine("Máy thắng!");
        if(may==1) System.Console.WriteLine("Người thắng!");
        if(may==2) System.Console.WriteLine("Hoà");
        break;
      default:
        System.Console.WriteLine("Không xác định!");
        break;
    }
  }
}