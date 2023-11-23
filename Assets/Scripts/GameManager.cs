using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    [SerializeField] private GameObject _gameOverCanvas;

    private void Awake()
    {
        if (instance == null) instance = this;
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        _gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
    
}
