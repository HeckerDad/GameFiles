using UnityEngine;

public class JumpScareTrigger : MonoBehaviour
{
    public static bool didcollide = false;
    private void OnTriggerEnter(Collider other)
    {
        didcollide = true;
        print(other);
        print(didcollide);
    }
}