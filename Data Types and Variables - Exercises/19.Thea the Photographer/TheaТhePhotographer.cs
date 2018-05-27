using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class TheaТhePhotographer
    {
        static void Main(string[] args)
        {
            var allPictures = int.Parse(Console.ReadLine());
            var filterTime = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var uploadTime = int.Parse(Console.ReadLine());

            var filtredPictures = (long)Math.Ceiling( allPictures * (filterFactor / 100d));

            var filterSeconds =(long) allPictures * filterTime;
            var uploadSeconds = filtredPictures * uploadTime;

            var totalSeconds =( filterSeconds + uploadSeconds);

            var totalTime = TimeSpan.FromSeconds(totalSeconds);
            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));

        }
    }
}
