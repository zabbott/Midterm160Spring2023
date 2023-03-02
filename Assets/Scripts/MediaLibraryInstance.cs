using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> MediaLibrary = new List<MediaItem>();
    void Start()
    {
        MediaLibrary = PopulateMediaLibrary();

        foreach(MediaItem mediaItem in MediaLibrary)
        {
            print(mediaItem.ContentName + " , " + mediaItem.Artist);
        }

        foreach (MediaItem mediaItem in MediaLibrary)
        {
            EvaluateMediaType(mediaItem);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> newMediaLibrary = new List<MediaItem>();
        newMediaLibrary.Add(new MediaItem("Let You Down", "NF", MediaItem.MediaType.Song));
        newMediaLibrary.Add(new MediaItem("MWTWB", "Amalee", MediaItem.MediaType.Song));
        newMediaLibrary.Add(new MediaItem("Puss In Boots: The Last Wish", "Dreamworks", MediaItem.MediaType.Movie));
        newMediaLibrary.Add(new MediaItem("Destiny 2: Lightfall", "Bungie", MediaItem.MediaType.Game));
        newMediaLibrary.Add(new MediaItem("Nier: Automata", "PlatinumGames", MediaItem.MediaType.Game));
        return (newMediaLibrary);
    }

    private void EvaluateMediaType(MediaItem mediaItem)
    {
        switch (mediaItem.MyType)
        {
            case MediaItem.MediaType.Song:
                print("Tis a song");
                break;

            case MediaItem.MediaType.Movie:
                print("Tis a Movie");
                break;

            case MediaItem.MediaType.Book:
                print("Tis a Book");
                break;

            case MediaItem.MediaType.Game:
                print("Tis a Game");
                break;

        }
    }
}
