using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> mediaLibrary = new List<MediaItem>();

    // Start is called before the first frame update
    void Start()
    {
        mediaLibrary = PopulateMediaLibrary();
        foreach(MediaItem m in mediaLibrary)
        {
            Debug.Log(m.ContentName + ", " + m.Artist);
            EvaluateMediaType(m);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> newListOfMedia = new List<MediaItem>();
        newListOfMedia.Add(new MediaItem("Pan's Labyrinth", "Guillermo", MediaItem.MediaType.Movie));
        newListOfMedia.Add(new MediaItem("Weird Fishes", "Radiohead", MediaItem.MediaType.Song));
        newListOfMedia.Add(new MediaItem("House of Leaves", "Mark", MediaItem.MediaType.Book));
        newListOfMedia.Add(new MediaItem("Pyre", "Supergiant Games", MediaItem.MediaType.Game));
        newListOfMedia.Add(new MediaItem("Magnolia", "Paul Thomas Anderson", MediaItem.MediaType.Movie));
        return newListOfMedia;
    }

    private void EvaluateMediaType(MediaItem media)
    {
        switch (media.MyType)
        {
            case MediaItem.MediaType.Movie:
                Debug.Log("Movie");
                break;
            case MediaItem.MediaType.Song:
                Debug.Log("Song");
                break;
            case MediaItem.MediaType.Book:
                Debug.Log("Book");
                break;
            case MediaItem.MediaType.Game:
                Debug.Log("Game");
                break;
        }
    }
}
