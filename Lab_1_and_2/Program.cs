using Abstraction;
class MainClass{

    static Soccer soccerObj = new(11 , "Soccer");
    static Student studentObj = new();
  public static void Main()
  {
        soccerObj.Playing();

        //set Values for stdObj
        studentObj.Name = "Tanveer";
        studentObj.Age = 23 ;

        Console.WriteLine("Name of Student is : "+studentObj.Name);

         Console.WriteLine("Age of Student is : "+studentObj.Age);


  }
}