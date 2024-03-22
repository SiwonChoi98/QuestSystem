using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNPC : MonoBehaviour
{
    public QuestObject QuestObject;

    private void Start()
    {
        AddQuestEvent();
    }

    private void OnDestroy()
    {
        RemoveQuestEvent();
    }

    //퀘스트 이벤트 등록
    private void AddQuestEvent()
    {
        QuestManager.Instance.OnCompletedQuest += OnCompletedQuest;
    }
    //퀘스트 이벤트 해제
    private void RemoveQuestEvent()
    {
        QuestManager.Instance.OnCompletedQuest -= OnCompletedQuest;
    }
    
    //상호작용
    public void Interact(GameObject gameObject)
    {
        QuestManager.Instance.UpdateQuestStatus(QuestObject);
    }
    
    private void OnCompletedQuest(QuestObject questObject)
    {
        //퀘스트 ID, 완료 상태 체크
        if (questObject.Data.Id == this.QuestObject.Data.Id &&
            questObject.QuestStatusType == QuestStatusType.Completed)
        {
            //SUCESS
        }
    }
}
