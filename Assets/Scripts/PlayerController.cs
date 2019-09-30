using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PaddleBehaviour paddleBeh;
    private string playerAxis;

    void Awake()
    {
        paddleBeh = GetComponent<PaddleBehaviour>();
        if (gameObject.name.Contains("P1"))
        {
            playerAxis = "Vertical_P1";
        }
        else if (gameObject.name.Contains("P2"))
        {
            playerAxis = "Vertical_P2";
        }
    }

    void Update()
    {
        float moveDir = Input.GetAxis(playerAxis);
        paddleBeh.MovePaddle(moveDir);

    }
}
