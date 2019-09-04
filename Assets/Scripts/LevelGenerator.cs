using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private Transform levelPart_1;


    private void Awake()
    {
        Instantiate(levelPart_1, new Vector3 (-5, -4), Quaternion.identity);
    }


    private void spawnLevelPart(Vector3 spawnPosistion)
    {
        Instantiate(levelPart_1, spawnPosistion, Quaternion.identity);
    }

}
