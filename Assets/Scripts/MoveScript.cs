using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float WS = Input.GetAxis("Vertical");
        float AD = Input.GetAxis("Horizontal");

        transform.position += transform.forward * WS * speed + transform.right * AD * speed;
    }
}
