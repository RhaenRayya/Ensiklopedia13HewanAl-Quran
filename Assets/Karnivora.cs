using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Karnivora : MonoBehaviour
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

    public void Herbivore()
    {
        SceneManager.LoadScene("Herbivora");
    }

    public void Omnivore()
    {
        SceneManager.LoadScene("Omnivora");
    }

    public void Gogok()
    {
        SceneManager.LoadScene("Anjing");
    }

    public void Laba()
    {
        SceneManager.LoadScene("LabaLaba");
    }

    public void Paus()
    {
        SceneManager.LoadScene("Paus");
    }

    public void Serigala()
    {
        SceneManager.LoadScene("Serigala");
    }

    public void Ular()
    {
        SceneManager.LoadScene("Ular");
    }
}
