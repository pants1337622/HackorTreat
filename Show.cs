using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    public int room;
    public RoomManager roomscript;
    public bool show;
    // Start is called before the first frame update
    void Start()
    {
        show = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(room == roomscript.currentroom && show == true)
        {
            this.gameObject.SetActive(true);
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
}
