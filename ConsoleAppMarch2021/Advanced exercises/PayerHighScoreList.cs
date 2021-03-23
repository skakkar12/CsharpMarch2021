using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMarch2021.Advanced_exercises
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int Score { get; set; }
    }
    public class PayerHighScoreList
    {
        private List<Player> lstPlayer;
        public static void Main(string[] args)
        {
            
        }

        public  PayerHighScoreList(List<Player> list)
        {
            lstPlayer = list;
        }

        public int LatestScore()
        {
            return lstPlayer.Last().Score;

        }

        public int MaxScore()
        {

            return lstPlayer.Max().Score;
        }

        public List<Player> TopThreeScores()
        {

            return lstPlayer.OrderBy(s => s.Id).Take(3).ToList();
        }

    }
}