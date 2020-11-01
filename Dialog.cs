using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] beforeitemsentences;
    public string[] waitingsentences;
    public string[] afteritemsentences;
    private int index;
    public float typingSpeed;
    public bool CanInput;
    public AudioSource beep;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (textDisplay.text == beforeitemsentences[index] || textDisplay.text == waitingsentences[index] || textDisplay.text == afteritemsentences[index])
        {
            CanInput = true;
        }
    }
    IEnumerator Type(int dialog)
    {
        if(dialog == 1)
        {
            foreach(char letter in beforeitemsentences[index].ToCharArray())
            {
                beep.Play();
                textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
        if (dialog == 2)
        {
            foreach (char letter in waitingsentences[index].ToCharArray())
            {
                beep.Play();
                textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
        if (dialog == 3)
        {
            foreach (char letter in afteritemsentences[index].ToCharArray())
            {
                beep.Play();
                textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }
        }
    }

    // Update is called once per frame
    public void NextSentence(int dialog)
    {
        CanInput = false;
        if (dialog == 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type(1));
        }
        if (dialog == 2)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type(2));
        }
        if (dialog == 3)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type(3));
        }
    }
}
