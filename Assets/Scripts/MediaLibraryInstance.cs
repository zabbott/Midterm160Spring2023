using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaLibraryInstance : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private List<MediaItem> mediaLibrary = new List<MediaItem>();

    public List<MediaItem> PopulateMediaLibrary()
    {
        return mediaLibrary;
    }

    public void EvaluateMediaType(MediaItem genre)
    {
        
    }
}