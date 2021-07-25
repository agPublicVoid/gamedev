using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject bombPrefab;
    private float xMin = -2.55f;
    private float xMax = 2.55f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnBombs());
    }

    IEnumerator SpawnBombs()
    {
        // wait for zero to one second
        yield return new WaitForSeconds(Random.Range(0f, 1f));

        // 1) Instantiates a copy of the bombPrefab
        // 2) At position of random X axis, and current y axis position
        // 3) Use default rotation, zero for each angle
        Instantiate(bombPrefab, new Vector2(Random.Range(xMin, xMax), transform.position.y), Quaternion.identity);

        // call recursively
        StartCoroutine(SpawnBombs());
    }
}