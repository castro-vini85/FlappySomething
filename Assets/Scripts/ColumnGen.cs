using UnityEngine;
using System.Collections;

public class ColumnGen : MonoBehaviour
{
    public GameObject columnObj;

    public float MinX = 0f;
    public float MaxX = 0f;

    public float MinY = 0f;
    public float MaxY = 0f;

    public float StartDelay = 0;
    public float InstantiateDelay = 0;

    void Start()
    {
        InvokeRepeating("CreateRandom", StartDelay, InstantiateDelay);
    }

    void CreateRandom()
    {
        float x, y;

        x = Random.Range(MinX, MaxX);
        y = Random.Range(MinY, MaxY);

        Instantiate(columnObj, new Vector3(x, y, 0), Quaternion.identity);
    }
}
