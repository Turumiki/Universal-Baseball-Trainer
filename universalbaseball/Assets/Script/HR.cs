using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HR : MonoBehaviour
{
    public new GameObject gameObject;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Debug.Log("�z�[�������I�I�I�I");
            gameObject.SetActive(true);
            Invoke("Hide", 2);
        }
    }
    void Hide()
    {
        gameObject.SetActive(false);
    }
}
