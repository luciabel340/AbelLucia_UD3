using UnityEngine;
using System.Collections;

public class T06 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		/*
		 * Guardar en memoria las 10 mejores puntuaciones del juego

		int puntos01 = 0;
		int puntos02 = 0;
		int puntos03 = 0;
		...
		*/
		/*
Para definir un array:
    1) <tipo_dato_array>
       Primero, el tipo de datos que queremos que contenga. 
       Para almacenar las diez mejores puntuaciones usamos números enteros, 
       no  tendrían decimales.
    2)   [] Abrimos y cerramos corchete junto al tipo 
        sin dejar espacio dentro de los corchetes.  
    3) Ponemos el nombre ‘puntos’ que es cómo se va a llamar el array 
    4)  =  Símbolo de asignación
    5) new 
       Especificar qué es un array
    6) [tamaño_array]
        Entre corchetes la cantidad de datos o de elementos 
        que queremos que contenga

<tipo_dato_array> [] <nombre_array> = new [tamaño_array]*/
		
		int[] puntos = new int[10];
		float[] reales = new float[5];
		string[] cadenas = new string[3];
		bool[] logicos = new bool[8];
		
		/*	int[] inicializadoA = new int[5]{1, 2, 3, 4, 5};
		int[] inicializadoB = new int[]{1, 2, 3, 4, 5};
		int[] inicializadoC = {1, 2, 3, 4, 5};
		
		float[] realesInicializado = {1f, 2f, 3f, 4f, 5f};
		string[] cadenasInicializado = {"Juande", "Jose", "Miguel", "Antonio"};
		bool[] logicosInicializado = {true, false, true, true};
		
		Debug.Log(cadenasInicializado[0]);
		
		cadenasInicializado[1] = "Pepe";
		
		Debug.Log(cadenasInicializado[1]);
		
		Debug.Log(cadenasInicializado.Length);
		*/
	}
	
}
