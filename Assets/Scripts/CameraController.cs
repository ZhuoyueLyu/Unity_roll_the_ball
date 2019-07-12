using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        //Set the offset
        offset = transform.position - player.transform.position;
    }

    void LateUpdate()
    {//LateUpdate: run every frame, just like update, but it's guarantee to run
     //after all items have been processed in Update()
        transform.position = player.transform.position + offset;
    }
}