using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playerscorescript : MonoBehaviour
{

    public static int pscoreValue = 0;
    public TextMeshProUGUI Pscore;
    [SerializeField] private Gameresult myGameResult;
    [SerializeField] private MainMenu myMainMenu;
    [SerializeField] private Gameobject myGameObject;
    [SerializeField] private TextMeshProUGUI myCountdown;

    
    

    // Start is called before the first frame update
    public void Start()
    {
        Pscore = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    public void Update()
    {
        Pscore.text = " " + pscoreValue;

        if(pscoreValue == 5)
        {
            string message = "You Win";
            myGameResult.gameObject.SetActive(true);
            myGameResult.restartButton.onClick.AddListener(RestartClicked);
            myGameResult.mainmenutButton.onClick.AddListener(MainMenuClicked);
            myGameResult.messageResult.text = message;
            myGameResult.messageResult.color = Color.white;
        }
    }

    /*public void FinalGameResult(string message)
    {
        if(pscoreValue == 5)
        {
            FinalGameResult("You Win");
            myGameResult.gameObject.SetActive(true);
            myGameResult.restartButton.onClick.AddListener(RestartClicked);
            myGameResult.mainmenutButton.onClick.AddListener(MainMenuClicked);
            myGameResult.messageResult.text = message;
        }
    }*/
    
    private void RestartClicked()
    {
        myGameResult.gameObject.SetActive(false);
        myCountdown.gameObject.SetActive(true);
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
