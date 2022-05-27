using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioJuego : MonoBehaviour
{
    public void playGame(int SceneID)
    {
        SceneManager.LoadScene(SceneID);
    }
}

