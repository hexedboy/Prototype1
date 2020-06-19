using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    [SerializeField] GameObject talkUI;
    [SerializeField] GameObject optBut1;
    [SerializeField] GameObject optBut2;
   [SerializeField] GameObject optBut3;
    public int diaNum;
    public bool options = false;
    public bool optLock = false; //don't mess with this
    public bool item = false;
   // public bool hasFriend = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //optBut1 = GameObject.Find("Option1");
        //optBut2 = GameObject.Find("Option2");
        //optBut3 = GameObject.Find("Option3");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Talk()
    {
        this.GetComponent<DialgoueTrigger>().TriggerDialogue(this.gameObject);
        talkUI.SetActive(false);

        //if NPC is item or event
        if (item == true)
        {
            if (this.GetComponent<QuestManager>() == true)
            {
                if (this.GetComponent<QuestManager>().questdone == true)
                {
                    this.GetComponent<ItemHolder>().TriggerFriend();
                }
            }
            else
            {
                this.GetComponent<ItemHolder>().TriggerFriend();
            }
            
        }
    }

   
    private void OnTriggerEnter(Collider collider)
    {
        talkUI.SetActive(true);
        collider.GetComponent<CharacterController>().npcZone = true;
        //shove NPC's UI stuff into Dialoguemanager
        collider.GetComponent<CharacterController>().nPC = this.gameObject;

        optBut1.GetComponent<OptionClick>().nPC = this.gameObject;
        optBut2.GetComponent<OptionClick>().nPC = this.gameObject;
        optBut3.GetComponent<OptionClick>().nPC = this.gameObject;
       

       
    }

    private void OnTriggerExit(Collider collider)
    {
        talkUI.SetActive(false);
        collider.GetComponent<CharacterController>().npcZone = false;
        collider.GetComponent<CharacterController>().timePressed = 0;
    }
}
