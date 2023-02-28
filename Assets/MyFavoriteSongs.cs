using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    // Start is called before the first frame update
    string[] songList = new string[10]; 
    void Start()
    {
        CreateFavoriteMediaList();
        FavoriteMediaListPrinter(songList.ToList());
    }

  

    public void CreateFavoriteMediaList()
    {
        songList[0] = "MWTWNB";
        songList[1] = "10000 Fists";
        songList[2] = "Villain Vibes";
        songList[3] = "Last Surprise";
        songList[4] = "You're So Creepy";
        songList[5] = "Call me King";
        songList[6] = "The Baddest";
        songList[7] = "What the Hell";
        songList[8] = "Golden Time Lover";
        songList[9] = "Unstoppable";

    }

    public void FavoriteMediaListPrinter(List<string> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            print(list[i]);
        }
    }
}
