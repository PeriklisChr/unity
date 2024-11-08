using UnityEngine;
using Unity.VisualScripting;

public class hom_2 : MonoBehaviour
{
    private BoxCollider c;
 
    void Start()
    {
       GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        
        c = obj.GetComponent<BoxCollider>();
        c.isTrigger = true;

    }

    void Update()
    {
        
    }
}
