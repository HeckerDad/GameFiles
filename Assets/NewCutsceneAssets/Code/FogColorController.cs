using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class FogColorController : MonoBehaviour
{
    public Color negro;
    public Color gris;

    void Start()
    {
        RenderSettings.fog = true;
    }

    private void OnEnable()
    {
        print("Se ha activado el objeto FogController");
        RenderSettings.fogColor = gris;
    }
    private void OnDisable()
    {
        RenderSettings.fogColor = negro;
    }
}