using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BattlePhase;
using Types;

public class CharacterSheet : MonoBehaviour
{

    //We need all of our character's stats.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    public string name;
    public int level; //Determines power and helps determine the window where a character can Overwhelm another
    public int momentumStart; //Amount of momentum a character starts with
    public int momentum; //Current momentum
    public int motive; //Amount of momentum a character gains each turn

    //Current health and maximum health

    public int health; //Health. If it hits 0 you die.
    public int maxHealth; //Maximum health

    //Physical stats
    public int strength; //Physical attack stat
    public int defense; //Reduces damage from physical attacks

    //Magical stats
    public int magic; //Enhances offensive spells
    public int warding; //Reduces damage from magical attacks

    //Skill stats
    public int skill; //Enhances skill attacks
    public int wits; //Reduces damage from skill attacks

    /*
     Is it worth considering making strength, magic, and agility also determine things like your health, mana, and skill?
     */

    public List<IAbility> abilityList;
    public List<IBehavior> hitBy;

    // Update is called once per frame
    /*
    void Update()
    {
        
    }*/
    /*
    public string getName
    {
        get { return name; }
    }*/

    public string getName()
    {
        return name;
    }

    public int getHealth()
    {
        return health;
    }

    public int getMomentum()
    {
        return momentum;
    }

    public void addAbility(IAbility newAbility)
    {
        abilityList.Add(newAbility);
    }

    public void addAbility(List<IAbility> newAbilityList)
    {
        foreach (IAbility newAbility in newAbilityList)
        {
            addAbility(newAbility);
        }
    }

    public void spendMomentum(int amount)
    {
        momentum -= amount;
    }

    public List<IAbility> getAbilities()
    {
        return abilityList;
    }
    
    public void uses(IAbility ability)
    {
        spendMomentum(ability.momentumCost);

    }

    public void isHitBy(IAbility attack)
    {
        foreach (IBehavior behavior in attack.behaviors)
        {
            isHitBy(behavior);
        }
    }

    public void isHitBy(IBehavior behavior)
    {
        hitBy.Add(behavior);
    }

    public void effectsTrigger(OnPhase currentPhase)
    {
        /*
        foreach(IBehavior behavior in hitBy)
        {
            if(behavior.phase == currentPhase)
                behavior.Trigger(this);
        }*/
    }

    public bool canUse(IAbility ability)
    {
        //Check if the character can use the ability sent.\
        //Iterate through the ability list and see if any of them match the ability being used.
        //If yes, return True.
        return true;
    }

    public bool isValidTarget(IAbility ability, CharacterSheet user)
    {
        //Check if the ability was used on a valid target.
        return true;
    }

    public void DoDamage(int damage)
    {
        //Damage logic
        health -= damage;
    }
    public void HealedBy(int amount)
    {
        health += amount;
    }
}

/*
    public List<Ability> abilityList;
    public List<AbilityBehavior> hitBy;


    public void isHitBy(AbilityBehavior behavior)
    {
        hitBy.Add(behavior);
    }

    public void addAbility(Ability newAbility)
    {
        abilityList.Add(newAbility);
    }
 
 */