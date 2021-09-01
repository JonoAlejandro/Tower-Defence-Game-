using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bank : MonoBehaviour
{
    [SerializeField] int startingBalance = 150;
    [SerializeField] int currentBalance; 
    public int CurrentBalance { get { return currentBalance; } }

    [SerializeField] TextMeshProUGUI displayBalance;


    private void Awake()
    {
        currentBalance = startingBalance;
        UpdateDisplay();
    }

    public void deposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();

    }

    public void Withdraw(int negAmount)
    {
        currentBalance -= Mathf.Abs(negAmount);
        UpdateDisplay();
        //Lose Condition
        LoseCondition();
    }

    void UpdateDisplay()
    {
        displayBalance.text = "Gold: " + currentBalance;
    }

    private void LoseCondition()
    {
        if (currentBalance < 0)
        {
            Debug.Log("You Lose");
            Scene currentScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currentScene.buildIndex);
        }
    }
}
