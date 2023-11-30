using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    [SerializeField]
    PlatformGenerator pG;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.TryGetComponent<Platform>(out Platform component))
        {
            pG.RemovePlatformFromList(component);
            component.DestroyPlatform();
            Debug.Log("Try destroy" + component.name);
        }
        else if (other.TryGetComponent<PlayerController>(out PlayerController player))
        {
            player.Die();
        }
    }
}
