using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobm : MonoBehaviour
{
    public LayerMask playerlayer;
    public float damage, time, radius;
    public GameObject explodeeffect;
    public bool explode;
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
            kaboom();
        }
    }
    void kaboom()
    {
        Instantiate(explodeeffect, transform.position, Quaternion.identity);
        Collider2D[] bob = Physics2D.OverlapCircleAll(transform.position, radius, playerlayer);
        foreach (Collider2D monkeyer in bob)
        {
            NewBehaviourScript asdasd = monkeyer.GetComponent<NewBehaviourScript>();
            asdasd.health -= damage;
        }
        Destroy(gameObject, 0.05f);
    }
}
