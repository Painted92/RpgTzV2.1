using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelect : MonoBehaviour
{
    private GameObject[] character;
    private int selectedCharacter;
    private GameObject spown;

    private void Start() => GeneratorCharaterMass();// заполняем масив дочерними обьектами, выключаем их оставляя первый обьект включенным
    private void GeneratorCharaterMass()
    {
        character = Resources.LoadAll<GameObject>("Prefabs");
    }
    public void GenerateRandomCharacter()// включаем и выключаем обьекты по индексу пришедшему из конструктора.
    {
         DestroyObject(spown);
         GenerateCharacter generate = new GenerateCharacter(character.Length);
         selectedCharacter = generate.numberCharacter;
         spown =   Instantiate(character[selectedCharacter],Vector3.zero,Quaternion.identity);
         PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
    }
    private void DestroyObject(GameObject go)
    {
        if(go != null)
            Destroy(go);
    }
  

}
