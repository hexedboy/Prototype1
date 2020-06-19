using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public GameObject questItem;
    public bool questdone = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (questItem.GetComponent<ItemHolder>().interacted == true && questdone == false)
        {
            questdone = true;
            //this.gameObject.GetComponent<NPCManager>().options = false; //remove later

            //if (this.GetComponent<FriendManager>() == true)
            //{
              //  this.GetComponent<FriendManager>().NextSentence();
               // Debug.Log("AYYY");
            //}
        }
    }
}
