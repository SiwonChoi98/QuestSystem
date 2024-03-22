using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestNPC : MonoBehaviour
{
    public QuestObject QuestObject;

    private void Start()
    {
        //퀘스트 끝났는지 이벤트
        QuestManager.Instance.OnCompletedQuest += OnCompletedQuest;
    }
    
    public void Interact(GameObject gameObject)
    {
        //퀘스트 상태가 None 일때 
        if (QuestObject.QuestStatusType == QuestStatusType.None)
        {
            //수락
            QuestObject.QuestStatusType = QuestStatusType.Completed;
        }
        //수락 상태
        else if (QuestObject.QuestStatusType == QuestStatusType.Accepted)
        {
            
        }
        //완료 상태
        else if (QuestObject.QuestStatusType == QuestStatusType.Completed)
        {
            //reward
            
            //보상 받은 상태로 변경
            QuestObject.QuestStatusType = QuestStatusType.Rewarded;
        }
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
