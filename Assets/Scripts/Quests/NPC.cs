using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour
{
    public Quest questToGive;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            QuestManager.instance.AddQuest(questToGive);
        }
    }
}