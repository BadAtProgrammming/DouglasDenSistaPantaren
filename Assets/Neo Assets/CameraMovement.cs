using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private KeyCode left;
    [SerializeField] private KeyCode right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(left))
        {
            transform.position += new Vector3(-5, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKey(right))
        {
            transform.position += new Vector3(5, 0, 0) * Time.deltaTime;
        }
    }
}
