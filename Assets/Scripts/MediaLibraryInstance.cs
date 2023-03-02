using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> MediaLibrary = new List<MediaItem>();
  
    public void Start()
    {
        MediaLibrary = PopulateMediaLibrary();
        foreach (MediaItem Item in MediaLibrary)
        {
            Debug.Log(Item.ContentName + Item.Artist);
            EvaluateMediaType(Item);
        }
    }
    public List <MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> MediaList = new List<MediaItem>();
        MediaList.Add(new MediaItem ("Never Gonna Give You Up", "Rick Astley", MediaItem.MediaType.Song));
        MediaList.Add(new MediaItem("Lord of The Flies", "i forgot the author", MediaItem.MediaType.Book));
        MediaList.Add(new MediaItem("Breaking Bad", "i forgot his name", MediaItem.MediaType.Movie));
        MediaList.Add(new MediaItem("Undertale", "Toby Fox", MediaItem.MediaType.Game));
        MediaList.Add(new MediaItem("Wall-E", "Pixar", MediaItem.MediaType.Movie));
        return (MediaList);
    }

    public void EvaluateMediaType(MediaItem instance)
    {
        switch (instance.MyType)
        {
            case MediaItem.MediaType.Book:
                Debug.Log("reading!!");
                break;
            case MediaItem.MediaType.Movie:
                Debug.Log("look at that");
                break;
            case MediaItem.MediaType.Song:
                Debug.Log("banger");
                break;
            case MediaItem.MediaType.Game:
                Debug.Log("GAMER");
                break;
        }


    }
}
