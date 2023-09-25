using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayManager : MonoSingleton<GameplayManager>
{
    private void OnEnable()
    {
        GameDataManager.AssignGameDataLoadedCallback(this.StartGame);
    }

    private void OnDisable()
    {
        GameDataManager.UnassignGameDataLoadedCallback(this.StartGame);
    }

    public void StartGame()
    {
        Debug.Log("Start game!");
    }

    private void SelectPlayMode()
    {

    }

    private void SelectStartZone()
    {

    }

    private void SelectMonsters()
    {

    }
}
