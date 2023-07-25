using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene_2 : MonoBehaviour
{
    public Material glitch;
    public GameObject ViewPoint_1;
    public GameObject PlayerCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ViewPoint_1.SetActive(false);
        PlayerCanvas.SetActive(false);
        if (Input.GetKeyDown(KeyCode.E))
        {
            // E key was pressed
            Debug.Log("E key was pressed");
            glitch.SetFloat("_NoiseAmount", 0);
            glitch.SetFloat("_GlitchStrenth", 0);
            glitch.SetFloat("_ScanLinesStrength", 1);
        }
    }
}
