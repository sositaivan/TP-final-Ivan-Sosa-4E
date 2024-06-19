using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject[] Objetos;
    public int currentindex = -1;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentindex++;

            if (currentindex < Objetos.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentindex);
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentindex--;

            if (currentindex < Objetos.Length)
            {
                DeactivateAll();
                ActivateByIndex(currentindex);
            }
        }

    }

    void DeactivateAll()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(false);
        }
    }
    void ActivateAll()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(true);
        }
    }


    void ActivateByIndex(int index)
    {
        Objetos[index].SetActive(true);
    }
}
