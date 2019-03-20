using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCutscene : MonoBehaviour {


    // Scene Camera
    public GameObject mainOVRCamera;
    public GameObject marketPlaceCamera;
    public GameObject marketPlaceCamera2;
    public GameObject palaceCamera;
    public GameObject residentialCam;
    public GameObject oceanCam;


    // Teleport spots
    public GameObject eventOneTeleport;


    //Ryder's Audio
    public AudioSource line1;
    public AudioSource line2;
    public AudioSource line3;
    public AudioSource line4;
    public AudioSource line5;
    public AudioSource line6;
    public AudioSource line7;
    public AudioSource line8;
    public AudioSource line9;

    // Background Music
    public AudioSource openingMusic;
    public AudioSource gameMusic;


    void Start () {
        StartCoroutine(OpeningCamera());
        StartCoroutine(OpeningMusic());	
	}

    IEnumerator OpeningCamera()
    {
        yield return new WaitForSeconds(13);
        marketPlaceCamera2.SetActive(true);
        marketPlaceCamera.SetActive(false);
        yield return new WaitForSeconds(16);
        palaceCamera.SetActive(true);
        marketPlaceCamera2.SetActive(false);
        yield return new WaitForSeconds(14);
        oceanCam.SetActive(true);
        palaceCamera.SetActive(false);
        yield return new WaitForSeconds(10);
        residentialCam.SetActive(true);
        oceanCam.SetActive(false);
        
    }

    IEnumerator OpeningMusic()
    {
        yield return new WaitForSeconds(.5f);
        line1.Play();
        yield return new WaitWhile(() => line1.isPlaying);
        line2.Play();
        yield return new WaitWhile(() => line2.isPlaying);
        line3.Play();
        yield return new WaitWhile(() => line3.isPlaying);
        line4.Play();
        yield return new WaitWhile(() => line4.isPlaying);
        line5.Play();
        yield return new WaitWhile(() => line5.isPlaying);
        line6.Play();
        yield return new WaitWhile(() => line6.isPlaying);
        line7.Play();
        yield return new WaitWhile(() => line7.isPlaying);
        line8.Play();
        yield return new WaitWhile(() => line8.isPlaying);
        line9.Play();
        yield return new WaitWhile(() => line9.isPlaying);
        eventOneTeleport.SetActive(true);
        mainOVRCamera.SetActive(true);
        residentialCam.SetActive(false);
        // openingMusic.loop = false;
        // openingMusic.Stop();
        // gameMusic.Play();
    }
}
