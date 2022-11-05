using UnityEngine;

public class Judgment : MonoBehaviour
{
    public new GameObject gameObject;
    public new AudioClip sound;
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
            Debug.Log("ヒット！！");☀
            gameObject.SetActive(true);
            AudioSource.PlayClipAtPoint(sound, transform.position);
            

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
