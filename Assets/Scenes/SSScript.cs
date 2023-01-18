using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SSScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void takeScreenshot()
    {
        string screenShotName = "screenshot" + System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".png";
        ScreenCapture.CaptureScreenshot(screenShotName);
    }

    public void sampleToList()
    {
        SceneManager.LoadScene("List Scene");
    }
}
