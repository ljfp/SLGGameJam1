using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class PercentageDisplay : MonoBehaviour
{
    public Button nextButton;          // The button to trigger the percentage display
    public TMP_Text percentageText;    // TextMeshPro Text to display the percentage
    public TMP_Text Score;    // TextMeshPro Text to display the percentage
    public Image heartFill;            // UI Image component for the heart's fill (fill type should be Radial)
    public float fillSpeed = 1f;       // Speed at which the percentage and heart fill increase

    private int randomValue;

    void Start()
    {
        // Ensure the button is wired to the OnNextButtonClicked function
        nextButton.onClick.AddListener(OnNextButtonClicked);
    }

    void OnNextButtonClicked()
    {
        // Generate a random value between 70 and 100
        randomValue = Random.Range(70, 97);

        // Start incrementally displaying the percentage and filling the heart
        StartCoroutine(IncrementPercentage(randomValue));
    }

    IEnumerator IncrementPercentage(int targetValue)
    {
        int currentPercentage = 0;
        heartFill.fillAmount = 0f; // Start with an empty heart

        // Increment both the text and the heart fill amount
        while (currentPercentage < targetValue)
        {
            currentPercentage++;
            percentageText.text = currentPercentage.ToString() + "%";
            Score.text = currentPercentage.ToString() + "%";
            heartFill.fillAmount = currentPercentage / 100f;

            yield return new WaitForSeconds(0.01f / fillSpeed); // Control the speed of the animation
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene("Main");
    }
}
