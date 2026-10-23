using UnityEngine;
using TMPro;
public class mover : MonoBehaviour
{
    public Rigidbody jogador;
    public TMP_Text vida;
    public TMP_Text pontos;
    public AudioSource somjogo;
    public AudioClip sommoeda;
    public AudioClip sombarreira;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jogador.AddForce(0, 0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        jogador.AddForce(0, 0, 1);

        if (Input.GetKeyDown(KeyCode.A))
        {
            jogador.AddForce(-55, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            jogador.AddForce(55, 0, 0);
        }
    }
    private void OnCollisionEnter(Collision barreira)
    {   
        if (barreira.gameObject.tag == "mau")
        {
            vida.text = (int.Parse(vida.text) - 1).ToString();
            if (int.Parse(vida.text)<=0)
            {
                FindAnyObjectByType<controlador>().reiniciar();
            }
            somjogo.PlayOneShot(sombarreira);
        }
    }
    private void OnTriggerEnter(Collider moeda)
    {
        if (moeda.gameObject.tag == "bom")
        {
            pontos.text = (int.Parse(pontos.text) + 10).ToString();
            somjogo.PlayOneShot(sommoeda);
        }
    }
}
