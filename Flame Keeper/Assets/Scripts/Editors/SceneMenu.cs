﻿#if UNITY_EDITOR
using System;
using System.IO;

using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class SceneMenu
{
    [MenuItem("Scenes/Root", false, 1)]
    public static void GoToRootScene()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Root.unity");
    }

    [MenuItem("Scenes/MainMenu", false, 1)]
    public static void GoToMainMenuScene()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/MainMenu.unity");
    }

    [MenuItem("Scenes/Tutorial", false, 1)]
    public static void GoToTutorialScene()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Tutorial.unity");
    }

    [MenuItem("Scenes/Level 1", false, 1)]
    public static void GoToLevelOne()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/Level1.unity");
    }

    [MenuItem("Scenes/New Level 1", false, 1)]
    public static void GoToNewLevelOne()
    {
        EditorSceneManager.OpenScene("Assets/Scenes/NewLevel1.unity");
    }
}
#endif
