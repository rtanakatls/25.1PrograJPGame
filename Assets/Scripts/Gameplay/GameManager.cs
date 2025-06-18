using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance {  get { return instance; } }

    [SerializeField] private TextMeshProUGUI timerText;
    private float timer;

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {
        timer += Time.deltaTime;
        timerText.text = $"Timer: {timer}";
    }

    public void GameOver()
    {
        GameData.score = Mathf.CeilToInt(timer);
        SceneManager.LoadScene("GameOverScene");
    }
}
