using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestObject : MonoBehaviour
{
    private bool inTrigger = false;

    public List<int> availableQuestIDs = new List<int>();
    public List<int> receivableQuestIDs = new List<int>();

    public GameObject questmarker;
    public Image theImage;

    public Sprite questAvailableSprite;
    public Sprite questReceivableSprite;

    void Start()
    {
        SetQuestMaker();
    }

    void SetQuestMaker()
    {
        if (QuestManager.questManager.CheckCompletedQuests(this))
        {
            questmarker.SetActive(true);
            theImage.sprite = questReceivableSprite;
            theImage.color = Color.yellow;
        }
        else if (QuestManager.questManager.CheckAvailableQuests(this))
        {
            questmarker.SetActive(true);
            theImage.sprite = questAvailableSprite;
            theImage.color = Color.yellow;
        }
        else if (QuestManager.questManager.CheckAcceptedQuests(this))
        {
            questmarker.SetActive(true);
            theImage.sprite = questReceivableSprite;
            theImage.color = Color.gray;
        }
        else
        {
            questmarker.SetActive(false);
        }
    }

    private void Update()
    {
        if(inTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            //quest ui manager

            QuestManager.questManager.QuestRequest(this);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            inTrigger = true;
        }
    }

    void OnTriggerEnterExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }
}
