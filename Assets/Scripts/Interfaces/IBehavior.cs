using BattlePhase;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable] //not valid on this declaration type?
public interface IBehavior
{
    public abstract bool Execute(CharacterSheet user, CharacterSheet target);
    public abstract OnPhase getPhase();
    //public IPhase phase { get; set; }
    //public int baseAmount { get; set; }
}

