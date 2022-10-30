using UnityEngine;
public class Sound : MonoBehaviour
{
    public AudioClip hit;
    void OnCollisionEnter(Collision collision)
    {
        // もし衝突した相手オブジェクトの名前が"Ball"ならば
        if (collision.gameObject.name == "Ball")
        {
            //audioSource.PlayOneShot(hit);
            AudioSource.PlayClipAtPoint(hit, transform.position);
        }
    }
}
