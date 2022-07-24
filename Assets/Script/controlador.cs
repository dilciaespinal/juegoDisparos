using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlador : MonoBehaviour
{
    public GameObject panelGane;
    public int numEnemigos;
    // Start is called before the first frame update
    void Start()
    {
        numEnemigos = GameObject.FindGameObjectsWithTag("Enemigo").Length;
        panelGane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestarEnemigos()
    {
        numEnemigos--;
        if(numEnemigos <= 0)
        {
            panelGane.SetActive(true);
        }
    }

    public void ReiniciarJuego()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }

}
