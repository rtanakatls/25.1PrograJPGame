using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveUsernameView : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInputField;
    [SerializeField] private Button continueButton;
    [SerializeField] private string nextScene;
    private void Start()
    {
        continueButton.onClick.AddListener(SaveUsername);
    }

    private void SaveUsername()
    {
        GameData.username=usernameInputField.text;
        SceneManager.LoadScene(nextScene);
    }
}
