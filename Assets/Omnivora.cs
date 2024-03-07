using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Omnivora : MonoBehaviour
{
    public void Beranda()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Kisah()
    {
        SceneManager.LoadScene("Kisah");
    }

    public void Ensik()
    {
        SceneManager.LoadScene("Ensiklopedia");
    }

    public void Other()
    {
        SceneManager.LoadScene("Lainnya");
    }

    public void Carnivore()
    {
        SceneManager.LoadScene("Karnivora");
    }

    public void Herbivore()
    {
        SceneManager.LoadScene("Herbivora");
    }

    public void Gagak()
    {
        SceneManager.LoadScene("Gagak");
    }

    public void Hud()
    {
        SceneManager.LoadScene("HudHud");
    }

    public void Semut()
    {
        SceneManager.LoadScene("Semut");
    }
}
