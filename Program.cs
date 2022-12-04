using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time <= 10){
                Console.WriteLine("Günaydın!");
            }
            else if(time <=12){
                Console.WriteLine("İyi Günler!");
            }
            else{
                Console.WriteLine("İyi Akşamlar!");
            }
        }
    }
}