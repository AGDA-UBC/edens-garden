using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RazelScene : MonoBehaviour
{

    public VRStandardAssets.Utils.VRInteractiveItem razel;
    private bool hasBeenPlayed = false;
    public GameObject teleportSpots;
    static public bool okayToTriggerAlan = false;

    //Ryder's Audio
    public AudioSource rLine1;
    public AudioSource rLine2;
    public AudioSource rLine3;
    public AudioSource rLine4;
    public AudioSource rLine5;
    public AudioSource rLine6;
    public AudioSource rLine7;
    public AudioSource rLine8;
    public AudioSource rLine9;
    public AudioSource rLine10;
    public AudioSource rLine11;
    public AudioSource rLine12;
    public AudioSource rLine13;

    //Razel's Audio
    public AudioSource raLine1;
    public AudioSource raLine2;
    public AudioSource raLine3;
    public AudioSource raLine4;
    public AudioSource raLine5;
    public AudioSource raLine6;
    public AudioSource raLine7;
    public AudioSource raLine8;
    public AudioSource raLine9;
    public AudioSource raLine10;
    public AudioSource raLine11;
    public AudioSource raLine12;
    public AudioSource raLine13;
    public AudioSource raLine14;
    public AudioSource raLine15;
    public AudioSource raLine16;
    public AudioSource raLine17;
    public AudioSource raLine18;
    public AudioSource raLine19;
    public AudioSource raLine20;
    public AudioSource raLine21;
    public AudioSource raLine22;


    void OnEnable()
    {
        razel.OnClick += TriggerDialogue;
    }

    void OnDisable()
    {
        razel.OnClick -= TriggerDialogue;
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
        // Razel - You haven't paid
        raLine1.Play();
        yield return new WaitWhile(() => raLine1.isPlaying);
        raLine2.Play();
        yield return new WaitWhile(() => raLine2.isPlaying);

        // Ryder - Yup.
        rLine1.Play();
        yield return new WaitWhile(() => rLine1.isPlaying);

        // Razel - Thank you
        raLine3.Play();
        yield return new WaitWhile(() => raLine3.isPlaying);
        raLine4.Play();
        yield return new WaitWhile(() => raLine4.isPlaying);

        // Ryder - Busy Day, eh?
        rLine2.Play();
        yield return new WaitWhile(() => rLine2.isPlaying);

        // Razel
        raLine5.Play();
        yield return new WaitWhile(() => raLine5.isPlaying);
        raLine6.Play();
        yield return new WaitWhile(() => raLine6.isPlaying);

        // Ryder - Well, actually...
        rLine3.Play();
        yield return new WaitWhile(() => rLine3.isPlaying);
        rLine4.Play();
        yield return new WaitWhile(() => rLine4.isPlaying);

        // Razel - Oh! Yes, that's...
        raLine7.Play();
        yield return new WaitWhile(() => raLine7.isPlaying);
        raLine8.Play();
        yield return new WaitWhile(() => raLine8.isPlaying);
        raLine9.Play();
        yield return new WaitWhile(() => raLine9.isPlaying);

        // Ryder - I'm doing alright
        rLine5.Play();
        yield return new WaitWhile(() => rLine5.isPlaying);
        rLine6.Play();
        yield return new WaitWhile(() => rLine6.isPlaying);

        // Razel - That's good to hear!
        raLine10.Play();
        yield return new WaitWhile(() => raLine10.isPlaying);
        raLine11.Play();
        yield return new WaitWhile(() => raLine11.isPlaying);
        raLine12.Play();
        yield return new WaitWhile(() => raLine12.isPlaying);
        raLine13.Play();
        yield return new WaitWhile(() => raLine13.isPlaying);
        raLine14.Play();
        yield return new WaitWhile(() => raLine14.isPlaying);
        raLine15.Play();
        yield return new WaitWhile(() => raLine15.isPlaying);

        // Ryder - Oh, haha
        rLine7.Play();
        yield return new WaitWhile(() => rLine7.isPlaying);
        rLine8.Play();
        yield return new WaitWhile(() => rLine8.isPlaying);
        rLine9.Play();
        yield return new WaitWhile(() => rLine9.isPlaying);
        rLine10.Play();
        yield return new WaitWhile(() => rLine10.isPlaying);

        // Razel - Hmm...
        raLine16.Play();
        yield return new WaitWhile(() => raLine16.isPlaying);
        raLine17.Play();
        yield return new WaitWhile(() => raLine17.isPlaying);
        raLine18.Play();
        yield return new WaitWhile(() => raLine18.isPlaying);

        // Ryder - Thanks, Razel
        rLine11.Play();
        yield return new WaitWhile(() => rLine11.isPlaying);

        // Razel - The very thought
        raLine19.Play();
        yield return new WaitWhile(() => raLine19.isPlaying);
        raLine20.Play();
        yield return new WaitWhile(() => raLine20.isPlaying);
        raLine21.Play();
        yield return new WaitWhile(() => raLine21.isPlaying);

        // Ryder - It is terrifying
        rLine12.Play();
        yield return new WaitWhile(() => rLine12.isPlaying);
        rLine13.Play();
        yield return new WaitWhile(() => rLine13.isPlaying);

        // Razel - Take care
        raLine22.Play();
        yield return new WaitWhile(() => raLine22.isPlaying);

        razel.enabled = false;

        teleportSpots.SetActive(true);
        okayToTriggerAlan = true;
    }
}
