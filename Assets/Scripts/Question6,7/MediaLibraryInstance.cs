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
       foreach(MediaItem mediaItem in MediaLibrary)
        {
            print(mediaItem.ContentName + "," + mediaItem.Artist);
            EvaluateMediaType(mediaItem);
        }
    }


    public List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> newMediaLibrary = new List<MediaItem>();
        newMediaLibrary.Add(new MediaItem("My Neighbor Totoro", " Hayo Miyazaki", MediaItem.MediaType.Movie));
        newMediaLibrary.Add(new MediaItem("Fran Bow", "KillMonday", MediaItem.MediaType.Game));
        newMediaLibrary.Add(new MediaItem("Outlast", "Red Barrels", MediaItem.MediaType.Game));
        newMediaLibrary.Add(new MediaItem("Solitare", "Alice Oseman", MediaItem.MediaType.Book));
        newMediaLibrary.Add(new MediaItem("What Are We Gonna Do Now", "Indego De Suza", MediaItem.MediaType.Song));
        return newMediaLibrary;
        
    }

   public void EvaluateMediaType(MediaItem item)
    {
        switch (item.MyType)
        {
            case MediaItem.MediaType.Book:
                print("pages with a cover :P");
                break;
            case MediaItem.MediaType.Movie:
                print("Movieeeeeeeeez! I love moviezzzzzz!!!!");
                break;
            case MediaItem.MediaType.Song:
                print("a lovely song indeed");
                break;
            case MediaItem.MediaType.Game:
                print("AHHHH VIDEO GAMEZZZZ are the best :3 ");
                break;
        }
    }
}
