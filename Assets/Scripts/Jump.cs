using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour
{
    public int force = 3000;
    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                if (NewGame.status == NewGame.GameStatus.WaitingStart) 
                    NewGame.status = NewGame.GameStatus.Started;

                if (NewGame.status == NewGame.GameStatus.Started)
                {
                    GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force));
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (NewGame.status == NewGame.GameStatus.WaitingStart)
                NewGame.status = NewGame.GameStatus.Started;

            if (NewGame.status == NewGame.GameStatus.Started)
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.zero;
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, force));
            }
        }
    }
}
