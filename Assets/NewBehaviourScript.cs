using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public float speed, rotate_speed, health;
    public string thisscene;
    public Transform theshootplace;
    public GameObject meownbullet;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float thex = Input.GetAxisRaw("Horizontal") * rotate_speed * Time.deltaTime;
        float they = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Rotate(0, 0, thex);
        transform.Translate(Vector2.up * they);
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("work");
            Instantiate(meownbullet, theshootplace.position, transform.rotation);
        }
        if (health <= 0)
        {
            SceneManager.LoadScene(thisscene);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        bool monke = collision.collider.GetComponent<bullry>();
        if (monke !=false)
        {
            health -= 1;
        }
    }
}
