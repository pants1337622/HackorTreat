using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryDescription : MonoBehaviour
{
    public List<string> descriptions = new List<string>();
    public TextMeshProUGUI descriptioninv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "invitem")
        {
            if(collision.GetComponent<SpriteRenderer>().sprite.name == "pencil")
            {
                descriptioninv.text = descriptions[0];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "tool")
            {
                descriptioninv.text = descriptions[1];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "game")
            {
                descriptioninv.text = descriptions[2];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "remix")
            {
                descriptioninv.text = descriptions[3];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "win")
            {
                descriptioninv.text = descriptions[4];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "feather")
            {
                descriptioninv.text = descriptions[5];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "shoes")
            {
                descriptioninv.text = descriptions[6];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "brush")
            {
                descriptioninv.text = descriptions[7];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "light")
            {
                descriptioninv.text = descriptions[8];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "boost")
            {
                descriptioninv.text = descriptions[9];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "home")
            {
                descriptioninv.text = descriptions[10];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "smessage")
            {
                descriptioninv.text = descriptions[11];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "meat")
            {
                descriptioninv.text = descriptions[12];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "wrench")
            {
                descriptioninv.text = descriptions[13];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "cd")
            {
                descriptioninv.text = descriptions[14];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "sgem")
            {
                descriptioninv.text = descriptions[15];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "dmessgae")
            {
                descriptioninv.text = descriptions[16];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "bgmessage")
            {
                descriptioninv.text = descriptions[17];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "ggmessage")
            {
                descriptioninv.text = descriptions[18];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "eon1")
            {
                descriptioninv.text = descriptions[19];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "eon2")
            {
                descriptioninv.text = descriptions[20];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "eon3")
            {
                descriptioninv.text = descriptions[21];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "bone")
            {
                descriptioninv.text = descriptions[22];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "bsoul")
            {
                descriptioninv.text = descriptions[23];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "gsoul")
            {
                descriptioninv.text = descriptions[24];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "rose")
            {
                descriptioninv.text = descriptions[25];
            }
            if (collision.GetComponent<SpriteRenderer>().sprite.name == "blood")
            {
                descriptioninv.text = descriptions[26];
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "invitem")
        {
            descriptioninv.text = descriptions[27];
        }
    }
}
