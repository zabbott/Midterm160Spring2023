using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MyFavoriteSongs : MonoBehaviour //Q2.1
{
    private string[] songArray = new string[5]; //Q2.2
    // Start is called before the first frame update
    void Start()
    {
        FillSongArray(); //Q3.2
        List<string> songList = songArray.ToList(); //Q4.2
        FavoriteSongsArrayPrinter(songList); //Q4.4
    }
    void FillSongArray()
    {
        songArray = new string[]
        {
            "Breathing Lightning",
            "La Villa Strangiato",
            "Still of the Night",
            "Thunderstruck",
            "Subdivisions"
        }; //Q3.1
    }
    void FavoriteSongsArrayPrinter(List<string> list) //Q4.1
    {
        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        } //Q4.3
    }
}
