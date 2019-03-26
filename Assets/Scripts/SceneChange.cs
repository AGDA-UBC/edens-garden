using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string sceneToLoad;
    public VRStandardAssets.Utils.VRInteractiveItem clickable;


    void OnEnable()
    {
        Debug.Log(sceneToLoad);
        clickable.OnClick += ChangeScene;
    }

    void OnDisable()
    {
        clickable.OnClick -= ChangeScene;
    }

    public void ChangeScene()
    {
        Debug.Log("Trying to load scene");
        Application.LoadLevel(sceneToLoad);
    }
}
