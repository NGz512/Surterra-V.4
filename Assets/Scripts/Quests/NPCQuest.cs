using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCQuest : MonoBehaviour
{
    private bool isUsed = false;

    [SerializeField] GameObject panel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isUsed)
        {
            panel.gameObject.SetActive(true);
        }
    }

    public void QuestCompleted()
    {
        isUsed = true;
    }
}
