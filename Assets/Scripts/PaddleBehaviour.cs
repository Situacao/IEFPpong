using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleBehaviour : MonoBehaviour
{
    public void MovePaddle(float _dirVal)
    {
        Vector3 newPos = transform.position + Vector3.up * 5f * Time.deltaTime * _dirVal;
        newPos.y = Mathf.Clamp(newPos.y, -3.9f, 3.9f); 
        transform.position = newPos;
    }
}
