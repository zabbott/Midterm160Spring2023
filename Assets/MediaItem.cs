using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaItem //Q5.1
{
    public string ContentName;
    public string Artist;
    public MediaType MyType;
    public enum MediaType
    {
        Movie,
        Song,
        Book,
        Game
    } //Q5.2
    public MediaItem(string contentName, string artist, MediaType myType)
    {
        ContentName = contentName;
        Artist = artist;
        MyType = myType;
    } //Q5.3

}