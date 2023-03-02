using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    List<string> songList = new List<string>();
    private string[] songArray = new string[5];

    private void Start()
    {
        FillSongArray();

        foreach (string s in songArray)
        {
            songList.Add(s);
        }

        FavoriteSongArrayPrinter(songList);

    }

    private void FillSongArray()
    {
        songArray[0] = "Plants";
        songArray[1] = "Neptune";
        songArray[2] = "Zoomin";
        songArray[3] = "Feelin Dandy";
        songArray[4] = "Underground";
        

    }

    private void FavoriteSongArrayPrinter(List<string> strList)
    {
        for (int i = 0; i < strList.Count; i++)
        {
            print(strList[i]);
        }
    }
    
}
