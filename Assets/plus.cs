using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class plus : MonoBehaviour
{
    public Text bruh;
    public float bruh_2, dud, time,timestart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bruh.text = bruh_2.ToString();
        time -= Time.deltaTime;
        if(time <= 0){
            bruh_2 = bruh_2 + dud;
            time = timestart;
        } 
    }
    public void plusbruh(){
        bruh_2 = bruh_2 + 1;
    }
    public void plusaminer(){
        if(bruh_2 >= 50){
            bruh_2 -= 50;
            dud = dud + 1;
        }
    }
}
