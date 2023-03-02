using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    private List<MediaItem> MediaLibrary;
    public void Start()
    {
        MediaLibrary = PopulateMediaLibrary();
        foreach(MediaItem i in MediaLibrary)
        {
            print(i.ContentName + "  " + i.Artist);
            EvaluateMediaType(i);
        }
    }

    public List<MediaItem> PopulateMediaLibrary()
    {
        List<MediaItem> mediaList = new List<MediaItem>();
        MediaItem Persona5 = new MediaItem("Persona 5", "Atlas", MediaItem.MediaType.Game);//What if my 5 items were all the persona games?
        MediaItem PussInBoots = new MediaItem("Puss In Boots", "DreamWorks", MediaItem.MediaType.Movie);
        MediaItem HTTYD = new MediaItem("How to Train Your Dragon", "Dreamworks", MediaItem.MediaType.Movie);
        MediaItem BestSong = new MediaItem("Fake Parade", "Chogakusei", MediaItem.MediaType.Song); // <3 <3 <3
        MediaItem FNAF = new MediaItem("Five Nights at Freddy's", "Scott Cawthon", MediaItem.MediaType.Game);
        mediaList.Add(Persona5);
        mediaList.Add(PussInBoots);
        mediaList.Add(HTTYD);
        mediaList.Add(BestSong);
        mediaList.Add(FNAF);
        return mediaList;
    }

    public void EvaluateMediaType(MediaItem item)
    {
        switch (item.MyType)
        {//Sorry for the print statements I'm bored
            case MediaItem.MediaType.Book:
                {
                    print("Lmao who reads books, nerd");
                    break;
                }
            case MediaItem.MediaType.Movie:
                {
                    print("Please dont be 3 hours long");
                    break;
                }
            case MediaItem.MediaType.Song:
                {
                    print("Yo this is a banger");
                    break;
                }
            case MediaItem.MediaType.Game:
                {
                    print("Ayo Epic Gamer Moment");
                    break;
                }
        }
    }
}
