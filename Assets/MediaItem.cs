using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaItem 
{
    public string ContentName;
    public string Artist;
    public MediaType MyType; //I don't have a type
    public enum MediaType
    {
        Movie,
        Song,
        Book,
        Game
    }

    public MediaItem(string name, string artist, MediaType type)
    {
        ContentName = name;
        Artist = artist;
        MyType = type;
    }
}
