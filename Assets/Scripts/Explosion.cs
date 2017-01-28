using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Invoke("KillMe", 0.3f);
    }

    // Update is called once per frame
    void KillMe()
    {
        Destroy(gameObject);
    }
}
