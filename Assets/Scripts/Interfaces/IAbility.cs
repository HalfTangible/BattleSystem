using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAbility
{
    List<IBehavior> behaviors { get; set; }
    int momentumCost { get; set; }

    
}
