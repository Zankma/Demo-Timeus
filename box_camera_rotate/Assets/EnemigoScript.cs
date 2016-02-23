using UnityEngine;
using System.Collections;

public class EnemigoScript : MonoBehaviour {

    // Use this for initialization
    GameManager gm;
    bool destruido=false;

    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
            //Making the raycast
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
            {
                Debug.Log("Javi me la pela");

                Destroy(hitInfo.collider.gameObject);

                GameObject.Find("Cube").GetComponent<CasillasClass>().quitarDeLaLista(gameObject);

              
            }


            /* destruido = true;*/


        }


    }




    public  bool recibirBool()
    {
        return destruido;


    }
}
