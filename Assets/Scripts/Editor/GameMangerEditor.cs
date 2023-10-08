using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GameMangerEditor
{
    [MenuItem("AxieMons/Start Game")]
    public static void EditorStartGame()
    {
        HomeScene.Instance.Click_StartGame();
    }
}
