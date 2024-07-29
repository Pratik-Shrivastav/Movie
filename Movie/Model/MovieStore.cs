using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieApp.Services;

namespace Movie.Model
{
    public class MovieStore
    {
        MovieManager movieManager = new MovieManager();

        public void UserOption()
        {
            Console.WriteLine("Welcome to Movie Store");
            Console.WriteLine("--------------------------");
            int userInput = -1;
            while (userInput != 0)
            {
                Console.WriteLine("1. Add Movie" +
                    "\n2. Display all Movies" +
                    "\n3. Remove Movie by Id" +
                    "\n4. Remove All" +
                    "\n0. Exit");
                userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1: movieManager.AddMovie(); break;
                    case 2: movieManager.DisplayMovie(); break;
                    case 3: movieManager.RemoveMovie(); break;
                    case 4: movieManager.RemoveAll();break;
                }
            }
        }
    }
}
