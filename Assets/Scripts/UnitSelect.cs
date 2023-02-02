using UnityEngine;

public class UnitSelect : MonoBehaviour
{
    private GameObject[] character;
    private int selectedCharacter;
    private GameObject spown;
    private const string SAVE_PREF = "selectedCharacter";
    private const string FOLDER_PREFAB = "Prefabs";

    private void Awake() => SelectCharacterEventSystem.generatorEvents.AddListener(GenerateRandomCharacter);
    private void Start() => GeneratorCharaterMass();
    private void GeneratorCharaterMass() => character = Resources.LoadAll<GameObject>(FOLDER_PREFAB);
    public void GenerateRandomCharacter()
    { 
         if (spown != null) Destroy(spown);
         GenerateCharacter generate = new GenerateCharacter(character.Length);
         selectedCharacter = generate.numberCharacter;
         spown =   Instantiate(character[selectedCharacter],Vector3.zero,Quaternion.identity);
         PlayerPrefs.SetInt(SAVE_PREF, selectedCharacter);
    }
 
  

}
