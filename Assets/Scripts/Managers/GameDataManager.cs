using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoSingleton<GameDataManager>
{
    public void OpenGame()
    {
        Debug.Log("GameDataManager open game");
    }
}
