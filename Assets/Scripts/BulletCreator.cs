using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{
    // A reference to the projectile prefab we wan't to instantiate.
    // Must be public for it to appear in Inspector and be able to 
    // do the binding in Unity Editor.
    public GameObject projectilePrefabReference;
    public AudioClip shootSoundReference;

    // Magnitude of the initial impulse. transform.forward is the direction
    public float thrust = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Fire when left mouse button clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Instantiate a new bullet in the correct position (in the tip of the gun)
            GameObject projectile = Instantiate(
                                    projectilePrefabReference,
                                    transform.position, // The position of this gameobject
                                                             // to which this script is attached
                                                             // i.e. the BulletCreator GO
                                    Quaternion.identity
                                    );
            // Give an impulse force to the bullet
            projectile.GetComponent<Rigidbody>().AddForce(-transform.right * thrust,
                ForceMode.Impulse);

            // Play shoot sound
            AudioSource.PlayClipAtPoint(shootSoundReference,
                                            Camera.main.transform.position);
            // It works!

            // Destroy the projectile after 5 seconds
            Destroy(projectile, 5.0f); 
        }        
    }
}
