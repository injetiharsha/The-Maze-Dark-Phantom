using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class FinishController : MonoBehaviour
{
    public TMP_Text ResultText, TimeText;

    void Start()
    {
        ResultText.text = $"Well done, {PlayerData.PlayerName}!";
        float t = PlayerData.FinishTime;
        int minutes = (int)(t / 60);
        int seconds = (int)(t % 60);
        TimeText.text = $"Your time: {minutes:00}:{seconds:00}";
    }
}
