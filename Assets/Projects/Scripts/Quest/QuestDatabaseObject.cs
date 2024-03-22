using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Quest Database", menuName = "Quest System/Quests/New Quest Database")]
public class QuestDatabaseObject : ScriptableObject
{
    public QuestObject[] QuestObjects;
    
    //퀘스트 추가 시 아이디 정리
    public void OnValidate()
    {
        for (int i = 0; i < QuestObjects.Length; i++)
        {
            QuestObjects[i].Data.Id = i;
        }
    }
}
