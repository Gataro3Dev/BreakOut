using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Lives = 3;
    public int Bricks = 26;
    public float ResetDelay;
    public Text LivesText;
    public GameObject GameOver;
    public GameObject YouWin;
    public GameObject BricksPrefabs;
    public GameObject Paddle;

    public static GameManager Instance;

    private GameObject clonePaddle;

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        Setup();
    }

    public void Setup()
    {
        if (Paddle != null)
            clonePaddle = Instantiate(Paddle, Paddle.transform.position, Quaternion.identity) as GameObject;

        if (BricksPrefabs != null)
            Instantiate(BricksPrefabs, BricksPrefabs.transform.position, Quaternion.identity);
    }

    void CheckGameOver()
    {
        if (Bricks <= 1)
        {
            if (YouWin != null)
            {
                YouWin.SetActive(true);
                Time.timeScale = 0.25f;
                Invoke("Reset", ResetDelay);
            }
        }

        if (Lives < 1)
        {
            if (GameOver != null)
            {
                GameOver.SetActive(true);
                Time.timeScale = 0.25f;
                Invoke("Reset", ResetDelay);
            }
        }
    }

    void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoseLife()
    {
        Lives--;
        if (LivesText != null)
            LivesText.text = "Lives: " + Lives;
        Destroy(clonePaddle);
        Invoke("SetupPaddle", ResetDelay);
        CheckGameOver();
    }

    private void SetupPaddle()
    {
        if (Paddle != null)
            clonePaddle = Instantiate(Paddle, Paddle.transform.position, Quaternion.identity) as GameObject;
    }

    public void DestroyBrick()
    {
        Bricks--;
        CheckGameOver();
    }

}
