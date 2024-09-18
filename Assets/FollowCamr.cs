using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamr : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // The camera should be the same as they car    
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
