using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Video;

public class VideoTracker : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private VideoPlayer video;

    private Slider tracker;
    private bool slide;
    
    void Start()
    {
        tracker = GetComponent<Slider>();
        slide = false;
    }

    private void Update() {
        if (!slide) {
            tracker.value = (float)video.frame / video.frameCount;
        }  
    }

    public void OnPointerDown(PointerEventData a) {
        slide = true;
    }

    public void OnPointerUp(PointerEventData a) {
        float frame = (float)tracker.value * video.frameCount;
        video.frame = (long)frame;
        slide = false;
    }
}
