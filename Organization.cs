namespace knightmoves;

public class Organization{
   private string Name;
   private int YearEstablished = 1934;

   public Organization(string name){
      Name = name;
   }

   public string LookUpBranding(bool includeYearEstablished){

      Name = includeYearEstablished ? $"{Name} est. {YearEstablished}" :  Name;

      return Name;
   }
}