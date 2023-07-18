using UnityEngine;
using UnityEngine.UI;

public class FadeOut : MonoBehaviour
{
    public Image fadeImage;
    public float fadeSpeed = 1.0f;

    private void Start()
    {
        fadeImage.enabled = true;
        FadeOutEffect();
    }

    private void OnEnable()
    {
        // Reset the alpha value to 0 when the object is enabled
        fadeImage.canvasRenderer.SetAlpha(0.0f);
    }

    private void FadeOutEffect()
    {
        fadeImage.CrossFadeAlpha(1.0f, fadeSpeed, false);
    }
}
