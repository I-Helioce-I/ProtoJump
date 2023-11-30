using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;  // Pr�fabriqu� de la plateforme
    public float verticalSpacing = 3f;  // Espacement vertical entre les plateformes
    public float horizontalMin = -15f;  // Position horizontale minimale
    public float horizontalMax = 15f;   // Position horizontale maximale

    public List<GameObject> platforms = new List<GameObject>();

    private Vector3 lastPlatformPosition;  // Position de la derni�re plateforme instanci�e

    void Start()
    {
        lastPlatformPosition = Vector3.zero;  // Initialisation de la position
        StartCoroutine(GeneratePlatforms());
    }

    

    IEnumerator GeneratePlatforms()
    {
        while (true)    
        {
            GenerateNewPlatform();
            yield return new WaitForSeconds(1f);  // Attends 1 seconde entre chaque g�n�ration
        }
    }

    void GenerateNewPlatform()
    {
        // G�n�re une nouvelle plateforme au-dessus de la derni�re plateforme instanci�e
        Vector3 newPosition = lastPlatformPosition + new Vector3(Random.Range(horizontalMin, horizontalMax), verticalSpacing, 0f);
        
        if(newPosition.x > 15 || newPosition.x < -15)
        {
            return;
        }

        GameObject newPlatform = Instantiate(platformPrefab, newPosition, Quaternion.identity);

        // Met � jour la position de la derni�re plateforme instanci�e
        lastPlatformPosition = newPosition;

        platforms.Add(newPlatform);
    }

    public void RemovePlatformFromList(Platform platformToRemove)
    {
        platforms.Remove(platformToRemove.gameObject);
    }
}
