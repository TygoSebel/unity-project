using UnityEngine;

public class ObjectHit : MonoBehaviour
{
  private void OnCollisionEnter(Collision other) 
  {
    if (other.gameObject.tag == "Player")
    {
       GetComponent<MeshRenderer>(). material.color = Color.red;
    }
      
    Debug.Log("You've bumped into a thing!");
 
  }
}
