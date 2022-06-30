using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoFUIHandler : MonoBehaviour
{
    public void ReturnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
