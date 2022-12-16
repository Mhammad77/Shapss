
class Shape
{
   
   public string Name ="Victus"; 
   public string color = "Black"; 
   public int PositionX = 10;  
   public int PositionY = 25;  
   public void GetPosition()
   {
    System.Console.WriteLine($"PositionX =  {PositionX} ");
    System.Console.WriteLine($"PositionY = {PositionY}");
   }
   public void Getinfo(){

    System.Console.WriteLine($"name= {Name} \ncolor=  {color}\n{PositionX}-{PositionY}");

   }
 
}