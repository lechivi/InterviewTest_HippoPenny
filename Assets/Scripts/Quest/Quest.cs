using UnityEngine;

public class Quest : MonoBehaviour
{
    [SerializeField] protected string questName;
    [SerializeField] protected string description;
    [SerializeField] protected bool isComplete;

    public string QuestName { get => this.questName; set => this.questName = value; }
    public string Description { get => this.description; set => this.description = value; }
    public bool IsComplete { get => this.isComplete; set => this.isComplete = value; }

    protected virtual void Action()
    {
        //for overrite
    }
}
