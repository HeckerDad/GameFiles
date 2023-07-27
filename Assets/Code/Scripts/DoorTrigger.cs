using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator door1;
    public Animator door2;

    private void OnTriggerEnter(Collider other)
    {
        door1.SetBool("Open", true);
        door2.SetBool("Open", true);
    }
}
