using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AImove : MonoBehaviour
{
    public float speed, maxdistanceofsee;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2.MoveTowards(transform.position, target.position, maxdistanceofsee);
    }
}
