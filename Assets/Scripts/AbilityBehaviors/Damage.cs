using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BattlePhase;
using Types;
using System;

[System.Serializable]
public class Damage : MonoBehaviour, IBehavior
{

    //public OnPhase phase { get; set; }
    //public IPhase phase { get; set; }

    public OnPhase phase;

    //public int baseAmount { get; set; }

    public int baseAmount;

    //public float weight; //1 means it's entirely type 1, 0 means it's entirely type 2. So .3 would be 30% type 1, .8 would be 30% type 2
    public StatType type1;
    public StatType type2;

    // Start is called before the first frame update
    void Start()
    {
        //phase = OnPhase.OnHit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public OnPhase getPhase()
    {
        return phase;
    }

    public bool Execute(CharacterSheet user, CharacterSheet target)
    {
        int damage = baseAmount;
        //Blah blah stat stuff blah

        if (damage <= 0)
            damage = 1;

        target.DoDamage(damage);

        return true;
    }


    //We can do this other stuff later once we know the base of it works.


    public int ApplyStats(CharacterSheet user, CharacterSheet target)
    {
        //Firstly we determine which stats we're applying here.
        int userStat = 0;
        int targetStat = 0;

        return userStat - targetStat;
        
    }

    public int ApplyStats(int stat1, int stat2)
    {
        int difference = stat1 - stat2;

        return difference;
    }

    bool IsNone()
    {
        return false;
    }

    bool IsStrength()
    {
        return false;
    }

    bool IsMagic()
    {
        return false;
    }

    bool IsSkill()
    {
        return false;
    }
}
