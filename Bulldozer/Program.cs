using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			var man = new Man();
			var kart = new Kart();
			var alien = new Alien();
        }
    }

    public class GeneralObject
	{
		public GeneralObject()
		{
			
		}

		public bool Moves { get; set; }
		public string Color { get; set; }
	}

    	public class Human : GeneralObject
    	{
    		public Human()
    		{
    			
    		}

    		public string Name { get; set; }
    	}

        	public class Man : Human
        	{
        		public Man ()
        		{
                    
        		}

        	}

        	public class Woman : Human
            {
                public Woman()
                {

                }

            }

	public class Kart : GeneralObject
    {
        public Kart()
		{

        }

        public string Manufacturer { get; set; }
    }

	public class Alien : GeneralObject
    {
        public Alien()
        {

        }

        public string Planet { get; set; }
    }
}
