using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;  // Préfabriqué de la plateforme
    public float verticalSpacing = 3f;  // Espacement vertical entre les plateformes
    public float horizontalMin = -15f;  // Position horizontale minimale
    public float horizontalMax = 15f;   // Position horizontale maximale

    public List<GameObject> platforms = new List<GameObject>();

    private Vector3 lastPlatformPosition;  // Position de la dernière plateforme instanciée

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
            yield return new WaitForSeconds(1f);  // Attends 1 seconde entre chaque génération
        }
    }

    void GenerateNewPlatform()
    {
        // Génère une nouvelle plateforme au-dessus de la dernière plateforme instanciée
        Vector3 newPosition = lastPlatformPosition + new Vector3(Random.Range(horizontalMin, horizontalMax), verticalSpacing, 0f);
        
        if(newPosition.x > 15 || newPosition.x < -15)
        {
            return;
        }

        GameObject newPlatform = Instantiate(platformPrefab, newPosition, Quaternion.identity);

        // Met à jour la position de la dernière plateforme instanciée
        lastPlatformPosition = newPosition;

        platforms.Add(newPlatform);
    }

    public void RemovePlatformFromList(Platform platformToRemove)
    {
        platforms.Remove(platformToRemove.gameObject);
    }
}
