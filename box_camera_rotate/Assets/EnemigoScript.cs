using UnityEngine;
using System.Collections;

public class EnemigoScript : MonoBehaviour {

    // Use this for initialization

	public int tocado=0;

    void Start () {

		tocado = 0;
        
	}
	
	// Update is called once per frame
	void Update () {



        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo = new RaycastHit();
			Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
			//Making the raycast
			if (hitInfo.collider != null && hitInfo.collider.gameObject== this.gameObject) //Linea hecha por © CCGLP 
			{
                Debug.Log("Javi me la pela");

				if(this.tocado==0){

                //Destroy(hitInfo.collider.gameObject);
				hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale=new Vector3(1.5f,1.5f,1.5f);
				hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().color= Color.red;

				this.tocado++;

				}
				else if(this.tocado == 1){


				hitInfo.collider.gameObject.GetComponentInParent<Transform>().localScale=new Vector3(1f,1f,1f);
				hitInfo.collider.gameObject.GetComponentInParent<SpriteRenderer>().color= Color.blue;

					this.tocado++;

				}
				else if(this.tocado > 1){

					Destroy(hitInfo.collider.gameObject);

				}



				/*if(tocado ==3 ){

					Destroy (hitInfo.collider.gameObject);

				}*/

               // GameObject.Find("Cube").GetComponent<CasillasClass>().quitarDeLaLista(gameObject);

				
            }

            /* destruido = true;*/


        }

    }



}
