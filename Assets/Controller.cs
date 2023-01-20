using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject car1;
    public GameObject car2;
    public GameObject UsernameMenu;
    public GameObject back;

    // Start is called before the first frame update
    void Start()
    {
        car1.SetActive(false);
        car2.SetActive(false);
        UsernameMenu.SetActive(true);
        back.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclickcar1()
    {
        UsernameMenu.SetActive(false);
        car1.SetActive(true);
        back.SetActive(true);
    }
    public void onclickcar2()
    {
        UsernameMenu.SetActive(false);
        car2.SetActive(true);
        back.SetActive(true);
    }

    public void backbutton()
    {
        UsernameMenu.SetActive(true);
        car1.SetActive(false);
        back.SetActive(false);
        car2.SetActive(false);
    }
}
