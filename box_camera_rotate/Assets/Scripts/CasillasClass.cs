using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CasillasClass : MonoBehaviour {

	// Use this for initialization


    static GameManager instance;
    public GameObject Enemigo;
    GameObject aux;
    Vector3 guardarPosicion;
    Transform posicion;
    Quaternion guardarRotacion;
    int i;
	List<Vector3> posiciones;
    public static List<GameObject> enemigos = new List<GameObject>();
    int a;
    int guardarRandom;
    EnemigoScript enemigoDestruido;

    void Start()
    {
		posiciones = new List<Vector3>();

        

		float auxX = -0.33f; 
		float auxY = 9.67f;
		float auxZ = 0.55f;
		int j = 0;

		for (i=0; i<3; i++) {
			for (j=0; j<3; j++){
				posiciones.Add(new Vector3(auxX, auxY, auxZ));
				auxX += 0.33f;

			}
			auxY += 0.33f;
			auxX = -0.33f;
		}

		auxX = -0.33f;
		auxY = 9.67f;

		for ( i = 0; i < 3; i++) {
			for (j=0; j<3; j++){
				posiciones.Add (new Vector3(auxX,auxY,-auxZ));
				auxX+= 0.33f;
			}
			auxY+= 0.33f;
			auxX = -0.33f;
		}
	
		auxX = 0.55f;
		auxY = 9.67f;
		auxZ = -0.33f;

		for ( i = 0; i < 3; i++) {
			for (j=0; j<3; j++){

				posiciones.Add(new Vector3(auxX,auxY,auxZ));
				auxZ+=0.33f;
			}
			auxZ= -0.33f;
			auxY+= 0.33f;


			
		}

		auxX = -0.55f;
		auxY = 9.67f;
		auxZ = -0.33f;
		
		for ( i = 0; i < 3; i++) {
			for (j=0; j<3; j++){
				
				posiciones.Add(new Vector3(auxX,auxY,auxZ));
				auxZ+=0.33f;
			}
			auxZ= -0.33f;
			auxY+= 0.33f;
			
			
			
		}

		auxX = -0.33f;
		auxY = 10.55f;
		auxZ = -0.33f;
		
		for ( i = 0; i < 3; i++) {
			for (j=0; j< 3; j++){
				
				posiciones.Add(new Vector3(auxX,auxY,auxZ));
				auxX+=0.33f;
			}
			auxZ+= 0.33f;
			auxX= -0.33f;
			
			
			
		}

		auxX = -0.33f;
		auxY = 9.45f;
		auxZ = -0.33f;
		
		for ( i = 0; i < 3; i++) {
			for (j=0; j< 3; j++){
				
				posiciones.Add(new Vector3(auxX,auxY,auxZ));
				auxX+=0.33f;
			}
			auxZ+= 0.33f;
			auxX= -0.33f;
			
			
			
		}

        StartCoroutine(Esperar());


    }

    void Update()
    {


    }
    

    // Update is called once per frame
    public void crearEnemigo()
    {

        /* for(int i=0; i<enemigos.Count; i++)
         {
         }*/

		int polla = generarplano (posiciones.Count);

        guardarPosicion = posiciones[polla];
		posiciones.Remove (guardarPosicion);
		Quaternion rotasion = Quaternion.identity;
		if(Mathf.Abs(guardarPosicion.x)== 0.55f)
		{
			rotasion.SetFromToRotation(Vector3.right,Vector3.forward);
		}

		if(Mathf.Abs(guardarPosicion.y)== 10.55f)
		{
			rotasion.SetFromToRotation(Vector3.up,Vector3.forward);
		}

		if(Mathf.Abs(guardarPosicion.y)== 9.45f)
		{
			rotasion.SetFromToRotation(Vector3.up,Vector3.forward);
		}

        enemigos.Add(Instantiate(Enemigo, guardarPosicion, rotasion) as GameObject);

      
        

    }

    public int generarplano(int x)
    {
		return Random.Range(0,x);

		
    }


    IEnumerator Esperar()
    {

        for (i = 0; i < 9; i++)
        {
            crearEnemigo();

        } 

        while (enemigos.Count < 54)
        {
     
            yield return new WaitForSeconds(10);

            for (i = 0; i < 9 ; i++)
            {
                crearEnemigo();
                
            }
            Debug.Log("Llego");
      
        }
    }


    public void quitarDeLaLista(GameObject cosa)
    {
        enemigos.Remove(cosa);
    }

   
}
