using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Question 6 / 7
/// </summary>
public class MediaLibraryInstance : MonoBehaviour
{
    //test instructions say to name it MediaLibrary and (i think) I know my syntax, but I'm just going to believe you with this one.
    private List<MediaItem> MediaLibrary;

    //Update is awesome i love i love i love update
    void Start()
    {
        MediaLibrary = PopulateMediaLibrary();

        foreach(MediaItem item in MediaLibrary)
        {
            Debug.Log(item.ContentName + " was made by " + item.Artist); // Q 6
            EvaluateMediaType(item); // Q 7
        }
    }

    // Q 6
    public List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> tempList = new List<MediaItem>();

        tempList.Add(new MediaItem("Dark Souls", "John Dark Souls, obviously", MediaItem.MediaType.Game));
        tempList.Add(new MediaItem("Believer", "Imagine Dragons", MediaItem.MediaType.Song));
        tempList.Add(new MediaItem("Diary of a Wimpy Kid: Rodrick Rules", "Greg Heffley", MediaItem.MediaType.Book));
        tempList.Add(new MediaItem("Free Guy", "John Free Guy, duh", MediaItem.MediaType.Movie));
        tempList.Add(new MediaItem("Believer 2", "Imagine Dragons", MediaItem.MediaType.Song));

        return tempList;
    }

    // Q 7
    public void EvaluateMediaType(MediaItem item)
    {
        switch(item.MyType) 
        {
            case MediaItem.MediaType.Game :
                Debug.Log(item.ContentName + " is a game.");
                break;
            case MediaItem.MediaType.Book:
                Debug.Log(item.ContentName + " is a book.");
                break;
            case MediaItem.MediaType.Movie:
                Debug.Log(item.ContentName + " is a movie.");
                break;
            case MediaItem.MediaType.Song:
                Debug.Log(item.ContentName + " is a song.");
                break;
        }
    }
}
