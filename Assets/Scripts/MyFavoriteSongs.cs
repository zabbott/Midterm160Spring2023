using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    private string[] SongArray = new string[5];
    // Start is called before the first frame update
    void Start()
    {
        List<string> SongsList = new List<string>();
        FillSongArray();

        foreach ( var Song in SongArray )
        {
            SongsList.Add(Song);
        }

        FavoriteSongsArrayPrinter(SongsList);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FillSongArray()
    {
        SongArray = new string[]
        {
            "Rise of the Monarch (Intro)",
            "From the Embers",
            "Metamorphosis",
            "Monster U Made",
            "MWTWB"
        };
    }

    private void FavoriteSongsArrayPrinter(List<string> SongsList)
    {
        for(int i = 0; i < SongsList.Count; i++)
        {
            Debug.Log(SongsList[i]);
        }
    }
}
