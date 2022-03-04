using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{

    public GameObject terrain; 
    public bool isCreated; 
    public Collider m_Collider;
    Vector3 m_Size;
      public int i = 0;
    void Start() 
    { 
      m_Collider = GetComponent<Collider>();
      m_Size = m_Collider.bounds.size;
    } 

    void Update()
    {
      StartCoroutine(MULT());
    }


    IEnumerator MULT()
    { 
      while(i <= 10)
      {
        yield return new WaitForSeconds(5);
        i++;
        Instantiate(terrain, new Vector3(0f,0f, m_Size.z * i), Quaternion.identity);
      }
    }
}
