using System.Collections;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public string sceneToLoad;// Scene to Load
    public string spawnPointName;
    //public GameObject spawnPoint;
    //GameState

    private void OnTriggerEnter2D(Collider2D other)
    {
        QuestManager.questManager.AddQuestItem("You Have pay off Debt", 1);
    }
}
