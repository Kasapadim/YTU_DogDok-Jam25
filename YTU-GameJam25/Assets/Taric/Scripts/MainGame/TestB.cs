using UnityEngine;

public class TestB : MonoBehaviour
{
    private GameObject uyar�Panel;

    private void Start()
    {
        uyar�Panel = GameObject.Find("2-Uyari");
        if (uyar�Panel != null)
            uyar�Panel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("EndPoint"))
        {
            if (uyar�Panel != null)
            {
                uyar�Panel.SetActive(true);
            }
        }
    }
}
