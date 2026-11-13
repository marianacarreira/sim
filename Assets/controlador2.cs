using UnityEngine;

public class controlador2 : MonoBehaviour
{
    public void recomecar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel2");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void mudou()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }
}
