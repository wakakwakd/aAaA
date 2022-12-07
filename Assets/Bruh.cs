using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bruh : MonoBehaviour
{
    public Transform Bruh__;
    public Vector2 camerapos;
    public float speed;
    public GameObject self, sound, explosion_;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(7, 20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0,0);
    }
    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        Instantiate(sound, camerapos, Quaternion.Euler(0,0,0));
        Instantiate(explosion_, transform.position, Quaternion.identity);
        Destroy(self);
    }
}
