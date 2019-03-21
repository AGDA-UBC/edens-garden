using UnityEngine;
using VRStandardAssets.Utils;

public class Player : MonoBehaviour
{
    [SerializeField] private VRCameraFade fader;

    Vector3 playerPosition;       // Keeps track of where Player will be teleported.

    [SerializeField]
    float playerHeight = 1.8f;

    void OnEnable()
    {
        TeleportManager.DoTeleport += Teleport;
    }

    void OnDisable()
    {
        TeleportManager.DoTeleport -= Teleport;
    }

    void Teleport(Transform destTransform)
    {
        // Set the new position.
        playerPosition = destTransform.position;
        // Player's eye level should be playerHeight above the new position.
        playerPosition.y += playerHeight;
        // Fade out
        fader.FadeOut(true);
        // Move Player.
        fader.OnFadeComplete += MoveTo;
    }

    void MoveTo()
    {
        transform.position = playerPosition;
        fader.OnFadeComplete -= MoveTo;
        fader.FadeIn(true);
    }

}