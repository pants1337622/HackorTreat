using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Transform playerCharacter;
    public Player player;
    private SpriteRenderer spriteRenderer;
    public Dialog dialogscript;
    public GameObject item;
    public int type;

    public void Awake()
    {
        type = 1;
        this.spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        this.spriteRenderer.flipX = playerCharacter.transform.position.x < this.transform.position.x;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(Input.GetKeyDown(KeyCode.E) && dialogscript.CanInput == true)
            {
                if(player.inventory.Contains(item) == true)
                {
                    type = 2;
                    player.inventory.Remove(item);
                }
                dialogscript.NextSentence(type);
                if(type == 2)
                {
                    type = 3;
                }
            }
        }
    }

}
