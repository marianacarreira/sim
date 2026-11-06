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
    

    // Update is called once per frame
    void Update()
    {
        jogador.AddForce(0, 0, 10);

        if (Input.touchCount > 0)
        {
            Touch toque = Input.GetTouch(0);
            if (toque.position.x<Screen.width / 2)
            {
                jogador.AddForce(-55, 0, 0);
            }
            else
            {
                jogador.AddForce(55, 0, 0);
            }
        }
        if (transform.position.y < -1)
        {
            FindAnyObjectByType<controlador>().reiniciar();
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
        if (barreira.gameObject.tag == "fim")
        {
            FindAnyObjectByType<controlador>().passou();
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
