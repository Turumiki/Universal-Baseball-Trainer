using UnityEngine;
public class OUT : MonoBehaviour
{
    public new GameObject gameObject;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            Debug.Log("�A�E�g�I�I�I");
            gameObject.SetActive(true);
            Invoke("Hide", 1);
        }
    }
    void Hide()
    {
        gameObject.SetActive(false);
    }
}