using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TELEPORT : MonoBehaviour
{
    public Transform teleportPoint;
    public GameObject player;
    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = teleportPoint.position;
    }
}
