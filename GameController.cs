using UnityEngine;
using TMPro;             // for TMP_Text
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public TMP_Text timerText;  // TMPro.TMP_Text

    private float startTime;
    private bool finished = false;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (finished) return;
        float t = Time.time - startTime;
        int minutes = (int)(t / 60);
        int seconds = (int)(t % 60);
        timerText.text = $"{minutes:00}:{seconds:00}";
    }

    public void OnPlayerFinished()
{
    Debug.Log("OnPlayerFinished() called—loading Finish scene");
    finished = true;  // if you’re using this to stop the timer
    PlayerData.FinishTime = Time.time - startTime;
    SceneManager.LoadScene("Finish");
}

}
