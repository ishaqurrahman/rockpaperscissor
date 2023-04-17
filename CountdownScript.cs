using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownScript : MonoBehaviour
{
    public int countdownTime;
    public TextMeshProUGUI countdownDisplay;

    void Start()
    {
        
    }

    public void PlayGame ()
    {
        StartCoroutine(CountdownToStart());
        
        
    }
    IEnumerator CountdownToStart()
    {
        while(countdownTime > 0)
        {
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSeconds(1f);

            countdownTime--;
        }

        countdownDisplay.text = "GO!";

        yield return new WaitForSeconds(1f);

        countdownDisplay.gameObject.SetActive(false);
        
        countdownTime = 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
