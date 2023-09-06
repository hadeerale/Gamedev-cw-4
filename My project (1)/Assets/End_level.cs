using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement
public class End_level : MonoBehaviour
{
    
    private void onCollisionEnter2D(Collision2D collision)
    {
        sceneManeger.loadscene("level1");
    }



}
