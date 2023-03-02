using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaItem
{
    public enum MediaType
    {
        Movie,
        Song,
        Book,
        Game
    }

    public string ContnetName;
    public string Artist;
    public MediaType MyType;

    public MediaItem(string contnetName, string artist, MediaType myType)
    {
        ContnetName = contnetName;
        Artist = artist;
        MyType = myType;
    }
}
