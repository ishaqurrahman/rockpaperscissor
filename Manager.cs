using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI Result;
    public Image AIchoice;
    public Image Mychoice;
    
    public string[] Choices;
    public Sprite Rock, Paper, Scissors;


  

    public void Play(string myChoice)
    {
        string  randomChoice = Choices[Random.Range(0, Choices.Length)];

        switch (randomChoice)
        
        {

            
            case "Rock":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "Tie";

                        Mychoice.sprite = Rock;
                        break;

                    case "Paper":
                        Result.text = "You Win";
                        Playerscorescript.pscoreValue += 1;
                        Mychoice.sprite = Paper;
                        break;

                    case "Scissors":
                        Result.text = "You Lose";
                        Aiscorescript.aiscoreValue += 1;
                        Mychoice.sprite = Scissors;
                        break;
                    
                }
                
                AIchoice.sprite = Rock;
                break;
            
            case "Paper":
                switch (myChoice)
                {
                    case "Rock":
                        Result.text = "You Lose";
                        Aiscorescript.aiscoreValue += 1;
                        Mychoice.sprite = Rock;
                        break;

                    case "Paper":
                        Result.text = "Tie";
                        
                        Mychoice.sprite = Paper;
                        break;

                    case "Scissors":
                        Result.text = "You Win";
                        Playerscorescript.pscoreValue += 1;
                        Mychoice.sprite = Scissors;
                        break;
                    
                }
                
                AIchoice.sprite = Paper;
                break;
                

            case "Scissors":
            switch (myChoice)
                {
                    case "Rock":
                        Result.text = "You Win";
                        Playerscorescript.pscoreValue += 1;
                        Mychoice.sprite = Rock;
                        break;

                    case "Paper":
                        Result.text = "You Lose";
                        Aiscorescript.aiscoreValue += 1;
                        Mychoice.sprite = Paper;
                        break;

                    case "Scissors":
                        Result.text = "Tie";
                        
                        Mychoice.sprite = Scissors;
                        break;
                    
                }
                
                AIchoice.sprite = Scissors;
                break;
                


        }
    
    }

    public void Reset() {
        Playerscorescript.pscoreValue = 0;
        Aiscorescript.aiscoreValue = 0;
    }

    
 
}
