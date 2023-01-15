using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCShop : MonoBehaviour
{
    [SerializeField] GameObject panel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        panel.gameObject.SetActive(true);
    }
}
