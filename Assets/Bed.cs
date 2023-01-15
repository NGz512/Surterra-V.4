using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        TimeManager.Instance.TestAdvanceGameDay();
    }
}
