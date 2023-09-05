using BattlePhase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBehavior
{
    public abstract bool Execute(CharacterSheet user, CharacterSheet target);
    OnPhase phase { get; set; }
}

