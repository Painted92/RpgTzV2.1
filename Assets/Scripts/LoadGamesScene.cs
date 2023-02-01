using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGamesScene : UnitSelect
{
    [SerializeField] private GameObject[] parentCharacter;
    private int selectedCharaterGamesScene;
    void Start() => StartScene();
    private void StartScene()
    {
        LoadSelectedCharacter();

         parentCharacter = Resources.LoadAll<GameObject>("Prefabs");
         Instantiate(parentCharacter[selectedCharaterGamesScene], Vector3.zero, Quaternion.identity);
    }
    private void LoadSelectedCharacter() => selectedCharaterGamesScene = PlayerPrefs.GetInt("selectedCharacter");
}
