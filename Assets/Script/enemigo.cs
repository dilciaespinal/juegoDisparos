using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public GameObject efecto;
    public controlador controlador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Instantiate(efecto, transform.position, Quaternion.identity);
        controlador.RestarEnemigos();
        Destroy(gameObject);
    }

}
