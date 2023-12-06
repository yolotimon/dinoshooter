using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private void Awake()
    {
        bullet.points = 0;
        Debug.Log("points: " + bullet.points);
    }
}
