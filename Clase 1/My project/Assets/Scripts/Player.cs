using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float posicionY = 3f;
    public float velocidad;
    void Start()
    {
        transform.position = Vector3.up * posicionY;
        transform.localScale = transform.localScale * 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position  + Vector3.up * velocidad * Time.deltaTime;
        transform.position = transform.position  + Vector3.forward * velocidad * Time.deltaTime;
    }
}
