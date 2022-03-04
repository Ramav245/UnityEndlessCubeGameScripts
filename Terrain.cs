using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Terrain : MonoBehaviour
{

    public GameObject terrain; 
    public bool isCreated; 
    public Collider m_Collider;
    Vector3 m_Size;
    private int i;
    void Start() 
    { 
      m_Collider = GetComponent<Collider>();
      m_Size = m_Collider.bounds.size;
      i = 0; 
    } 
    
    void Update()
    {
      StartCoroutine(MULT());

        if(i == 9)
        {
          i = 0; 
        }
    }


    IEnumerator MULT()
    { 
      while(i <= i * 10)
      {
        yield return new WaitForSeconds(5);
        i = i + (int)m_Size.z;
        Instantiate(terrain, new Vector3(0f,0f, i), Quaternion.identity);
      }
    }
}
