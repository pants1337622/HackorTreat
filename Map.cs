using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public RoomManager room;
    public int location;
    public SpriteRenderer spriterenderer;
    public Sprite nonentered;
    public Sprite entered;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(room.enteredrooms.Contains(location))
        {
            spriterenderer.sprite = entered;
        }
        else
        {
            spriterenderer.sprite = nonentered;
        }
    }
}
