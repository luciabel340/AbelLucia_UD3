using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class ControladorDelJugador : MonoBehaviour
{
    public float velocidad;
    Rigidbody rb;
    float contador;
    public Text marcador;
    public Text FinDeJuego;
    public Text salir;
    void Awake()
        {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        ActualizarMarcador();
        FinDeJuego.gameObject.SetActive(false);

    }
    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f,
        movimientoVertical);
        rb.AddForce(movimiento*velocidad);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        ActualizarMarcador();
        if (contador >= 8)
        {
            FinDeJuego.gameObject.SetActive(true);
           
        }
       
    }
      void ActualizarMarcador()
    {
        marcador.text = "puntos" + contador;
    }
}




