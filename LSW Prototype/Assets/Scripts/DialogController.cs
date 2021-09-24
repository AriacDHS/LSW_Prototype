using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogController : MonoBehaviour
{

    public TextMeshProUGUI dialogueText;
    public string[] sentences;
    private int index=0;
    public float dialogue_speed;
    public bool nextText = true;

    public bool isTrigger=false;
    public GameObject chatBox; 
    public GameObject shopButton;

    void Update()
    {
        if(isTrigger && !chatBox.activeSelf)
        {
            shopButton.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            isTrigger=true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            isTrigger=false;
            shopButton.SetActive(false);
            chatBox.SetActive(false);
        }
    }

    void NextSentence()
    {
        if(index <= sentences.Length - 1)
        {
            dialogueText.text = "";
            StartCoroutine(WriteSentence());
        }
    }

    IEnumerator WriteSentence()
    {
        foreach(char character in sentences[index].ToCharArray())
        {
            dialogueText.text += character;
            yield return new WaitForSeconds(dialogue_speed);
        }
        index++;
        nextText=true;
    }

    public void ChatBox()
    {
        chatBox.SetActive(true);
        if(nextText)
        {
            NextSentence();
            nextText=false;
        }
    }
}
