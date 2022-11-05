using UnityEngine;

public class SettingDisplay : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public void OnClick()
    {

        switch (a.activeSelf)
        {
            case false:
                a.SetActive(true);
                b.SetActive(true);
                break;
            default:
                a.SetActive(false);
                b.SetActive(false);
                break;
        }
    }
}
