using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Makecube : MonoBehaviour
{
    public float time,starttime;
    public bool rotates;
    public Vector3 bob;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time <= 0){
            Instantiate(cube, transform.position, transform.rotation);
            time = starttime;
        }
        if (rotates == true)
        {
            transform.Rotate(bob * Time.deltaTime);
        }
    }
}
