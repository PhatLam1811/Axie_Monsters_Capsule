using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] private Transform managersContainer;

    void Start()
    {
        this.OpenGame();
    }

    public void OpenGame()
    {
        DontDestroyOnLoad(this.managersContainer);

        GameDataManager.Instance.OpenGame();
    }
}
