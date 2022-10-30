using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BH1 : MonoBehaviour
{
    public new GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Debug.Log("ヒット！！");
            gameObject.SetActive(true);
            Invoke("Hide", 2);
        }
        else
        {

        }
    }
    void Hide()
    {
        gameObject.SetActive(false);
    }
}
