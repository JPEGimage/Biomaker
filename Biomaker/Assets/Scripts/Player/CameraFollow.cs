using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float velo;

    private void FixedUpdate() 
    {
        transform.position = Vector2.Lerp(transform.position, player.position, velo);
    }
}
