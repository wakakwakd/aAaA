using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanorCannotbuy : MonoBehaviour
{
    public Transform counter, buybutton;
    public Image bobtheimage;
    public Color cantbuy, canbuy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Image Imageofbuybutton= buybutton.GetComponent<Image>();
        plus bob = counter.GetComponent<plus>();
        if(bob.bruh_2 <= 50){
            Imageofbuybutton.color = cantbuy;
            bobtheimage.color = cantbuy;
        }else if(bob.bruh_2 >= 50){
            Imageofbuybutton.color = canbuy;
            bobtheimage.color = canbuy;
        }
    }
}
