using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderHandlers : MonoBehaviour {
    public Options options;

    public void ColorSlider(float num) => Options.SetGreyscale(num);
    public void HapticsSlider(float num) { }
    public void SoundsSlider(float num) { }
}