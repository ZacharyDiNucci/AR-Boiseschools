using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour {
    public Material greyscale;

    protected static Material _greyscale;
    protected static int _haptics;
    protected static int _sounds;

    private void Start() => _greyscale = greyscale;

    public static void SetGreyscale(float num) {
        if (num < 0) num = 0;
        if (num > 1) num = 1;
        _greyscale.SetFloat("_GrayscaleAmount", num);
    }
}