using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    private string[] songArray = new string[5];
    List<string> newListOfSongs = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        FillSongArray();
        foreach(string song in songArray)
        {
            newListOfSongs.Add(song);
        }
        FavoriteSongsArrayPrinter(newListOfSongs);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FillSongArray()
    {
        songArray[0] = "Weird Fishes";
        songArray[1] = "Hunter";
        songArray[2] = "Lover I Don't Have to Love";
        songArray[3] = "Mother";
        songArray[4] = "King Kunta";
    }

    private void FavoriteSongsArrayPrinter(List<string> favoriteSongs)
    {
        for(int i = 0; i < favoriteSongs.Count; i++)
        {
            Debug.Log(favoriteSongs[i]);
        }
    }
}
