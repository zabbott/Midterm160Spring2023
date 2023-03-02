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

        foreach(MediaItem item in MediaLibrary)
        {
            print(item.ContnetName + " by " + item.Artist);
            EvaluateMediaType(item);
        }

        //Song does print out twice, it just is shown in the editor where it first came up.
    }

    public List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> mediaItems = new List<MediaItem>();
        mediaItems.Add(new MediaItem("Sons of the Forest", "Endnight", MediaItem.MediaType.Game));
        mediaItems.Add(new MediaItem("Spiral", "Mothica", MediaItem.MediaType.Song));
        mediaItems.Add(new MediaItem("Captain America", "Marvel Studios", MediaItem.MediaType.Movie));
        mediaItems.Add(new MediaItem("Calling Heart", "Andrea Drees", MediaItem.MediaType.Book));
        mediaItems.Add(new MediaItem("Tantrum", "Charolette Sands", MediaItem.MediaType.Song));

        return mediaItems;
    }

    public void EvaluateMediaType(MediaItem item)
    {
        switch(item.MyType)
        {
            case MediaItem.MediaType.Game:
                print("Game");
                break;

            case MediaItem.MediaType.Song:
                print("Song");
                break;

            case MediaItem.MediaType.Movie:
                print("Movie");
                break;

            case MediaItem.MediaType.Book:
                print("Book");
                break;
        }
    }
}
