using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingDisplay : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        
        if (a.activeSelf == false)
        {
            a.SetActive(true);
            b.SetActive(true);
        }
        else
        {
            a.SetActive(false);
            b.SetActive(false);
        }
    }
}
