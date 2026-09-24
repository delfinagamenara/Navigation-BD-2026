using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Enemy [] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = FindObjectsOfType <Enemy> ();
        SetDamagePointTo (0);
       SetRandomValueToDamagePoints ();
       DesactivateAllEnemiesWithPDLessThan (7);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDamagePointTo (int newValue)
    {
        for (int i = 0; i< enemies.Length; i++)
        {
            enemies [i].damagePoints = newValue;

        }
    
    }
    void SetRandomValueToDamagePoints ()

    {
         for (int i = 0; i< enemies.Length; i++)
        {
            enemies [i].damagePoints  = Random.Range (1, 11);

        }
    }

    void DesactivateAllEnemiesWithPDLessThan (int value)
    {
        for (int i = 0; i< enemies.Length; i++)
        {
            if (enemies [i].damagePoints < value)
            {
            enemies [i].gameObject.SetActive(false);
            }
        }
    }
}
