using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoSingleton<GameDataManager>
{
    #region Callbacks

    private static System.Action OnGameDataLoaded;

    public static void AssignGameDataLoadedCallback(System.Action callback)
    {
        OnGameDataLoaded -= callback;
        OnGameDataLoaded += callback;
    }

    public static void UnassignGameDataLoadedCallback(System.Action callback)
    {
        OnGameDataLoaded -= callback;
    }

    #endregion

    public void OpenGame()
    {
        Debug.Log("GameDataManager open game");

        OnGameDataLoaded?.Invoke();
    }
}
