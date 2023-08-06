using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroyCanvas : MonoBehaviour
{
    void Start()
    {
        Invoke("Destroy", 5f);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
