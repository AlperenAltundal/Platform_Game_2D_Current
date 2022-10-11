using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class CountHandler : MonoBehaviour
{
    private LevelManager levelManager;
    private int scoreValue;

    private void Awake()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        scoreValue = levelManager.scoreValue;
    }
}
