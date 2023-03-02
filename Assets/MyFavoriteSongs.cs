using System.Collections;
using System.Collections.Generic;
using System.Linq; //fuck this guy in particular
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    private string[] SongArray = new string[5];

    public void Start()
    {
        FillSongArray();
        List<string> SongList = SongArray.ToList();
        FavoriteSongsArrayPrinter(SongList);
    }
    public void FillSongArray() //I listen to weeb shit so you probs won't know any of these
    {
        //Translating these song names to english was the hardest part so far
        SongArray[0] = "Fake Parade";
        SongArray[1] = "Proto Disco";
        SongArray[2] = "Disturb Manic Girl";
        SongArray[3] = "Uncanny";
        SongArray[4] = "Mr. Schadenfruede";
    }

    public void FavoriteSongsArrayPrinter(List<string> songs)
    {
        for (int i = 0; i < 5; i++) //Imagine using unecessay curly brace (please don't take points off)
            print(songs[i]);
    }
}

