using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFavoriteSongs : MonoBehaviour
{
    string[] SongArray = new string[5];
    List<string> ListOfSongs = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        FillSongArray();
        foreach (var song in SongArray)
        {
            ListOfSongs.Add(song);
        }
        FillSongArrayPrinter(ListOfSongs);
    }

    private void FillSongArray()
    {
        SongArray[0] = "robots took on the outside of dogs by kaospilot";
        SongArray[1] = "shadrach by beastie boys"; //tickles my adhd
        SongArray[2] = "hester prynne by as blood runs black";
        SongArray[3] = "i just want to dive in REIWA by teto";
        SongArray[4] = "the king and the bull from hades"; //idk i had to put hades in here somewhere
    }

    private void FillSongArrayPrinter(List<string> ListOfSongs)
    {
        for(int i = 0; i < ListOfSongs.Count; i++)
        {
            Debug.Log(ListOfSongs[i]);
        }
    }

}
