using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NamespaceFile
{

}

namespace BattlePhase
{
    [System.Serializable]
    public enum OnPhase { OnHit, WhenHit, StartTurn, EndTurn, StartRound, EndRound, Permanent }
}


namespace Types
{
    public enum AbilityType { Active, Passive, Counter }
    public enum StatType { None, Strength, Magic, Skill, All }
}