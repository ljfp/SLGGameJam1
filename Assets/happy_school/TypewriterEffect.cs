using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI displayText;  // Reference to the UI Text component where the string will be displayed
    public string textToType = "Hello, this is Steve, I'm a software engineer. I'm looking for a girl who must be intelligent and she should be independent.";  // The text to simulate typing
    public float typingSpeed = 0.05f;  // Speed at which each character is typed
    public Button typeButton;  // The button that triggers the typing effect
    public GameObject Question1, Question2;
    private bool isTyping = false;  // To check if typing is in progress
    public GameObject ChatBox;
    public bool Once;
    public Timer timer;
    public TextMeshProUGUI Requirement1, Requirement2, Requirement3;
    public TextMeshProUGUI Check1,Check2,Check3;
    public GameObject Customer, Candidate;
    public int Count;
    public GameObject Next;
    public GameObject Checklist;
    public Button paperStack;
    public Image Table;
    void Start()
    {
        // Add the listener for the button click event
        typeButton.onClick.AddListener(StartTyping);
    }

    // Start the typing effect when button is clicked
    public void StartTyping()
    {
        if (!isTyping)  // Prevent multiple typing processes at the same time
        {
            displayText.text = "";  // Clear the current text
            StartCoroutine(TypeText());
        }
    }

    // Coroutine to simulate typing effect
    IEnumerator TypeText()
    {
        isTyping = true;

        foreach (char letter in textToType.ToCharArray())
        {
            displayText.text += letter;  // Append each letter one by one
            yield return new WaitForSeconds(typingSpeed);  // Wait for the typing speed duration
        }

        isTyping = false;
        
            //Once = true;
            Invoke("TurnOff", 2f);// Typing completed
      
    }
    public void TurnOff()
    {
        displayText.text = "";
        if (!Once)
        {
            ChatBox.SetActive(true);
        }
    }
    public void OnclickQuestion1(string text)
    {
        //Requirement1 = text;
        Invoke("TurnOnNextQuestion", 2f);
        Question1.SetActive(false);
        textToType = text;
        if (!isTyping)  // Prevent multiple typing processes at the same time
        {
            displayText.text = "";  // Clear the current text
            StartCoroutine(TypeText());
        }
    }
    public void TurnOnNextQuestion()
    {
        Question2.SetActive(true);
    }
    public void OnclickQuestion2(string text)
    {
        // Requrement2 = text;
        //Invoke("TurnOnProfiles", 2f);
        paperStack.interactable = true;
        Once = true;
        ChatBox.SetActive(false);
        timer.timerIsRunning = true;
        textToType = text;
        if (!isTyping)  // Prevent multiple typing processes at the same time
        {
            displayText.text = "";  // Clear the current text
            StartCoroutine(TypeText());
        }
    }
    public void TurnOnProfiles()
    {
        Candidate.SetActive(true);
        Customer.SetActive(true);
    }
    public void Counter()
    {
        Count++;
        if (Count == 3)
        {
            Next.SetActive(true);
        }
    }
    public void OnclickNext()
    {
        Candidate.SetActive(false);
        Customer.SetActive(false);
        Checklist.SetActive(true);
        Check1.text = Requirement1.text;
        Check2.text = Requirement2.text;
        Check3.text = Requirement3.text;
        Table.color = Color.blue;
    }
}
