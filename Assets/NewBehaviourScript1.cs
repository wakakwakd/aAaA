using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public string playerstirng, groundstring, bulletstirng;
    public float health;
    public int time;
    public SpriteRenderer asd;
    public Color aaaaa, normalcolor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == bulletstirng)
        {
            health -= 1;
            asd.color = aaaaa;
            Countdown(time);
            asd.color = normalcolor;
            Destroy(gameObject);
        }
        else if(collision.transform.tag == playerstirng || collision.transform.tag == groundstring)
        {
            Destroy(gameObject, 0.05f);
        }
    }
    IEnumerator Countdown(float seconds)
    {
        float counter = seconds;
        while (counter > 0)
        {
            yield return new WaitForSeconds(seconds);
            counter--;
        }
    }

}
