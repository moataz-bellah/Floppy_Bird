using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public float delayTime = 0.5f;
    public GameObject completeGameUI;
    public TextMeshPro currentScore;
    public TextMeshPro totalScore;
    public void GameOver()
    {
        if (!gameOver)
        {
            gameOver = true;
            Invoke("Restart",delayTime);

        }
    }
    public void GameComplete()
    {
        
        currentScore.text = "Score: " + totalScore.text;
        completeGameUI.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
