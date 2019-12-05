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
    float numItem_1;
    float numItem_2;

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
        if (other.tag== "suma1")
        {
            Destroy(other.gameObject);
            contador = contador + 1;
            numItem_1 = numItem_1 + 1;
        
        }
        else if (other.tag == "suma2")
        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numItem_2 = numItem_2 + 2;
        }

        Destroy(other.gameObject);
        ActualizarMarcador();


        if (numItem_1 >=8 && numItem_2 >= 4)
        {
            FinDeJuego.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
       
    }
      void ActualizarMarcador()
    {
        marcador.text = "puntos" + contador;
    }
}




