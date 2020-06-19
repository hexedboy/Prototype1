using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FriendManager : MonoBehaviour
{
    public int[] changeWait;
    public int[] changeWait2;
    private int[,] changeWaits = new int[10,10];
    public int count;
    private int changeCount;
    public string friendName;
    [SerializeField] Text name;
    [SerializeField] DialogueManager dM;
    private bool secondset = false;
    // Start is called before the first frame update
    void Start()
    {

        int loadcount = 0;
        foreach (int wait in changeWait)
        {
            changeWaits[0, loadcount] = wait;
            loadcount++;
        }
        foreach (int wait in changeWait2)
        {
            changeWaits[1, loadcount] = wait;
            loadcount++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextSentence()
    {
        count = 0;
        //secondset = true;
        //if (changeCount<1)
        //{
         //   changeCount++;
            dM.sentCount = 0;
        //}
        
    }

    public void ChangeName()
    {
       
            if (dM.sentCount == changeWaits[changeCount,count]) //
            {
                if (name.text == friendName)
                {
                    name.text = dM.npcCharName;
                }
                else if (name.text == dM.npcCharName)
                {
                    name.text = friendName;
                }

                count++;
                dM.sentCount = 0;
                
            }
       

    }
}
