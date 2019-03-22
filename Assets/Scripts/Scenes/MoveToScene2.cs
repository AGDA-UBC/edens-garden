using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class MoveToScene2 : MonoBehaviour {

    public VRInteractiveItem teleportSpotNine;

    public VRCameraFade player;

    public GameObject residentialTeleportSpots;
    public GameObject marketplaceTeleportSpots;
    public GameObject mainOVRCamera;
    public GameObject marketPlaceCamera;

    private bool sceneHasBeenTriggered = false;

    public AudioSource backgroundMusicBefore;
    public AudioSource backgroundMusicAfter;

    public AudioSource rLine1;
    public AudioSource rLine2;
    public AudioSource rLine3;

    void OnEnable()
    {
        teleportSpotNine.OnClick += TriggerSceneChange;
    }

    void OnDisable()
    {
        teleportSpotNine.OnClick -= TriggerSceneChange;
    }

    void TriggerSceneChange()
    {
        if (ElijahScene.okayToTriggerDialogueThree && !sceneHasBeenTriggered)
        {
            StartCoroutine(ShowMarketPlace());
            StartCoroutine(ChangeScene());
            //System.Action fadeCallback = null;
            //fadeCallback = () =>
            //{
            //    Debug.Log("blahhhh");
            //    StartCoroutine(ShowMarketPlace());
            //    StartCoroutine(ChangeScene());
            //    player.OnFadeComplete -= fadeCallback;
            //    player.SetFading(false);
            //    player.FadeIn(true);
            //};
           //player.OnFadeComplete += fadeCallback;
        }
    }

    IEnumerator ShowMarketPlace()
    {
        mainOVRCamera.GetComponent<AudioListener>().enabled = false;
        mainOVRCamera.GetComponent<LineRenderer>().enabled = false;
        marketPlaceCamera.SetActive(true);
        mainOVRCamera.GetComponent<Camera>().enabled = false;
        yield return new WaitForSeconds(10);
        mainOVRCamera.GetComponent<Camera>().enabled = true;
        mainOVRCamera.GetComponent<AudioListener>().enabled = true;
        mainOVRCamera.GetComponent<LineRenderer>().enabled = true;
        marketPlaceCamera.SetActive(false);
        marketplaceTeleportSpots.SetActive(true);
        residentialTeleportSpots.SetActive(true);
        enabled = false;       
    }

    IEnumerator ChangeScene()
    {
        sceneHasBeenTriggered = true;
        residentialTeleportSpots.SetActive(false);
        backgroundMusicBefore.loop = false;
        backgroundMusicBefore.Stop();
        backgroundMusicAfter.Play();
        yield return new WaitForSeconds(.5f);
        rLine1.Play();
        yield return new WaitWhile(() => rLine1.isPlaying);
        rLine2.Play();
        yield return new WaitWhile(() => rLine2.isPlaying);
        rLine3.Play();
        yield return new WaitWhile(() => rLine3.isPlaying);
    }

}
