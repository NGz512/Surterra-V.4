using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Quest
{
    public enum QuestProgress { NOT_AVAILABLE, AVAIABLE, ACCEPTED, COMPLETE, DONE}

    public string title;            // title for quest in game
    public int id;                  // ID number for the quest
    public QuestProgress progress;  // state of current quest (enum)
    public string hint;             // string from our quest Giver/Reciever
    public string congratulation;   // string from our quest Giver/Reciever
    public string summery;          // string from our quest Giver/Reciever
    public int nextQuest;           // the next quest, if there is any (chain quest)

    public string questObjective;   //name of the quest objective(also for remove)
    public int questObjectiveCount; // current number of questObjective count
    public int questObjectiveRequirement;   //required amount of quest objective objects

    // no exp Reward
    public int goldReward;
    public string itemReward;
}
