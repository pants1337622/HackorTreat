using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opacity : MonoBehaviour
{
    public string buttontag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == buttontag)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f,0f,0f,0.25f)
        }
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == buttontag)
        {
            this.gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f)
        }
    }
}
