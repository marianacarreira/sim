using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
        public Transform jogador;
        public Vector3 distancia;
        
    // Update is called once per frame
    void Update()
    {
        transform.position = jogador.position + distancia;
    }
}
