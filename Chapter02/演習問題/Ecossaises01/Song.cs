using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecossaises01 {
    public class Song {

        public String Title { get; set; }//歌手タイトル
        public String ArtistName { get; set; }// アーティストタイトル
        public int Length { get; set; }//演奏時間

        //2.1.2
        public Song(String title, String artistname, int length) {
            Title = title;
            ArtistName = artistname;
            Length = length;
        }
    }
}
