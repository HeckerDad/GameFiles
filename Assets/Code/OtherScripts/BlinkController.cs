using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[ExecuteInEditMode]
public class BlinkController : MonoBehaviour
{
    public float vignetteIntensity = 0.5f;
    public float vignetteSmoothness = 0.5f;

    private VolumeProfile volumeProfile;
    private Vignette vignette;

    private void Start()
    {
        // Get the Volume Profile component from the camera
        volumeProfile = GetComponent<Volume>()?.profile;
        if (volumeProfile == null)
        {
            Debug.LogError("Volume Profile not found on the main camera!");
            return;
        }

        // Get the Vignette effect from the Volume Profile
        if (!volumeProfile.TryGet(out vignette))
        {
            Debug.LogError("Vignette effect not found in the Volume Profile!");
            return;
        }

        // Call the function to set the vignette parameters
        SetVignetteParameters(vignetteIntensity, vignetteSmoothness);
    }

    private void Update()
    {
        // If you want to change the values dynamically during runtime, you can update the public variables
        // and call the SetVignetteParameters function again in the Update method.
        SetVignetteParameters(vignetteIntensity, vignetteSmoothness);
    }

    private void SetVignetteParameters(float intensity, float smoothness)
    {
        // Set the vignette intensity and smoothness
        vignette.intensity.Override(intensity);
        vignette.smoothness.Override(smoothness);
    }
}

