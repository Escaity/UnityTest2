using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinInit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject boxObjPrefab;

    public GameObject boxesObj;

    private void Awake()
    {
        for (int x = 1; x <= 4; x++)
        {
            for (int y = 0; y < x; y++)
            {
                GameObject g = Instantiate(boxObjPrefab, boxesObj.transform);
                g.transform.position = new Vector3(-4.8f + (4 - x) * 1.2f + ((2.2f * y)), 8f, (6f + (2f * x)));
            }
        }
    }

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}