using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BattlePhase;
using Types;

public class Heal : IBehavior
{

    public int baseAmount { get; set; }
    //public OnPhase phase { get; set; }
    //public IPhase phase { get; set; }
    public OnPhase phase;

    public bool Execute(CharacterSheet user, CharacterSheet target) {
        int healing = baseAmount;
        
        target.HealedBy(healing);
        return true;
    }

    public OnPhase getPhase()
    {
        return phase;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
