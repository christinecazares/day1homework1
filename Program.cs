using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Week01Day01PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sound1 = new SoundPlayer(@"http://www.wavsource.com/snds_2015-08-16_6897529750891327/movies/misc/bill_ted_cool.wav");
            var Sound2 = new SoundPlayer(@"http://www.wavsource.com/snds_2015-08-16_6897529750891327/movies/misc/bill_ted_excellent.wav");
            var Sound3 = new SoundPlayer(@"http://www.wavsource.com/snds_2015-08-16_6897529750891327/movies/misc/bill_ted_whoa.wav");
            var Sounds = new SoundPlayer[]{
                Sound1, Sound2, Sound3 };
            Random index = new Random();
            int rnd = index.Next(Sounds.Length);
            Sounds[rnd].Play();
            Console.ReadLine();
            
        }
    }
        
    
}
