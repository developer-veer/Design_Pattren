class Singleton
{
   private static Singleton instance = new ();
    private Singleton()
    {

    }

    public static Singleton? GetInstance()
    {
        if(instance != null)
        {
            return instance ;
        }
        return null;
    }

    public  void Display()
    {
        Console.WriteLine("This Singleton Class..");
    }
}