using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
    public class Library
    {
        // Lista gier
        private List<GameObject> games;

        public Library()
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
            //TODO Usuwanie gry z listy
            SaveGamesToFile();
        }

        private void SaveGamesToFile() => throw new NotImplementedException();
    }
}