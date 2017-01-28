using UnityEngine;
using System.Collections;

public class ColumnDestroy : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
