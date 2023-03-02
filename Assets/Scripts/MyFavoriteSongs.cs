using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    private string[] songArray = new string[5];

    // Start is called before the first frame update
    void Start()
    {
        FillSongArray();
        List<string> newSongList = new List<string>();
        FavoriteSongsArrayPrinter(songArray);
    }

    private void FillSongArray()
    {
        songArray[0] = "The Sun Never Says";
        songArray[1] = "Iya";
        songArray[2] = "Thank You";
        songArray[3] = "Love: Then and Still";
        songArray[4] = "Uraya Day Theme";
    }

    private void FavoriteSongsArrayPrinter(string[] playlist)
    {
        for (int i = 0; i < playlist.Length; i++)
        {
            Debug.Log(playlist[i]);
        }
    }
}
