using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class LevelChanger : MonoBehaviour
{
    public void ChangeLevel(string lvl = "")
    {
        SceneManager.LoadScene(lvl);
    }
}
