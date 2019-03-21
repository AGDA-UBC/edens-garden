using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneToLoad;
    // Update is called once per frame
    public void ChangeScene()
    {
        GameControl.control.Save();
        Application.LoadLevel(sceneToLoad);
    }
}
