using UnityEngine;

using System.Collections;

public class GameOver : MonoBehaviour
{
    public GameObject expl;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Scenery"))
        {
            Instantiate(expl, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);

            NewGame.status = NewGame.GameStatus.Restarting;
        }
    }
}
