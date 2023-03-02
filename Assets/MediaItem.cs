using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Question 5
/// </summary>
public class MediaItem
{
    public enum MediaType
    {
        Movie,
        Song,
        Book,
        Game
    }

    public string    ContentName ;
    public string    Artist      ;
    public MediaType MyType      ;

    // Dude visual studio wrote this entire constructor for me. 
    // I am not going to be stubborn about my ways any longer. I was wrong.
    // Visual studio is really the best.
    public MediaItem(string contentName, string artist, MediaType myType)
    {
        ContentName = contentName;
        Artist = artist;
        MyType = myType;
    }
}
