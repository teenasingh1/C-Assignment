using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace Excercise7
{
    public class IDuck
    {
        
        public int Weight { get; set; }
        public int NoOfWings { get; set; }
        public void ShowDetail()
        {
            Console.WriteLine( Weight + " " + NoOfWings + " ");
        }
    }
}

