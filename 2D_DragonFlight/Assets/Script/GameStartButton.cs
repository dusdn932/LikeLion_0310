using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStartButton : MonoBehaviour
{
    float fadeCount = 0;
    public Image image;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            
            
            SceneManager.LoadScene("SampleScene");
        }
    }
    
}

