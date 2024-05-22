using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;

    public Text coinText;

    public List<GameObject> enemiesInScreen;

    int coins;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            DestroyEnemiesInScreen();
        }
    }

    public void DestroyEnemiesInScreen()
    {
        foreach(GameObject Enemies in enemiesInScreen)
        {
            Destroy(Enemies);
        }
    }
    
    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
}
