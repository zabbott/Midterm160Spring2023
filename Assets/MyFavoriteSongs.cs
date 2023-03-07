using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    string[] SongArray = new string[5];
    List<string> SongList = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        FillSongArray();
        foreach (string s in SongArray)
        {
            SongList.Add(s);
        }
        FavoriteSongsArrayPrinter(SongList);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FavoriteSongsArrayPrinter(List<string> listofsongs)
    {
        for(int i = 0; i < listofsongs.Count; i++)
        {
            Debug.Log(listofsongs[i]);
        }
    }

    public void FillSongArray()
    {
        SongArray[0] = "Belly Flop from Splatoon 3";
        SongArray[1] = "Anarchy Rainbow from Splatoon 3";
        SongArray[2] = "With Flying Colors from Splatoon 3";
        SongArray[3] = "Now or Never (TableTurf Battle) from Splatoon 3";
        SongArray[4] = "Now or never by C-side from Splatoon 3";
        //I couldn't think of any songs that i liked so i just went with some of my favorite songs from splatoon 3
    }
}
