using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject enemy;  

public int i;

  void Start()
  {
    i = 0; 
  }



    // Start is called before the first frame update
    void Update()
    {

        StartCoroutine(enemyCopy());
      if(i == 9)
      {
        i = 0; 
      }
    }


    IEnumerator enemyCopy()
    { 
      while(i <= 10)
      {
        yield return new WaitForSeconds(5);
        i++;
        Instantiate(enemy, new Vector3(Random.Range(-10f, 10f), 0.5f, Random.Range(10f, 2500f)), Quaternion.identity);
      }
    }
}
