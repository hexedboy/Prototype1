using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    private Queue<string> sentences;
    [SerializeField] GameObject speechbubble;
    [SerializeField] Text dialogueText;
    [SerializeField] Text name;
    private string npcName;
    private string[] currentDialogue;
    private string[] nextDialogue;
    public int diaNum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }


    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("starting convo with" + dialogue.name);

        speechbubble.SetActive(true);
        name.text = dialogue.name;
        sentences.Clear();


        diaNum = dialogue.num;
        if (diaNum == 0)
        {
            currentDialogue = dialogue.sentences;
            nextDialogue = dialogue.sentences1;
            if (nextDialogue.Length > 0)
            {
                dialogue.num++;
            }
        }
        else if (diaNum == 1)
        {
            currentDialogue = dialogue.sentences1;
            nextDialogue = dialogue.sentences2;
            if (nextDialogue.Length >0)
            {
                dialogue.num++;
            }
            
        }
        else if (diaNum == 2)
        {
            currentDialogue = dialogue.sentences2;
            nextDialogue = dialogue.sentences3;
            if (nextDialogue.Length > 0)
            {
                dialogue.num++;
            }
        }
        else if (diaNum == 3)
        {
            currentDialogue = dialogue.sentences3;
        }

        //check if option chosen
        //if dianum == 4 then inc to 7
        //check if option chosen
        

        foreach (string sentence in currentDialogue)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }



    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(sentence);
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    private void EndDialogue()
    {
        Debug.Log("End of convo");
        if (nextDialogue.Length == 0)
        {
            
        }
        else if (diaNum <3)
        {
            //diaNum++;
        }
        
        player.GetComponent<CharacterController>().talking = false;
        //player.GetComponent<CharacterController>().timePressed = 0;
        speechbubble.SetActive(false);
    }
    
}
