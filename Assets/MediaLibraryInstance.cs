using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> MediaLibrary = new List<MediaItem>();

    // Start is called before the first frame update
    void Start()
    {
        MediaLibrary = PopulateMediaLibrary();
        foreach(MediaItem mediaItemInstance in MediaLibrary)
        {
            print(mediaItemInstance.ContentName + ", " + mediaItemInstance.Artist);
            EvaluateMediaType(mediaItemInstance);
        }
    }

    private List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> newMediaLibrary = new List<MediaItem>();
        newMediaLibrary.Add(new MediaItem("spiderman INTO the spiderverse", "sony", MediaItem.MediaType.Movie));
        newMediaLibrary.Add(new MediaItem("spiderman ACROSS the spiderverse", "sony again", MediaItem.MediaType.Movie));
        newMediaLibrary.Add(new MediaItem("spiderman BEYOND the spiderverse", "guess", MediaItem.MediaType.Movie));
        newMediaLibrary.Add(new MediaItem("hades", "supergiant", MediaItem.MediaType.Game));
        newMediaLibrary.Add(new MediaItem("HADES 2", "supergiant", MediaItem.MediaType.Game)); //IM SO EXCITED  I COULD DIE
        return newMediaLibrary;
    }

    private void EvaluateMediaType(MediaItem mediaItem)
    {
        switch(mediaItem.MyType)
        {
            case MediaItem.MediaType.Movie:
                print("Movie");
                break;
            case MediaItem.MediaType.Song:
                print("Movie");
                break;
            case MediaItem.MediaType.Book:
                print("Movie");
                break;
            case MediaItem.MediaType.Game:
                print("Movie");
                break;

        }
    }
}
