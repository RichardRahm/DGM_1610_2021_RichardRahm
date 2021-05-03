using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public bool isGameActive;
    public static int money;
    public static int multiplier;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI gameOverText;
    public Button resetButton;
    public GameObject titleScreen;
    public GameObject moneyPrefab;
    public GameObject shopButton;
    public bool isSlowEnough;
    public int moneyToAdd = 10;
    
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0) && isGameActive == true)
        {
            money += moneyToAdd;

            moneyText.text = "Money: " + money; 
        } 
        
    }
    public void UpdateMoney(int moneyToAdd)
    {
        money += moneyToAdd;

        moneyText.text = "Money: " + money;
        

    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        shopButton.gameObject.SetActive(false);
        resetButton.gameObject.SetActive(true);
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //starts the game
    public void StartGame(int start)
    {
        isGameActive = true;
        multiplier = 1;
        money = 0;
        UpdateMoney(0);
        titleScreen.gameObject.SetActive(false);
        shopButton.gameObject.SetActive(true);
    }

 
}
