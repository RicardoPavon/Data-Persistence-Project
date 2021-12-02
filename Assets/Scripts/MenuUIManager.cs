using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public Button startButton;
    public InputField playerNameInputField;
         
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        // Assign player name to DataManager Instance
        DataManager.Instance.actualPlayerName = playerNameInputField.text;
        SceneManager.LoadScene("main");
    }
}
