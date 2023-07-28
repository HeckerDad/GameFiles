using UnityEngine;
using UnityEngine.Playables;

public class ClickDetection : MonoBehaviour
{
    public Camera thecamera;
    public GameObject MagicCircle;
    public Animator bookanimator;
    public BoxCollider jumpcollider;
    public PlayableDirector Cutscene_2director;
    public GameObject PlayerController;
    public GameObject torch;
    public GameObject monsterhead;
    public static bool dooropen = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Check for left mouse button click
        {
            Ray ray = thecamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Check if the clicked object has a collider
                if (hit.collider != null)
                {
                    GameObject clickedObject = hit.collider.gameObject;
                    Debug.Log("Clicked object: " + clickedObject.name);
                    print(clickedObject.name);
                    if (clickedObject.name.Contains("door"))
                    {
                        clickedObject.GetComponentInParent<Animator>().SetBool("Open", true);
                        dooropen = true;
                    }
                    if (clickedObject.name.Contains("table"))
                    {
                        PlayerController.SetActive(false);
                        Cutscene_2director.Play();
                        torch.SetActive(true);
                        monsterhead.SetActive(true);
                    }
                }
            }
        }
    }
}