using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Herbivora : MonoBehaviour
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

    public void Omnivore()
    {
        SceneManager.LoadScene("Omnivora");
    }

    public void Gajah()
    {
        SceneManager.LoadScene("Gajah");
    }

    public void Kambing()
    {
        SceneManager.LoadScene("Kambing");
    }

    public void Keledai()
    {
        SceneManager.LoadScene("Keledai");
    }

    public void Sapi()
    {
        SceneManager.LoadScene("Sapi");
    }

    public void Unta()
    {
        SceneManager.LoadScene("Unta");
    }
}
