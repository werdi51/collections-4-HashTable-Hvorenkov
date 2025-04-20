using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Практика_коллекций_4_HashTable
{

    class Disk
    {
        public string NamePlaylist { get; set; }
        public List<string> Songs { get; set; }  

        public Disk()
        {
            Songs = new List<string>();
        }
    }

}

