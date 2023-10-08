using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StatModel
{
    [SerializeField] private StatType type;
    [SerializeField] private long value;

    private StatConfig _config;
    public StatConfig Config
    {
        get
        {
            if (this._config == null)
            {
                this._config = StatConfigs.Instance.GetStatConfigByType(this.type);
            }
            return this._config;
        }
    }

    public StatType Type => this.type;
    public long Value => this.value;
}
