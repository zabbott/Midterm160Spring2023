using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> mediaLibrary;

    private void Start()
    {
        mediaLibrary = PopulateMediaLibrary();

        foreach (var item in mediaLibrary)
        {
            print(item.ContentName + ", " + item.Artist);
            EvaluateMediaType(item);
        }
    }

    private List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> listOfMedia = new List<MediaItem>();

        listOfMedia.Add(new MediaItem("Plants", "Nihmune", MediaItem.MediaType.Song));
        listOfMedia.Add(new MediaItem("Legends Of Runeterra", "Riot Games", MediaItem.MediaType.Game));
        listOfMedia.Add(new MediaItem("Magic: the Gathering", "Wizards of the Coast", MediaItem.MediaType.Game));
        listOfMedia.Add(new MediaItem("The Usual Suspects", "IDK", MediaItem.MediaType.Movie));
        listOfMedia.Add(new MediaItem("Harry Potter", "JK Rowling", MediaItem.MediaType.Book));

        return listOfMedia;
    }

    private void EvaluateMediaType(MediaItem media)
    {
        switch (media.MyType)
        {
            case MediaItem.MediaType.Movie:
                print("Movie");
                break;
            case MediaItem.MediaType.Song:
                print("Song");
                break;
            case MediaItem.MediaType.Book:
                print("Book");
                break;
            case MediaItem.MediaType.Game:
                print("Game");
                break;
        }
        

    }
}
