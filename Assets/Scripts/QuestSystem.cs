using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    public static QuestSystem instance;

    [SerializeField] private List<Quest> listQuest = new List<Quest>();

    private void Awake()
    {
        QuestSystem.instance = this;
    }

    public bool IsQuestCompleted(Quest quest)
    {
        return quest.IsComplete;
    }

    public void AddQuest(Quest quest)
    {
        if (this.listQuest.Contains(quest)) return;

        this.listQuest.Add(quest);
    }

    public void RemoveQuest(Quest quest)
    {
        if (!this.listQuest.Contains(quest)) 
        {
            Debug.LogWarning("Don't have that quest in list!");
            return;
        }

        this.listQuest.Remove(quest);
    }

    public void CompleteQuest(Quest quest)
    {
        quest.IsComplete = true;
    }
}
