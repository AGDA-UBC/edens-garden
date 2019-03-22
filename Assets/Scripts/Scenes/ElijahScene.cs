using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class ElijahScene : MonoBehaviour {

    public VRInteractiveItem elijah;
    private bool hasBeenPlayed = false;
    public GameObject teleportSpots;

    static public bool okayToTriggerDialogueThree = false;

    //Ryder's Audio
    public AudioSource rLine1;
    public AudioSource rLine2;
    public AudioSource rLine3;
    public AudioSource rLine4;
    public AudioSource rLine5;
    public AudioSource rLine6;

    //Elijah's Audio
    public AudioSource eLine1;
    public AudioSource eLine2;
    public AudioSource eLine3;
    public AudioSource eLine4;
    public AudioSource eLine5;
    public AudioSource eLine6;
    public AudioSource eLine7;
    public AudioSource eLine8;
    public AudioSource eLine9;
    public AudioSource eLine10;
    public AudioSource eLine11;
    public AudioSource eLine12;
    public AudioSource eLine13;
    public AudioSource eLine14;
    public AudioSource eLine15;
    public AudioSource eLine16;

    void OnEnable()
    {
        elijah.OnClick += TriggerDialogue;
    }

    void OnDisable()
    {
        elijah.OnClick -= TriggerDialogue;
    }

    void TriggerDialogue()
    {
        if (!hasBeenPlayed)
        {
            StartCoroutine(PlayDialogue());
        }
    }

    IEnumerator PlayDialogue()
    {
        hasBeenPlayed = true;
        teleportSpots.SetActive(false);
        yield return new WaitForSeconds(.5f);
        // Elijah
        eLine1.Play();
        yield return new WaitWhile(() => eLine1.isPlaying);
        eLine2.Play();
        yield return new WaitWhile(() => eLine2.isPlaying);
        // Ryder
        rLine1.Play();
        yield return new WaitWhile(() => rLine1.isPlaying);
        // Elijah
        eLine3.Play();
        yield return new WaitWhile(() => eLine3.isPlaying);
        eLine4.Play();
        yield return new WaitWhile(() => eLine4.isPlaying);
        eLine5.Play();
        yield return new WaitWhile(() => eLine5.isPlaying);
        // Ryder
        rLine2.Play();
        yield return new WaitWhile(() => rLine2.isPlaying);
        // Elijah
        eLine6.Play();
        yield return new WaitWhile(() => eLine6.isPlaying);
        eLine7.Play();
        yield return new WaitWhile(() => eLine7.isPlaying);
        eLine8.Play();
        yield return new WaitWhile(() => eLine8.isPlaying);
        // Ryder
        rLine3.Play();
        yield return new WaitWhile(() => rLine3.isPlaying);
        // Elijah
        eLine9.Play();
        yield return new WaitWhile(() => eLine9.isPlaying);
        eLine10.Play();
        yield return new WaitWhile(() => eLine10.isPlaying);
        eLine11.Play();
        yield return new WaitWhile(() => eLine11.isPlaying);
        eLine12.Play();
        yield return new WaitWhile(() => eLine12.isPlaying);
        eLine13.Play();
        yield return new WaitWhile(() => eLine13.isPlaying);
        // Ryder
        rLine4.Play();
        yield return new WaitWhile(() => rLine4.isPlaying);
        // Elijah
        eLine14.Play();
        yield return new WaitWhile(() => eLine14.isPlaying);
        eLine15.Play();
        yield return new WaitWhile(() => eLine15.isPlaying);
        // Ryder
        rLine5.Play();
        yield return new WaitWhile(() => rLine5.isPlaying);
        rLine6.Play();
        yield return new WaitWhile(() => rLine6.isPlaying);
        // Elijah
        eLine16.Play();
        yield return new WaitWhile(() => eLine16.isPlaying);



        teleportSpots.SetActive(true);
        okayToTriggerDialogueThree = true;
    }
}
