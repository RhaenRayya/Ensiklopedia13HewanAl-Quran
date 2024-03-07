using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Beranda : MonoBehaviour
{
    public void Ensik()
    {
        SceneManager.LoadScene("Ensiklopedia");
    }

    public void Hikmah()
    {
        SceneManager.LoadScene("Kisah");
    }

    public void Other()
    {
        SceneManager.LoadScene("Lainnya");
    }
}
