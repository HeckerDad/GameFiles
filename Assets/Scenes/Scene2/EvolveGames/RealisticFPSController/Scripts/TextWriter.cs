using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterAnimation : MonoBehaviour
{
    public float delayBetweenLetters = 0.1f; // Delay between each letter display
    public Text textElement; // Reference to the UI Text element

    private string fullText; // The complete text to display
    private bool shouldAnimate = true; // Flag to control the animation
    private bool firsttext = false; // Flag to set if text has ran
    private bool secondtime = true; //Flag so that second text runs only one time
    private Coroutine animationCoroutine; // Reference to the coroutine

    // Reference to the Cutscene1 script
    public Cutscene1 cutscene1;

    private void Start()
    {
        // Set the full text to display
        fullText = "Press E to exit veichle";

        // Start the typewriter animation
        StartTypewriterAnimation();
    }

    private void StartTypewriterAnimation()
    {
        // Stop any running animation coroutine
        if (animationCoroutine != null)
            StopCoroutine(animationCoroutine);

        // Clear the text element
        textElement.text = string.Empty;

        // Start the typewriter coroutine
        animationCoroutine = StartCoroutine(TypewriterCoroutine());
    }

    private IEnumerator TypewriterCoroutine()
    {
        // Iterate through each character in the full text
        for (int i = 0; i < fullText.Length; i++)
        {
            // Add the current character to the text element
            textElement.text += fullText[i];

            // Wait for a delay before displaying the next letter
            yield return new WaitForSeconds(delayBetweenLetters);
        }

        // Animation complete
        animationCoroutine = null;
    }

    private void Update()
    {
        if (Cutscene1.presse && shouldAnimate && !firsttext)
        {
            shouldAnimate = false;

            // Stop the current running coroutine if it exists
            if (animationCoroutine != null)
                StopCoroutine(animationCoroutine);

            // Clear the text element
            textElement.text = string.Empty;

            // Start the new typewriter animation coroutine
            animationCoroutine = StartCoroutine(AnimateNewText());
        }

        if (ClickDetection.dooropen && shouldAnimate && secondtime)
        {
            shouldAnimate = false;
            secondtime = false;

            // Stop the current running coroutine if it exists
            if (animationCoroutine != null)
                StopCoroutine(animationCoroutine);

            // Clear the text element
            textElement.text = string.Empty;

            // Start the new typewriter animation coroutine
            animationCoroutine = StartCoroutine(AnimateNewText("Get some rest"));
        }
    }

    private IEnumerator AnimateNewText(string newText = "Find Shelter")
    {
        // Clear the text element (not needed here since it's cleared before starting the coroutine)

        // Iterate through each character in the new text
        for (int i = 0; i < newText.Length; i++)
        {
            // Add the current character to the text element
            textElement.text += newText[i];

            // Wait for a delay before displaying the next letter
            yield return new WaitForSeconds(delayBetweenLetters);
        }

        // Animation complete
        shouldAnimate = true;
        firsttext = true;

        // Clear the reference to the completed coroutine
        animationCoroutine = null;

    }
}