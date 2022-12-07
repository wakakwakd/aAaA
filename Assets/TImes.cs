using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TImes : MonoBehaviour
{
    public float time;
    public int thenuber;
    public Transform[] locations;
    public GameObject spinningone, notspinningone;
    public string gamebastian;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            SceneManager.LoadScene(gamebastian);
        }
        if(time >= 100 && time <= 50)
        {
            for (int pi = 0;  pi < thenuber; pi++)
            {
                Instantiate(spinningone, locations[thenuber].position, Quaternion.identity);
            }
        }
        if (time >= 150 && time <= 100)
        {  
            
        }
    }
}
