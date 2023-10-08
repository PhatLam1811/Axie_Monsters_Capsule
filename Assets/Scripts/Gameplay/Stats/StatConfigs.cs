using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AxieMons/Configs/StatConfigs", fileName = "StatConfigs")]
public class StatConfigs : ScriptableObject
{
    #region Singleton

    private static StatConfigs _instance;

    public static StatConfigs Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = LoaderUtility.Instance.GetAsset<StatConfigs>("Configs/StatConfigs");
            }
            return _instance;
        }
    }

    #endregion

    [SerializeField] private List<StatConfig> stats;

    public List<StatConfig> GetAllStatConfigs()
    {
        return new List<StatConfig>(this.stats);
    }

    public StatConfig GetStatConfigByType(StatType type)
    {
        return this.stats.Find(x => x.Type == type);
    }

    public bool TryGetStatConfigByType(StatType type, out StatConfig config)
    {
        config = this.GetStatConfigByType(type);
        return config != null;
    }
}

[System.Serializable]
public class StatConfig
{
    [SerializeField] private StatType type;
    [SerializeField] private string label;
    [SerializeField] private string description;

    public StatType Type => this.type;
    public string Label => this.label;
    public string Description => this.description;
}