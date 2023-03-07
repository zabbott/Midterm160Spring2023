using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> mediaLibrary= new List<MediaItem>();
    void Start()
    {
        mediaLibrary = PopulateMediaLibrary();
        foreach(MediaItem I in mediaLibrary)
        {
            print("Name: " + I.ContentName + " Artist: " + I.Artist);
            EvaluateMediaType(I);
        }
    }

    public void EvaluateMediaType(MediaItem M)
    {
        switch (M.MyType)
        {
            case MediaItem.MediaType.Movie:
                print("Damn you really want to be here for over an hour and a half?");
                return;
            case MediaItem.MediaType.Song:
                print("It's just more pretty talking");
                return;
            case MediaItem.MediaType.Book:
                print("Oh, you are trying to take a nap huh");
                return;
            case MediaItem.MediaType.game:
                print("Damn, I can't make fun of this. This is what I do too much");
                return;

        }
    }

    public List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> MList = new List<MediaItem>();
        MList.Add(new MediaItem("This is a name", "Me", MediaItem.MediaType.game));
        MList.Add(new MediaItem("Name is a This", "You", MediaItem.MediaType.Book));
        MList.Add(new MediaItem("Me is a name", "This", MediaItem.MediaType.Movie));
        MList.Add(new MediaItem("This is a Me", "This", MediaItem.MediaType.Song));
        MList.Add(new MediaItem("This me a name", "is", MediaItem.MediaType.game));
        return MList;
    }
}
