using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Player : MonoBehaviour
{
   [SerializeField] private Transform[] cube;


   private void Start()
   {
      // StartCoroutine(LiveCarutine());
      Lifeasync();
   }

   private async void Lifeasync()
   {

      for (int i = 0; i < cube.Length; i++)
      {
        
     await rotateAsync(cube[i]);
      }
   }

   private async Task rotateAsync(Transform o)
   {
      float time = 0;

      while (time < 3)
      {
         time = Math.Min(time + Time.deltaTime, 3);
         o.Rotate(Vector3.up,0.2f);
         await Task.Yield();
      }
     
   }
      
/* IEnumerator LiveCarutine()
   {
    
      for (int i = 0; i < cube.Length; i++)
      {
        
         yield return StartCoroutine(RotetionCarutine(cube[i]));
      }

     
   }

   IEnumerator RotetionCarutine(Transform o)
   {
      float time = 0;

      while (time < 3)
      {
         time = Math.Min(time + Time.deltaTime, 3);
         o.Rotate(Vector3.up,0.2f);
         yield return null;
      }
     
   }
   
   
*/
   
}

