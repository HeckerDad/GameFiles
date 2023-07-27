using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public Image fadeImage;
    public float fadeSpeed = 1.0f;

    private void Start()
    {
        fadeImage.enabled = true;
        FadeInEffect();
    }

    private void OnEnable()
    {
        // Reset the alpha value to 1 when the object is enabled
        fadeImage.canvasRenderer.SetAlpha(1.0f);
    }

    private void FadeInEffect()
    {
        fadeImage.CrossFadeAlpha(0.0f, fadeSpeed, false);
    }
}
