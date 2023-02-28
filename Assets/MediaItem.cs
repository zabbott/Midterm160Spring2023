using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaItem 
{
    public string ContentName;
    public string Artist; 
    public Constants.MediaType MediaType;

    public MediaItem(string contentName, string artist, Constants.MediaType mediaType)
    {
        ContentName = contentName;
        Artist = artist;
        MediaType = mediaType;
    }
}
