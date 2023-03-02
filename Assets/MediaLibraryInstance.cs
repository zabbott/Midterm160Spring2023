using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> mediaLibrary; //Q6.1
    void Start()
    {
        mediaLibrary = PopulateMediaLibrary();
        foreach (MediaItem item in mediaLibrary)
        {
            Debug.Log(item.ContentName + " by " + item.Artist);
            EvaluateMediaType(item);
        } //Q6.3 + Q7.3
    }
    List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> list = new List<MediaItem>()
        {
            new MediaItem("Super Meat Boy", "Edmund McMillan", MediaItem.MediaType.Game),
            new MediaItem("Middletown Daydreams", "Rush", MediaItem.MediaType.Song),
            new MediaItem("Spelunky", "Derek Yu", MediaItem.MediaType.Game),
            new MediaItem("Slow and Easy", "Whitesnake", MediaItem.MediaType.Song),
            new MediaItem("The Chronicles of Amber", "Roger Zelazny", MediaItem.MediaType.Book)
        }; //Q6.2
        return list;
    }
    void EvaluateMediaType(MediaItem item) //Q7.1
    {
        switch (item.MyType)
        {
            case MediaItem.MediaType.Movie:
                Debug.Log(item.ContentName + " is a movie");
                break;
            case MediaItem.MediaType.Song:
                Debug.Log(item.ContentName + " is a song");
                break;
            case MediaItem.MediaType.Book:
                Debug.Log(item.ContentName + " is a book");
                break;
            case MediaItem.MediaType.Game:
                Debug.Log(item.ContentName + " is a game");
                break;
        } //Q7.2
    }
}
