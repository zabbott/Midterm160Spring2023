using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class MyFavoriteSongs : MonoBehaviour
{
    //private case
    private string[] songArray = new string[5];
    private void Awake()
    {
        FillSongArray();
    }
    private void Start()
    {
        List<string> songList = songArray.OfType<string>().ToList();
        FavoriteSongsArrayPrinter(songList);
    }

    public void FillSongArray()
    {
        songArray[0] = "Windy";
        songArray[1] = "E.K.E."; 
        songArray[2] = "Borderline";
        songArray[3] = "Even Flow";
        songArray[4]= "Barracuda";

    }

    public void FavoriteSongsArrayPrinter(List <string> songList)
    {
        for (int i = 0; i < songList.Count; i++)
        {
            Debug.Log(songList[i]);
        }
    }
}
