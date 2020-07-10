using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject follow;
    public Vector2 minCamPos, maxCamPos;
    public float smoothTime;

    private Vector2 velocity;
   
    void Start()
    {
        
    }
}
