using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public void DestroyPlatform()
    {
        Debug.Log(gameObject.name + "Is Dead");
        Destroy(gameObject);
    }
}
