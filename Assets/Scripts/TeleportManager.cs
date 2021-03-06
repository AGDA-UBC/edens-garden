﻿using System;
using UnityEngine;
using VRStandardAssets.Utils;

public class TeleportManager : MonoBehaviour
{
    public static event Action<Transform> DoTeleport;

    [SerializeField] VRInteractiveItem[] teleportLocations;
    [SerializeField] Transform reticleTransform;

    void OnEnable()
    {
        foreach (VRInteractiveItem t in teleportLocations)
        {
            t.OnClick += Teleport;
        }
    }

    void OnDisable()
    {
        foreach (VRInteractiveItem t in teleportLocations)
        {
            t.OnClick -= Teleport;
        }
    }

    void Teleport()
    {
        if (DoTeleport != null)
        {
            Debug.Log("Trying to teleport");
            DoTeleport(reticleTransform);
        }
        else
        {
            Debug.Log("DoTeleport event has no subscribers.");
        }
    }

}