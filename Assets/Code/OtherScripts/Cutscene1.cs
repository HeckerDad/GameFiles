using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutscene1 : MonoBehaviour
{
    public GameObject player;
    public GameObject discam;
    public GameObject canvas;
    public static bool presse = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            discam.SetActive(false);
            player.SetActive(true);
            presse = true;
        }
    }
}
