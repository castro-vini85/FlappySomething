using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{
    public int xSpeed = 0;
    public int ySpeed = 0;
    public bool randomX;
    public int minXSpeed = 100;
    public int maxXSpeed = 200;

    public bool randomY;
    public int minYSpeed = 100;
    public int maxYSpeed = 200;

    public bool resize;
    public float minSize = 1f;
    public float maxSize = 1f;

    // Use this for initialization
    void Start()
    {
        if (randomX)
            xSpeed = Random.Range(minXSpeed, maxXSpeed);

        if (randomY)
            ySpeed = Random.Range(minYSpeed, maxYSpeed);

        if (resize)
        {
            var newSize = Random.Range(minSize, maxSize);
            transform.localScale = new Vector3(newSize, newSize, 0);
        }

        var newSpeed = new Vector2
        {
            x = xSpeed,
            y = ySpeed
        };

        GetComponent<Rigidbody2D>().AddForce(newSpeed);
    }
}
