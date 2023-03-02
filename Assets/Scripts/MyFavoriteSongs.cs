using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{

    string[] songArray = new string[5];
    public List<string> FavoriteSongList = new List<string>();

    void Start()
    {

        FillSongArray();

        FavoriteSongList.Add(songArray[0]);
        FavoriteSongList.Add(songArray[1]);
        FavoriteSongList.Add(songArray[2]);
        FavoriteSongList.Add(songArray[3]);
        FavoriteSongList.Add(songArray[4]);

        FavoriteSongsArrayPrinter(FavoriteSongList);

    }

    public void FillSongArray()
    {

        songArray[0] = "Little Soldiers";
        songArray[1] = "Alone Infection";
        songArray[2] = "Raspberry Beret";
        songArray[3] = "Dramaturgy";
        songArray[4] = "Kick Back";

    }

    public void FavoriteSongsArrayPrinter(List<string> favoriteSongList)
    {

        for(int i = 0; i < favoriteSongList.Count; i++)
        {

            Debug.Log(favoriteSongList[i]);

        }

    }
}
