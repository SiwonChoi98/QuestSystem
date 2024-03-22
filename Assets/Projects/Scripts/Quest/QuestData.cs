using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class QuestData
{
    //퀘스트 아이디
    public int Id;
    //퀘스트 타입
    public QuestType QuestType;
    //보상 타입
    public RewardType RewardType;

    //타겟 아이디
    public int TargetId;
    //타겟 수
    public int TargetIdCount;
    //성공 타겟 수
    public int CompletedCount;

    //퀘스트 이름
    public string Title;
    //퀘스트 설명
    public string Desc;
}
