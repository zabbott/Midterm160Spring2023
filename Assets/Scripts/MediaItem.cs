using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaItem
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
    }
}
