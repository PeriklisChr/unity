using System.Collections;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class hom_1 : MonoBehaviour
{
    public Vector3 Center;
    public float Radius;
    public int d = 0;
    private GameObject obj = new GameObject();
    private bool t = false;


    public void Start()
    {
        InitCircle(Center, Radius);
    }

    public void InitCircle(Vector3 center, float radius)
    {
        Center = center;
        Radius = radius;
    }
    
    //gia to delay bazo to private mesa sto delay function

        private void Update()
        {
        //to parakato einai gia na mpei limiter sto posa object tha mpoyn
        if (t == false && d<7)
        {
            StartCoroutine(delay(Center, Radius));   

        }
        
            
        }
    //to function toy enumetaror einai gia na kanei to delay, to opoio meta kalo sto pano
    private IEnumerator delay(Vector3 center, float radius)
    {
        // sthn arxh to t einai false, gia na ftiajei object. oso einai true, dhaldh mesa sthn dhmioyrgia, den ftiaxnei deyetro, moliw teleivnv thn dhmioyrgia, janampainei to false ara janaftixnei object

        t= true;
        float x = Random.Range(Center.x, Radius);
        float y = Random.Range(Center.y, Radius);

        int z = Random.Range(0, 3);





        if (z == 0)
        {
            obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
        else if (z == 1)
        {
            obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        }
        else if (z == 2)
        {
            obj = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        }


        obj.transform.position = new Vector3(x, y, obj.transform.position.z);
        obj.transform.LookAt(Center);

        d++;



        yield return new WaitForSeconds(1f);
        t = false;

    }
}
   
