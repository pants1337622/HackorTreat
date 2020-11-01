using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public int open;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(open == 2)
        {
            this.gameObject.SetActive(false);
            this.GetComponent<Show>().show = false;
        }
    }
}
