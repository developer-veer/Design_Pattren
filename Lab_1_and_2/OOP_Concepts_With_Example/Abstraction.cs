namespace Abstraction
{
    abstract class Sports
    {

        protected string type;
        protected int numOfPlayers;

        public Sports()
        {
            type = "deafult";
            numOfPlayers = 0;
        }

        abstract public void Playing();

    }

    class Soccer : Sports
    {
        public Soccer(int numOfPlayers, string sportType)
        {
            this.numOfPlayers = numOfPlayers;
            this.type = sportType;

        }

        public override void Playing()
        {
            Console.WriteLine("I'm Playing " + type + " I have " + numOfPlayers + "players..");
        }
    }


}