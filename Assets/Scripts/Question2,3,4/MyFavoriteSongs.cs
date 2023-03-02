using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    private string[] SongArray = new string[5];
    private List<string> NewSongList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        FillSongArray();
        foreach(var songs in SongArray)
        {
            NewSongList.Add(songs);
        }
        FavoriteSongArrayPrinter(NewSongList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillSongArray()
    {
        SongArray[0] = "Cough it Out";
        SongArray[1] = "Flying Model Rockets";
        SongArray[2] = "This Comes from Inside";
        SongArray[3] = "I Think Your Nose is Bleeding";
        SongArray[4] = "Heatwaves";
    }

    public void FavoriteSongArrayPrinter(List<string>NewSongList)
    {
        for(int i = 0; i < NewSongList.Count; i++)
        {
            Debug.Log(NewSongList[i]);
        }
    }

}
