using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Aiscorescript : MonoBehaviour
{
    public static int aiscoreValue = 0;
    public TextMeshProUGUI AIscore;
    [SerializeField] private Gameresult myGameResult;
    [SerializeField] private MainMenu myMainMenu;   
    [SerializeField] private Gameobject myGameObject; 


    // Start is called before the first frame update
    void Start()
    {
        AIscore = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        AIscore.text = " " + aiscoreValue;

        if(aiscoreValue == 5)
        {
            string message = "You Lose\nYour City Got Nuked";
            myGameResult.gameObject.SetActive(true);
            myGameResult.restartButton.onClick.AddListener(RestartClicked);
            myGameResult.mainmenutButton.onClick.AddListener(MainMenuClicked);
            myGameResult.messageResult.text = message;
            myGameResult.messageResult.color = Color.red;
        }
    }

     private void RestartClicked()
    {
        myGameResult.gameObject.SetActive(false);
        Playerscorescript.pscoreValue = 0;
        Aiscorescript.aiscoreValue = 0;
    }
    
    private void MainMenuClicked()
    {
        myGameResult.gameObject.SetActive(false);
        myGameObject.gameObject.SetActive(false);
        myMainMenu.gameObject.SetActive(true);
        Playerscorescript.pscoreValue = 0;
        Aiscorescript.aiscoreValue = 0;
    }
}
