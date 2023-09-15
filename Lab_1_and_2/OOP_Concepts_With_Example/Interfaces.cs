namespace Interfaces{
    interface IPrimium{
        public double Payment();
    }

    class NetflixPrimium : IPrimium
    {

        private double Charge;
        public double Payment()
        {
            Console.WriteLine("Add Your Payment Method");

            return Charge;
        }
    }
}