using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AxieMons/Configs/MonsterConfigs", fileName = "MonsterConfigs")]
public class MonsterConfigs : ScriptableObject
{
    #region Singleton

    private static MonsterConfigs _instance;

    public static MonsterConfigs Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = LoaderUtility.Instance.GetAsset<MonsterConfigs>("Configs/MonsterConfigs");
            }
            return _instance;
        }
    }

    #endregion

    [SerializeField] private List<MonsterConfig> monsters;

    public List<MonsterConfig> GetAllMonsterConfigs()
    {
        return new List<MonsterConfig>(this.monsters);
    }

    public MonsterConfig GetMonsterConfigById(int id)
    {
        return this.monsters.Find(x => x.Id == id);
    }

    public bool TryGetMonsterConfigById(int id, out MonsterConfig config)
    {
        config = this.GetMonsterConfigById(id);
        return config != null;
    }
}

[System.Serializable]
public class MonsterConfig
{
    [SerializeField] private int _id;
    [SerializeField] private int level;
    [SerializeField] private List<StatModel> stats;

    public int Id => this._id;
    public int Level => this.level;

    public List<StatModel> GetAllStats()
    {
        return new List<StatModel>(this.stats); 
    }

    public StatModel GetStatByType(StatType type)
    {
        return this.stats.Find(x => x.Type == type);
    }

    public bool TryGetStatByType(StatType type, out StatModel stat)
    {
        stat = this.GetStatByType(type);
        return stat != null;
    }
}
