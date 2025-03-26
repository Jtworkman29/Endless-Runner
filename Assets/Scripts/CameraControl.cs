using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    [SerializeField] Transform followTarget;
    public float xOffset;
    public float yOffset;


    void Update()
    {
        transform.position = new Vector3(followTarget.transform.position.x - xOffset, transform.position.y - yOffset, transform.position.z);
    }
}
