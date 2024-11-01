//Made by Donovan Peckham

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * 4f);
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 3f);
        if (transform.position.x < -11.5f)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.y < -8f)
        {
            Destroy(this.gameObject);
        }
    }
}
