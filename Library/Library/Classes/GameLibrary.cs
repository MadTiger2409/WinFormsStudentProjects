using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class GameLibrary
    {
        // Lista gier
        private List<GameObject> games;

        public GameLibrary()
        {
            games = new List<GameObject>();
        }

        public void AddGameToList(GameObject game)
        {
            if (!games.Contains(game))
            {
                games.Add(game);
            }
        }

        public void RemoveGame(GameObject game)
        {
            games.Remove(game);
            SaveGamesToFile();
        }

        public void SaveGamesToFile()
        {
            using (StreamWriter sw = new StreamWriter(@"c:\games.txt"))
            {
                foreach (var game in games)
                {
                    sw.WriteLine("{0}|{1}|{2}|{3}", game.price, game.title, game.description, game.minimalAge);
                }
            }
        }

        public void ImportGamesFromFile()
        {
            games.Clear();

            using (StreamReader sr = new StreamReader(@"c:\games.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] parameters = line.Split('|');

                    GameObject game = new GameObject(decimal.Parse(parameters[0]), parameters[1], parameters[2], int.Parse(parameters[3]));
                    AddGameToList(game);
                }
            }
        }

        public List<GameObject> GetGames()
        {
            return games;
        }
    }
}