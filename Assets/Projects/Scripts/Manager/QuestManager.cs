using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : Singleton<QuestManager>
{
    public QuestDatabaseObject QuestDatabaseObject;
    
    //퀘스트 완료 이벤트
    public event Action<QuestObject> OnCompletedQuest;
    
    //퀘스트 진행 처리
    public void ProcessQuest(QuestType questType, int targetId)
    {
        foreach (QuestObject questObject in QuestDatabaseObject.QuestObjects)
        {
            //퀘스트 수락한 상태이고, 퀘스트 타입, 타겟 ID가 동일한지 체크
            if (questObject.QuestStatusType == QuestStatusType.Accepted &&
                questObject.Data.QuestType == questType &&
                questObject.Data.TargetId == targetId)
            {
                questObject.Data.CompletedCount++;

                if (questObject.Data.CompletedCount >= questObject.Data.TargetIdCount)
                {
                    questObject.QuestStatusType = QuestStatusType.Completed;
                    //퀘스트 완료 이벤트
                    OnCompletedQuest?.Invoke(questObject);
                }
            }
        }
    }

    //퀘스트 상태 업데이트
    public void UpdateQuestStatus(QuestObject questObject)
    {
        switch (questObject.QuestStatusType)
        {
            case QuestStatusType.None:
                questObject.QuestStatusType = QuestStatusType.Completed;
                break;
            case QuestStatusType.Accepted:
                break;
            case QuestStatusType.Completed:
                //reward
                questObject.QuestStatusType = QuestStatusType.Rewarded;
                break;
            case QuestStatusType.Rewarded:
                break;
                
        }
    }
}
