using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{

    private List<MediaItem> mediaLibrary = new List<MediaItem>();

    void Start()
    {

        mediaLibrary = PopulateMediaLibrary();

        foreach(MediaItem pieceOfMedia in mediaLibrary)
        {

            EvaluateMediaType(pieceOfMedia);

        }

    }

    public List<MediaItem> PopulateMediaLibrary()
    {

        List<MediaItem> newMediaLibrary = new List<MediaItem>();

        newMediaLibrary.Add(new MediaItem("Dumbo", "Disney", MediaType.Movie));
        newMediaLibrary.Add(new MediaItem("Little Soldiers", "The Crane Wives", MediaType.Song));
        newMediaLibrary.Add(new MediaItem("Frankenstein", "Mary Shelly", MediaType.Book));
        newMediaLibrary.Add(new MediaItem("Pokemon", "Nintendo", MediaType.Game));

        for(int i = 0; i < newMediaLibrary.Count; i++)
        {

            Debug.Log(newMediaLibrary[i].ContentName);
            Debug.Log(newMediaLibrary[i].Artist);

        }

        return newMediaLibrary;

    }

    public void EvaluateMediaType(MediaItem mediaItems)
    {

        switch (mediaItems.MyType)
        {

            case (MediaType.Movie):
                Debug.Log("It's a movie!");
                break;

            case (MediaType.Song):
                Debug.Log("It's a song!");
                break;

            case (MediaType.Book):
                Debug.Log("It's a book!");
                break;

            case (MediaType.Game):
                Debug.Log("It's a game!");
                break;

        }
    }
}
