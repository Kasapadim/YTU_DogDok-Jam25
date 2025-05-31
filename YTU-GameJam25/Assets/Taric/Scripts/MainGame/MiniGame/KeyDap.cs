using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyDap : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;

    void Start()
    {

    }

    private void Update()
    {
        CodeText.text = codeTextValue;

        if (codeTextValue == safeCode)
        {
            //buraya uyar�y� yok etme ve prefeb objesini yok etme kodunu girmen laz�mke//
            SceneManager.LoadScene(0);
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }
}