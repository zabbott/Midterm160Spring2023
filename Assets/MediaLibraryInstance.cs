using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> MediaLibrary;

    private void Start()
    {
        MediaLibrary = PopulateMediaLibrary();
        Debug.Log(MediaLibrary.Count);

        foreach(var item in MediaLibrary)
        {
            EvaluateMediaType(item);
        }
    }

    public List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> localList = new List<MediaItem>
        {
            new MediaItem("COol thing", "Zach Abbott", Constants.MediaType.Game),
            new MediaItem("COol thing the sequel", "Zach Abbott", Constants.MediaType.Game),
            new MediaItem("COol thing song edition", "Zach Abbott 2", Constants.MediaType.Song),
            new MediaItem("COol thing movie edition", "Zach Abbott movie", Constants.MediaType.Movie),
            new MediaItem("COol thing book edition", "Zach Abbott novel written in gold", Constants.MediaType.Book)

        };
        return localList;
    }

    public void EvaluateMediaType(MediaItem item)
    {
        switch (item.MediaType)
        {
            case Constants.MediaType.Movie:
                Debug.Log("Movie was sent!");
                break;
            case Constants.MediaType.Song:
                Debug.Log("Song was sent!");

                break;
            case Constants.MediaType.Book:
                Debug.Log("Book was sent!");

                break;
            case Constants.MediaType.Game:
                Debug.Log("Game was sent!");

                break;
        }
    }
}
