using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Quest", menuName = "Quest System/Quests/New Quest")]
public class QuestObject : ScriptableObject
{
    public QuestData Data = new QuestData();
    public QuestStatusType QuestStatusType;
}
