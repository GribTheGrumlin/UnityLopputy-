using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KebabScript : MonoBehaviour
{
    public float KebabCounter;
    private TextMeshProUGUI KebabCounterText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        KebabCounterText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        KebabCounterText.text = "Kebabs removed: " + KebabCounter;

        if (KebabCounter >= 51)
        {
            SceneManager.LoadScene("end");
        }
    }
    public void RemoveKebab()
    {
        KebabCounter++;
    }
    
}
