using UnityEngine;

public class LoadGamesScene : MonoBehaviour
{
    [SerializeField] private GameObject[] parentCharacter;
    private int selectedCharaterGamesScene;
    private const string SAVE_PREF = "selectedCharacter";
    private const string FOLDER_PREFAB = "Prefabs";
    void Start() => StartScene();
    private void StartScene()
    {
         LoadSelectedCharacter();

         parentCharacter = Resources.LoadAll<GameObject>(FOLDER_PREFAB);
         Instantiate(parentCharacter[selectedCharaterGamesScene], Vector3.zero, Quaternion.identity);
    }
    private void LoadSelectedCharacter() => selectedCharaterGamesScene = PlayerPrefs.GetInt(SAVE_PREF);
}
