using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionClick : MonoBehaviour
{

    public GameObject nPC;
    public GameObject player;
    public RectTransform btnsPanel;

    //set option


    public void SetOption()
    {
        if (this.gameObject.name == "Option1")
        {
            GameObject.Find(nPC.name).GetComponent<NPCManager>().optLock = false;
            GameObject.Find(nPC.name).GetComponent<NPCManager>().options = false;
            GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum = 4;
           Debug.Log(GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum);
            //trigger dialogue using NPC's script
            nPC.GetComponent<DialgoueTrigger>().TriggerDialogue(nPC);

            btnsPanel.gameObject.SetActive(false);
            this.gameObject.SetActive(false);

            if (GameObject.Find("Option2") == true)
            {
                GameObject.Find("Option2").SetActive(false);
            }
            if (GameObject.Find("Option3") == true)
            {
                GameObject.Find("Option3").SetActive(false);
            }


           // GameObject.Find("Option2").SetActive(false);
            //GameObject.Find("Option3").SetActive(false);
            
            
        }
        else if (this.gameObject.name == "Option2")
        {
            GameObject.Find(nPC.name).GetComponent<NPCManager>().optLock = false;
            GameObject.Find(nPC.name).GetComponent<NPCManager>().options = false;
            GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum = 8;
            Debug.Log(GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum);
            //trigger dialogue using NPC's script
            nPC.GetComponent<DialgoueTrigger>().TriggerDialogue(nPC);

            btnsPanel.gameObject.SetActive(false);
            this.gameObject.SetActive(false);

            if (GameObject.Find("Option1") == true)
            {
                GameObject.Find("Option1").SetActive(false);
            }
            if (GameObject.Find("Option3") == true)
            {
                GameObject.Find("Option3").SetActive(false);
            }

            
        }
        else if (this.gameObject.name == "Option3")
        {
            GameObject.Find(nPC.name).GetComponent<NPCManager>().optLock = false;
            GameObject.Find(nPC.name).GetComponent<NPCManager>().options = false;
            GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum = 12;
            Debug.Log(GameObject.Find(nPC.name).GetComponent<NPCManager>().diaNum);
            //trigger dialogue using NPC's script
            nPC.GetComponent<DialgoueTrigger>().TriggerDialogue(nPC);

            btnsPanel.gameObject.SetActive(false);
            this.gameObject.SetActive(false);

            if (GameObject.Find("Option2") == true)
            {
                GameObject.Find("Option2").SetActive(false);
            }
            if (GameObject.Find("Option1") == true)
            {
                GameObject.Find("Option1").SetActive(false);
            }

           // GameObject.Find("Option2").SetActive(false);
            //GameObject.Find("Option1").SetActive(false);
        }
    }

    private void Start()
    {
        this.gameObject.SetActive(false);
        //btnsPanel.SetActive(false);
    }
}
