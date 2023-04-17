using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public void Update()
    {
    if (Playerscorescript.pscoreValue == 10)
    {
        
        
        SceneManager.LoadScene("Game Over");
    
    }

    
    
        
    

    }

}
