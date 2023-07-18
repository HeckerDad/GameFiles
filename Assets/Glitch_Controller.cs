using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glitch_Controller : MonoBehaviour
{
    public Material themat;
    public float noiseamount;
    public float glitchstrength;
    public float scanlinesstrength;

    // Update is called once per frame
    void Update()
    {
        themat.SetFloat("_NoiseAmount", noiseamount);
        themat.SetFloat("_GlitchStrenth", glitchstrength);
        themat.SetFloat("_ScanLinesStrength", scanlinesstrength);
    }
}
