using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] int totalNumWinChecks;
    [SerializeField] GameObject canvas;

    public static LevelManager instance;
    public int numWinChecks = 0;

    private void OnEnable()
    {
        instance = this;
        numWinChecks = 0;
    }

    private void LateUpdate()
    {
        if (numWinChecks >= totalNumWinChecks)
        {
            //canvas.SetActive(true);
            Invoke("lateCheck", 0.1f);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void lateCheck()
    {
        if (numWinChecks >= totalNumWinChecks)
        {
            canvas.SetActive(true);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
