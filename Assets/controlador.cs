using UnityEngine;

public class controlador : MonoBehaviour
{
    public void reiniciar()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel1");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void passou()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("nivel2");
    }
}
