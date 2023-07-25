using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene_2Trigger : MonoBehaviour
{
    public static bool didcollide = false;
    private void OnTriggerEnter(Collider other)
    {
        didcollide = true;
    }
}
