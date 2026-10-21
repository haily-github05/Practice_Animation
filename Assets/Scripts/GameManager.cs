
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;

    public TMP_Text Title;
    public TMP_Text Message;

    public Button ContinueButton;
    public Button RestartButton;

    void Start()
    {
        // An popup khi bat dau
        GameMenu.enabled = false;

        // Noi dung popup
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want continue?";

        // Noi dung 2 nut
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    public void ShowPopup()
    {
        GameMenu.enabled = true;
    }

    public void NextScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(
            SceneManager.GetActiveScene().name
        );
    }

    public void EnterNextScene()
    {
        Debug.Log("Enter button clicked!");
        SceneManager.LoadScene("_Scene_1");
    }

}
