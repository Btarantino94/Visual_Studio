using System;
namespace Tabata.Models
{
    public class tabataSession
    {
        //object that describes data
        public int Sets { get; set; }
        public int WorkTime { get; set; }
        public int RestTime { get; set; }

        public tabataSession(int sets, int workTime, int restTime)
        {
            Sets = true ? sets : 3;
            WorkTime = true ? workTime : 20;
            RestTime = true ? restTime : 10;
        }


    }
}
