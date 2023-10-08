using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AxieMons/Configs/MonsterConfigs", fileName = "MonsterConfigs")]
public class MonsterConfigs : ScriptableObject
{

}

[System.Serializable]
public class MonsterConfig
{
    [SerializeField] private int _id;
    [SerializeField] private int level;
}
