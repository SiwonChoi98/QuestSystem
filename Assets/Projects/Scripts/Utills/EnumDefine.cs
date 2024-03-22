using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum QuestType
{
    //몬스터 처치
    DestroyEnemy,
    //아이템 획득
    AcquireItem
}

public enum RewardType
{
    //경험치
    Exp,
    //아이템
    Item,
    //재화
    Gold
}

public enum QuestStatusType
{
    //안받은 상태
    None,
    //수락한 상태
    Accepted,
    //완료 상태
    Completed,
    //보상 받은 상태
    Rewarded
}