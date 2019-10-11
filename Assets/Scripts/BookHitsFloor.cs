using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookHitsFloor : MonoBehaviour
{
    // We need a reference to the prefab of the new GO we want to instantiate
    public GameObject bookPrefabReference;

    private void OnCollisionEnter(Collision collision)
    {
        // I forgot to say to destroy the GO only if it is a book
        // Check this out. Intellisense snippet surround with

        if (collision.gameObject.name == "book_0001a" ||
            collision.gameObject.name == "Book(Clone)")
        {
            Debug.Log("xxx");
            // Destroy the book that hits the floor
            Destroy(collision.gameObject);

            // Create a new book and put it over the box. As we have created the prefab from
            // the book who was in the correct position, the new book will appear in the same position.
            GameObject newBook = Instantiate(bookPrefabReference);

            // Lets move the new created book a bit to the left or to the right
            // Generates a random float value between -1.0f and 1.0f
            float xOffset = Random.Range(-1.0f, 1.0f);
            // Translate (desplazar) the book by xOffset
            newBook.transform.Translate(new Vector3(xOffset, 0, 0));

            // Maybe the bullet is not touching the book collider. Next thing we'll do is 
            // add the option to move the gun.

            // Now we could also variate the rotation of the new instantiated book.
            // This I'll leave it as a microchallenge for you.
            // Bye for now!
            float yRotOffset = Random.Range(-90.0f, 90.0f);
            newBook.transform.Rotate(new Vector3(0, yRotOffset, 0));
        }
    }
}
