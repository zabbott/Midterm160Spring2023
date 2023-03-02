using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    private string[] SongArray = new string[5];

    void Start()
    {
        FillSongArray();
        FavoriteSongsArrayPrinter(ArrayToList(SongArray));
    }

    public void FillSongArray()
    {
        SongArray[0] = "Blue Hour";
        SongArray[1] = "Love Sux";
        SongArray[2] = "Spiral";
        SongArray[3] = "Tantrum";
        SongArray[4] = "Bad Day";
    }

    public void FavoriteSongsArrayPrinter(List<string> songs)
    {
        for(int i = 0; i < songs.Count; i++)
        {
            print(songs[i]);
        }
    }

    public List<string> ArrayToList(string[] songNames)
    {
        List<string> list = new List<string>();

        foreach(string s in songNames)
        {
            list.Add(s);
        }

        return list;
    }
}
