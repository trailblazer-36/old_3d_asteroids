using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAsteroidField : MonoBehaviour
{
    public Transform asteroidPrefab;
    public int fieldRadius = 400;
    public int asteroidCount = 1000;
    public float min_size = 3.0f;
    public float max_size = 24.0f;


    // Start is called before the first frame update
    void Start()
    {
        for (int loop = 0; loop < asteroidCount; loop++)
        {
            Transform temp = Instantiate(asteroidPrefab, Random.insideUnitSphere * fieldRadius, Quaternion.identity);
            
            temp.localScale = temp.localScale * Random.Range(min_size, max_size);
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
