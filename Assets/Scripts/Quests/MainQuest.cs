using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainQuest : MonoBehaviour
{

    public void PayMoney()
    {
        if(InventoryManager.Instance.PlayerMoney >= 100000)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

}
