using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sloth3
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; // static class attribute

        // constructor method; anytime a song object is created, this method gets called
        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSoungCount()
        {
            return songCount;
        }
    }
}
