using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public List<GameObject> rooms = new List<GameObject>();
    public List<int> enteredrooms = new List<int>();
    private GameObject level;
    public int currentroom;
    // Start is called before the first frame update
    void Start()
    {
        level = Instantiate(rooms[33]);
        currentroom = 33;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoveLeft()
    {
        Destroy(level);
        level = Instantiate(rooms[currentroom - 1]);
        currentroom = currentroom - 1;
        if(enteredrooms.Contains(currentroom))
        {
            Debug.Log("In list");
        }
        else
        {
            enteredrooms.Add(currentroom);
        }
    }
    public void MoveRight()
    {
        Destroy(level);
        level = Instantiate(rooms[currentroom + 1]);
        currentroom = currentroom + 1;
        if (enteredrooms.Contains(currentroom))
        {
            Debug.Log("In list");
        }
        else
        {
            enteredrooms.Add(currentroom);
        }
    }
    public void MoveUp()
    {
        Destroy(level);
        level = Instantiate(rooms[currentroom - 7]);
        currentroom = currentroom - 7;
        if (enteredrooms.Contains(currentroom))
        {
            Debug.Log("In list");
        }
        else
        {
            enteredrooms.Add(currentroom);
        }
    }
    public void MoveDown()
    {
        Destroy(level);
        level = Instantiate(rooms[currentroom + 7]);
        currentroom = currentroom + 7;
        if (enteredrooms.Contains(currentroom))
        {
            Debug.Log("In list");
        }
        else
        {
            enteredrooms.Add(currentroom);
        }
    }
    public void Home()
    {
        Destroy(level);
        level = Instantiate(rooms[33]);
        currentroom = 33;
    }
}
