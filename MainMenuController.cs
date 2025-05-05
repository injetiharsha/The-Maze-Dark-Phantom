using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public TMP_InputField nameInput;  // must match the TMP component

    void Start()
    {
        // Hide until Play is clicked
        nameInput.gameObject.SetActive(false);

        playButton.onClick.AddListener(OnPlayClicked);
        exitButton.onClick.AddListener(OnExitClicked);
    }

    void OnPlayClicked()
    {
        nameInput.gameObject.SetActive(true);
        playButton.interactable = false;
        nameInput.ActivateInputField();
        nameInput.onSubmit.AddListener(OnNameEntered);
    }

    void OnNameEntered(string playerName)
    {
        if (string.IsNullOrWhiteSpace(playerName)) return;
        PlayerData.PlayerName = playerName;
        SceneManager.LoadScene("Game");
    }

    void OnExitClicked()
    {
        Application.Quit();
    }
}
