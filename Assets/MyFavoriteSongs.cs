using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// Question 2 / 3 / 4
/// </summary>
public class MyFavoriteSongs : MonoBehaviour
{
    private string[] SongArray = new string[5]; //Q2
    private List<string> SongList = new List<string>();

    // Update is called once per frame
    void Start()
    {
        FillSongArray(); //Q3

        //Q4:
        SongList = SongArray.OfType<string>().ToList();
        FavoriteSongsArrayPrinter( SongList );
    }

    // Q3
    public void FillSongArray() 
    {
        SongArray = new string[5] {"I","Cant","Think","Of","Songs"};
    }

    // Q4
    public void FavoriteSongsArrayPrinter(List<string> songList)
    {
        for(int i = 0; i<songList.Count; i++) 
            Debug.Log(songList[i]); // {no curly brackets because im a badass}
        
    }
}
