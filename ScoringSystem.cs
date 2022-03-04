using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class ScoringSystem : MonoBehaviour
{



    public Text TimerText;
    public float TimePlayed; 








    // Start is called before the first frame update
    void Start()
    {
        TimePlayed = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        TimePlayed += Time.deltaTime; 
        TimerText.text = TimePlayed.ToString("0"); 
    }
}
