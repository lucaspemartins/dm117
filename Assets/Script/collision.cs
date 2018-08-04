using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour {

    [Tooltip("Quanto tempo antes de reiniciar o jogo")]
    private float tempoEspera = 2.0f;

    [SerializeField]
    [Tooltip("Referencia para a explosao")]
    private GameObject explosao;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<birdController>())
        {
            Destroy(collision.gameObject);
            Invoke("Reset", tempoEspera);
        }
    }

    /// <summary>
    /// Metodo para verificar se o obstaculo foi tocado
    /// </summary>
    public void ObjetoTocado()
    {
        print("Aqui");
        if (explosao)
        {
            var particulas = Instantiate(explosao, transform.position, Quaternion.identity);
            Destroy(particulas, 1.0f);
        }

        Destroy(this.gameObject);
    }
}
