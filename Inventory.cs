using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Player playerscript;
    public List<Sprite> images;
    public GameObject items;
    public GameObject image;
    public float space;
    public GameObject bigitem;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        bigitem.GetComponent<SpriteRenderer>().sprite = player.inventory[0].GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    public void UpdateList()
    {
        images.Clear();
        Destroy(items);
        Instantiate(items);
        foreach(GameObject item in playerscript.inventory)
        {
            images.Add(item.GetComponent<SpriteRenderer>().sprite);
            GameObject spawned = Instantiate(image, new Vector3(this.transform.position.x,this.transform.position.y, 0), Quaternion.identity);
            spawned.GetComponent<SpriteRenderer>().sprite = item.GetComponent<SpriteRenderer>().sprite;
            Vector3 pos = this.transform.position;
            pos.y = this.transform.position.y - space;
            spawned.transform.SetParent(items.transform);
            this.transform.position = pos;
        }
    }
}
