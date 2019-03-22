using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlanScene : MonoBehaviour
{

    public VRStandardAssets.Utils.VRInteractiveItem alan;
    private bool hasBeenPlayed = false;
    public GameObject teleportSpots;
    static public bool okayToTriggerMechanic = false;

    //Ryder's Audio
    public AudioSource rLine1;
    public AudioSource rLine2;
    public AudioSource rLine3;
    public AudioSource rLine4;
    public AudioSource rLine5;
    public AudioSource rLine6;

    //Alan's Audio
    public AudioSource aLine1;
    public AudioSource aLine2;
    public AudioSource aLine3;
    public AudioSource aLine4;
    public AudioSource aLine5;
    public AudioSource aLine6;
    public AudioSource aLine7;


    void OnEnable()
    {
        alan.OnClick += TriggerDialogue;
    }

    void OnDisable()
    {
        alan.OnClick -= TriggerDialogue;
    }

    void TriggerDialogue()
    {
        if (!hasBeenPlayed && RazelScene.okayToTriggerAlan)
        {
            StartCoroutine(PlayDialogue());
        }
    }

    IEnumerator PlayDialogue()
    {
        hasBeenPlayed = true;
        teleportSpots.SetActive(false);
        yield return new WaitForSeconds(.5f);

        // Ryder - Alan!
        rLine1.Play();
        yield return new WaitWhile(() => rLine1.isPlaying);

        // Alan - Ah! 
        aLine1.Play();
        yield return new WaitWhile(() => aLine1.isPlaying);
        aLine2.Play();
        yield return new WaitWhile(() => aLine2.isPlaying);

        // Ryder - I do
        rLine2.Play();
        yield return new WaitWhile(() => rLine2.isPlaying);
        rLine3.Play();
        yield return new WaitWhile(() => rLine3.isPlaying);

        // Alan - Geez
        aLine3.Play();
        yield return new WaitWhile(() => aLine3.isPlaying);

        // Ryder - But you're still
        rLine3.Play();
        yield return new WaitWhile(() => rLine3.isPlaying);

        // Alan - I'm a tween
        aLine3.Play();
        yield return new WaitWhile(() => aLine3.isPlaying);

        // Ryder - Hahaha, I'm looking forward
        rLine4.Play();
        yield return new WaitWhile(() => rLine4.isPlaying);

        // Alan - Grr...
        aLine4.Play();
        yield return new WaitWhile(() => aLine4.isPlaying);
        aLine5.Play();
        yield return new WaitWhile(() => aLine5.isPlaying);
        aLine6.Play();
        yield return new WaitWhile(() => aLine6.isPlaying);
        aLine7.Play();
        yield return new WaitWhile(() => aLine7.isPlaying);

        // Ryder - Calvin from...
        rLine5.Play();
        yield return new WaitWhile(() => rLine5.isPlaying);
        rLine6.Play();
        yield return new WaitWhile(() => rLine6.isPlaying);

        alan.enabled = false;
        teleportSpots.SetActive(true);
        okayToTriggerMechanic = true;


    }
}
