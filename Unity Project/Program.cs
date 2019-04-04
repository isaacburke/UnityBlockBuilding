using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        for (int x = 0; x < 25; x++)
        {
            for (int z = 0; z < 25; x++)
            {
                CreateStack(x * 5, z * 5, 7);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
    }

    void CreateStack(int x, int z, int numBlocks)
    {
        float start = 0.0f;
        for (int i = 0; i < numBlocks; i++)
        {
            int height = 2, width = 2;
            if (Random.Range(0.0f, 1.0f) < 0.75f)
            {
                height = 3;
                width = 1;
            }

            float y = start + (0.5f * height);

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.AddComponent<Rigidbody>();
            cube.transform.position = new Vector3(x, y, z);
            cube.transform.localScale = new Vector3(width, height, width);

            cube.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);

            start += height;
        }

    }
}
