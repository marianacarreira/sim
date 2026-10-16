using UnityEngine;

public class mover : MonoBehaviour
{
    public Rigidbody jogador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jogador.AddForce(0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        jogador.AddForce(0, 0, 5);

        if (Input.GetKeyDown(KeyCode.A))
        {
            jogador.AddForce(-100, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            jogador.AddForce(100, 0, 0);
        }
    }
}
