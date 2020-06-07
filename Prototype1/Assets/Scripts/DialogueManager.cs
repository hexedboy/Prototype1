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
    [SerializeField] Button optBut1;
    [SerializeField] Button optBut2;
    [SerializeField] Button optBut3;
    [SerializeField] GameObject btnsPanel;
    private bool opts = false;
    private string npcName;
    private string[] currentDialogue;
    private string[] nextDialogue;
    public int sentCount = 0;
    public string npcCharName;
    //public int diaNum = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }
    
    

    public void StartDialogue(Dialogue dialogue, GameObject npc)
    {
        Debug.Log("starting convo with" + dialogue.name);

        //sentCount = 0;
        speechbubble.SetActive(true);
        name.text = dialogue.name;
        sentences.Clear();

        npcCharName = dialogue.name;

        npcName = npc.name;

        if (npc.GetComponent<NPCManager>().options == true)
        {
            if (dialogue.options.Length == 1)
            {
                optBut1.GetComponentInChildren<Text>().text = dialogue.options[0];
                
            }
            if (dialogue.options.Length == 2)
            {
                optBut1.GetComponentInChildren<Text>().text = dialogue.options[0];
                optBut2.GetComponentInChildren<Text>().text = dialogue.options[1];
                
            }
            if (dialogue.options.Length == 3)
            {
                optBut1.GetComponentInChildren<Text>().text = dialogue.options[0];
                optBut2.GetComponentInChildren<Text>().text = dialogue.options[1];
                optBut3.GetComponentInChildren<Text>().text = dialogue.options[2];
            }
            
            //opts = true;
        }

        //diaNum = dialogue.num;

        //if (diaNum == 0)
        if (npc.GetComponent<NPCManager>().diaNum == 0)
        {
            currentDialogue = dialogue.sentences;
            nextDialogue = dialogue.sentences1;

            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 1)
        {
            currentDialogue = dialogue.sentences1;
            nextDialogue = dialogue.sentences2;
            if (nextDialogue.Length >0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
            
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 2)
        {
            currentDialogue = dialogue.sentences2;
            nextDialogue = dialogue.sentences3;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 3)                        //NORMAL TEXT ENDS HERE
        {
            currentDialogue = dialogue.sentences3;
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 4)                        //OPTION 1 STARTS HERE
        {
            currentDialogue = dialogue.sentences4;
            nextDialogue = dialogue.sentences5;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 5)
        {
            currentDialogue = dialogue.sentences5;
            nextDialogue = dialogue.sentences6;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 6)
        {
            currentDialogue = dialogue.sentences6;
            nextDialogue = dialogue.sentences7;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 7)                    //OPTION 1 ENDS HERE
        {
            currentDialogue = dialogue.sentences7;
            
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 8)                //OPTION 2 STARTS HERE
        {
            currentDialogue = dialogue.sentences8;
            nextDialogue = dialogue.sentences9;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 9)
        {
            currentDialogue = dialogue.sentences9;
            nextDialogue = dialogue.sentences10;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 10)
        {
            currentDialogue = dialogue.sentences10;
            nextDialogue = dialogue.sentences11;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 11)                 //OPTION 2 ENDS HERE
        {
            currentDialogue = dialogue.sentences11;
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 12)               //OPTION 3 STARTS HERE
        {
            currentDialogue = dialogue.sentences12;
            nextDialogue = dialogue.sentences13;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 13)
        {
            currentDialogue = dialogue.sentences13;
            nextDialogue = dialogue.sentences14;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 14)
        {
            currentDialogue = dialogue.sentences14;
            nextDialogue = dialogue.sentences15;
            if (nextDialogue.Length > 0)
            {
                //dialogue.num++;
                GameObject.Find(npc.name).GetComponent<NPCManager>().diaNum++;
            }
        }
        else if (npc.GetComponent<NPCManager>().diaNum == 15)                       //OPTION 3 ENDS HERE
        {
            currentDialogue = dialogue.sentences15;
        }
        //CHECKING DIALOGUE


        foreach (string sentence in currentDialogue)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();

    }



    public void DisplayNextSentence()
    {
        // if (GameObject.Find(npcName).GetComponent<NPCManager>().hasFriend == true)
       // {
       //     GameObject.Find(npcName).GetComponentInChildren<FriendHolder>().TriggerFriend();
       // }

        if (sentences.Count == 0 && GameObject.Find(npcName).GetComponent<NPCManager>().options == false)
        {
            EndDialogue();
            return;
        }
        else if (sentences.Count == 0 && GameObject.Find(npcName).GetComponent<NPCManager>().options == true)
        {
            //opts = false;
            //GameObject.Find(npcName).GetComponent<NPCManager>().options = false;
            GameObject.Find(npcName).GetComponent<NPCManager>().optLock = true;

            btnsPanel.SetActive(true);
            optBut1.gameObject.SetActive(true);
            optBut2.gameObject.SetActive(true);
            optBut3.gameObject.SetActive(true);
            return;
        }


        string sentence = sentences.Dequeue();
        //dialogueText.text = sentence;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        Debug.Log(sentence);

        if (GameObject.Find(npcName).GetComponent<FriendManager>() == true)
        {
            sentCount++;
            GameObject.Find(npcName).GetComponent<FriendManager>().ChangeName();
        }
        



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
            //do nothing i guess
        }

       
        player.GetComponent<CharacterController>().talking = false;
        //player.GetComponent<CharacterController>().timePressed = 0;
        speechbubble.SetActive(false);
        //optBut1.gameObject.SetActive(false);
        //optBut2.gameObject.SetActive(false);
       // optBut3.gameObject.SetActive(false);
    }
    
}
