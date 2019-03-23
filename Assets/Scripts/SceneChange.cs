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
        clickable.OnClick += ChangeScene;
    }

    void OnDisable()
    {
        clickable.OnClick -= ChangeScene;
    }

    public void ChangeScene()
    {
        Application.LoadLevel(sceneToLoad);
    }
}
