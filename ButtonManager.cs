using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject map;
    public GameObject inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OpenMap()
    {
        map.SetActive(true);
    }
    public void CloseMap()
    {
        map.SetActive(false);
    }
    public void Openinventory()
    {
        inventory.SetActive(true);
    }
    public void Closeinventory()
    {
        inventory.SetActive(false);
    }
}
