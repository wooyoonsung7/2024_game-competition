using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GaemScenesMove : MonoBehaviour
{
    public void GameSceneCtrl()
    {
        SceneManager.LoadScene("GameScene");
    }
}
