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
    
    // Start is called before the first frame update
    void Start()
    {
        optBut1 = GameObject.Find("Option1");
        optBut2 = GameObject.Find("Option2");
        optBut3 = GameObject.Find("Option3");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Talk()
    {
        this.GetComponent<DialgoueTrigger>().TriggerDialogue(this.gameObject);
        talkUI.SetActive(false);
    }

   
    private void OnTriggerEnter(Collider collider)
    {
        talkUI.SetActive(true);
        collider.GetComponent<CharacterController>().npcZone = true;
        //shove NPC's UI stuff into Dialoguemanager
        collider.GetComponent<CharacterController>().nPC = this.gameObject;

        optBut1.GetComponent<OptionClick>().nPC = this.gameObject;
       

       
    }

    private void OnTriggerExit(Collider collider)
    {
        talkUI.SetActive(false);
        collider.GetComponent<CharacterController>().npcZone = false;
        collider.GetComponent<CharacterController>().timePressed = 0;
    }
}
