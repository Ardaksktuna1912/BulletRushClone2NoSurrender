using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextMeshUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI smallEnemyText;
    [SerializeField] TextMeshProUGUI bigEnemyText;
    int smallEnemyCount, bigEnemyCount;


    void Start()
    {
        
    }

    
    void Update()
    {
        smallEnemyCount = GameObject.FindGameObjectsWithTag("Senemy").Length;
        bigEnemyCount = GameObject.FindGameObjectsWithTag("Benemy").Length;

        smallEnemyText.text = " " + smallEnemyCount.ToString();
        bigEnemyText.text = "  " + bigEnemyCount.ToString();

    }
}
