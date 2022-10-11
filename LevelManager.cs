using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private Text scoreValueText;
    public int scoreValue;
    [SerializeField] bool Leventmi;

    private void Start()
    {
        if (Leventmi)
        {
            scoreValueText = GameObject.Find("ScoreValue").GetComponent<Text>();
        }
    }
    public void NextLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()       
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    }
    public void ClosePanel(string parentName)
    {
        GameObject.Find(parentName).SetActive(false);
    }
    public void AddScore(int score)
    {
        scoreValue = int.Parse(scoreValueText.text);
        scoreValue += score;
        scoreValueText.text = scoreValue.ToString();     
    }
    public void Basma()
    {
        SceneManager.LoadScene(5); 
    }
    public void TekrarOyna()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
    public void Destek()
    {
        SceneManager.LoadScene(7);
    }
}
