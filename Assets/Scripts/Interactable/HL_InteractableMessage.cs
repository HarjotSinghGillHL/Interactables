using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HL_InteractableMessage : MonoBehaviour
{
    // Start is called before the first frame update
    public string IteratorObjectName = "Character";
    private GameObject Interactor;
   
    void Start()
    {
        Interactor = GameObject.Find(IteratorObjectName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Interactor = null)
            Interactor = GameObject.Find(IteratorObjectName);

        float flDistance = Mathf.Abs((transform.position - Interactor.transform.position).magnitude);

       Debug.Log(flDistance);

    }
}
