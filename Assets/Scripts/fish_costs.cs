using UnityEngine;
using System.Linq;
using System;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/fish_costs", order = 2)]
public class fish_costs : ScriptableObject
{
   public List<int>  costs;

}