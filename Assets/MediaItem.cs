using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaItem
{
    public string ContentName;
    public string Artist;
    public MediaType MyType;

    public MediaItem(string CName, string aName, MediaType aType)
    {
        ContentName= CName;
        Artist= aName;
        MyType = aType;
    }

    public enum MediaType
    {
        Movie,
        Song,
        Book,
        game
    }
}
