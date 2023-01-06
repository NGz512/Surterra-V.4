using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangSceneWithButton : MonoBehaviour
{
    public void NextLevel()
    {
        SceneManager.LoadScene("PersistentScene");
    }

}
