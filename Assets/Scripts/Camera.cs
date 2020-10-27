using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]
    private Transform ancoraCamera;

    // Update is called once per frame
    void Update()
    {
        // Presente
        // Banheiro
        if (ancoraCamera.position.x < 5f && ancoraCamera.position.x > -9f &&
            ancoraCamera.position.y < -10f && ancoraCamera.position.y > -22f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -4.58f, -1.36f),
                Mathf.Clamp(ancoraCamera.position.y, -18.9f, -13.1f),
                transform.position.z);
        }
        // Deposito 1
        else if (ancoraCamera.position.x < 5f && ancoraCamera.position.x > -9f &&
                 ancoraCamera.position.y < 11f && ancoraCamera.position.y > -1f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -4.65f, -1.38f),
                Mathf.Clamp(ancoraCamera.position.y, 2.02f, 7.91f),
                transform.position.z);
        }
        // Deposito 2
        else if (ancoraCamera.position.x < 10.5f && ancoraCamera.position.x > -1.5f &&
                 ancoraCamera.position.y < 32f && ancoraCamera.position.y > 18f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 3.35f, 5.65f),
                Mathf.Clamp(ancoraCamera.position.y, 23.05f, 28.9f),
                transform.position.z);
        }
        // Deposito 3
        else if (ancoraCamera.position.x < 37.47f && ancoraCamera.position.x > 24.4f &&
                 ancoraCamera.position.y < 31.84f && ancoraCamera.position.y > 18f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 29.4f, 32.6f),
                Mathf.Clamp(ancoraCamera.position.y, 23.09f, 28.94f),
                transform.position.z);
        }
        // Lounge
        else if (ancoraCamera.position.x < 48f && ancoraCamera.position.x > 34f &&
                 ancoraCamera.position.y < 13f && ancoraCamera.position.y > 1f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 40.3f, 43.66f),
                Mathf.Clamp(ancoraCamera.position.y, 4.07f, 9.94f),
                transform.position.z);
        }
        // Mercado
        else if (ancoraCamera.position.x < 27f && ancoraCamera.position.x > 11f &&
                 ancoraCamera.position.y < 11.8f && ancoraCamera.position.y > -9f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 17.37f, 20.6f),
                Mathf.Clamp(ancoraCamera.position.y, -5.93f, 8.96f),
                transform.position.z);
        }

        // 1920 - Doces
        // Jardim 1
        else if (ancoraCamera.position.x < 29f && ancoraCamera.position.x > 9f &&
                 ancoraCamera.position.y < 90f && ancoraCamera.position.y > 70f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 13.9f, 23.37f),
                Mathf.Clamp(ancoraCamera.position.y, 72.74f, 87.68f),
                transform.position.z);
        }
        // Doces 1
        else if (ancoraCamera.position.x < 0f && ancoraCamera.position.x > -20f &&
                 ancoraCamera.position.y < 90f && ancoraCamera.position.y > 70f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -15.1f, -5.7f),
                Mathf.Clamp(ancoraCamera.position.y, 72.74f, 87.68f),
                transform.position.z);
        }
        // Doces 2
        else if (ancoraCamera.position.x < 0f && ancoraCamera.position.x > -20f &&
                 ancoraCamera.position.y < 120.68f && ancoraCamera.position.y > 70f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, -15.1f, -5.7f),
                Mathf.Clamp(ancoraCamera.position.y, 102.73f, 117.7f),
                transform.position.z);
        }
        // Doces 3
        else if (ancoraCamera.position.x < 29.14f && ancoraCamera.position.x > 8.06f &&
                 ancoraCamera.position.y < 120.68f && ancoraCamera.position.y > 102.7f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 13.9f, 23.3f),
                Mathf.Clamp(ancoraCamera.position.y, 105.65f, 117.7f),
                transform.position.z);
        }
        // Doces - Save
        else if (ancoraCamera.position.x < 54.19f && ancoraCamera.position.x > 33.06f &&
                 ancoraCamera.position.y < 120.68f && ancoraCamera.position.y > 102.88f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 38.92f, 49.31f),
                Mathf.Clamp(ancoraCamera.position.y, 107.7f, 117.65f),
                transform.position.z);
        }

        // Jardim 2
        else if (ancoraCamera.position.x < 49f && ancoraCamera.position.x > 33f &&
                 ancoraCamera.position.y < 95f && ancoraCamera.position.y > 77.7f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 39f, 44.3f),
                Mathf.Clamp(ancoraCamera.position.y, 80.74f, 91.68f),
                transform.position.z);
        }

        // 1950 - Comida
        // Banheiro
        else if (ancoraCamera.position.x < 92f && ancoraCamera.position.x > 77f &&
                 ancoraCamera.position.y < 68f && ancoraCamera.position.y > 55f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.02f, 85.45f),
                Mathf.Clamp(ancoraCamera.position.y, 58.74f, 64.69f),
                transform.position.z);
        }
        // Lounge
        else if (ancoraCamera.position.x < 91f && ancoraCamera.position.x > 77f &&
                 ancoraCamera.position.y < 88f && ancoraCamera.position.y > 77f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.05f, 85.42f),
                Mathf.Clamp(ancoraCamera.position.y, 79.81f, 85.63f),
                transform.position.z);
        }
        // Deposito
        else if (ancoraCamera.position.x < 97f && ancoraCamera.position.x > 85f &&
                 ancoraCamera.position.y < 109f && ancoraCamera.position.y > 96f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 90f, 92.42f),
                Mathf.Clamp(ancoraCamera.position.y, 100.81f, 106.66f),
                transform.position.z);
        }
        // Jardim
        else if (ancoraCamera.position.x < 135f && ancoraCamera.position.x > 118f &&
                 ancoraCamera.position.y < 96f && ancoraCamera.position.y > 79f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 124.91f, 130.32f),
                Mathf.Clamp(ancoraCamera.position.y, 82.71f, 93.72f),
                transform.position.z);
        }
        // Mercado
        else if (ancoraCamera.position.x < 112f && ancoraCamera.position.x > 97f &&
                 ancoraCamera.position.y < 89f && ancoraCamera.position.y > 68f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 104f, 107.40f),
                Mathf.Clamp(ancoraCamera.position.y, 71.74f, 88.67f),
                transform.position.z);
        }
        // Dungeon - Salgados
        // Labirinto
        else if (ancoraCamera.position.x < 175f && ancoraCamera.position.x > 131f &&
                 ancoraCamera.position.y < 51f && ancoraCamera.position.y > 37f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 135.4f, 169.1f),
                Mathf.Clamp(ancoraCamera.position.y, 9.05f, 52.5f),
                transform.position.z);
        }

        // Sala 1 - Pequena
        else if (ancoraCamera.position.x < 175f && ancoraCamera.position.x > 161f &&
                 ancoraCamera.position.y < 78f && ancoraCamera.position.y > 68f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 166.6f, 169.1f),
                Mathf.Clamp(ancoraCamera.position.y, 71f, 74.98f),
                transform.position.z);
        }
        // Sala 2 - Grande
        else if (ancoraCamera.position.x < 202f && ancoraCamera.position.x > 177f &&
                 ancoraCamera.position.y < 106f && ancoraCamera.position.y > 81f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 182.3f, 199.3f),
                Mathf.Clamp(ancoraCamera.position.y, 85.99f, 102.87f),
                transform.position.z);
        }
        // Sala 3 - Média
        else if (ancoraCamera.position.x < 226f && ancoraCamera.position.x > 207.5f &&
                 ancoraCamera.position.y < 66f && ancoraCamera.position.y > 52f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 213.6f, 221.1f),
                Mathf.Clamp(ancoraCamera.position.y, 55f, 63f),
                transform.position.z);
        }
        // Sala 4 - Média (SUL)
        else if (ancoraCamera.position.x < 198f && ancoraCamera.position.x > 179f &&
                 ancoraCamera.position.y < 28f && ancoraCamera.position.y > 12f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 184.1f, 193.7f),
                Mathf.Clamp(ancoraCamera.position.y, 15f, 22.95f),
                transform.position.z);
        }
        // Corredor
        else if (ancoraCamera.position.x < 192f && ancoraCamera.position.x > 185f &&
                 ancoraCamera.position.y < 74f && ancoraCamera.position.y > 34f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 188.3f, 189.4f),
                Mathf.Clamp(ancoraCamera.position.y, 37f, 71f),
                transform.position.z);
        }

        // Presente - Limpeza
        // Banheiro
        else if (ancoraCamera.position.x < 92f && ancoraCamera.position.x > 77f &&
         ancoraCamera.position.y < -10f && ancoraCamera.position.y > -22f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.2f, 85.4f),
                Mathf.Clamp(ancoraCamera.position.y, -18.93f, -13.05f),
                transform.position.z);
        }
        // Deposito 1
        else if (ancoraCamera.position.x < 92f && ancoraCamera.position.x > 77f &&
                 ancoraCamera.position.y < 11f && ancoraCamera.position.y > -1f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 82.09f, 85.51f),
                Mathf.Clamp(ancoraCamera.position.y, 2.06f, 7.97f),
                transform.position.z);
        }
        // Deposito 2
        else if (ancoraCamera.position.x < 97.3f && ancoraCamera.position.x > 85f &&
                 ancoraCamera.position.y < 32f && ancoraCamera.position.y > 19f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 90.11f, 92.52f),
                Mathf.Clamp(ancoraCamera.position.y, 23.05f, 28.93f),
                transform.position.z);
        }
        // Deposito 3
        else if (ancoraCamera.position.x < 124f && ancoraCamera.position.x > 111f &&
                 ancoraCamera.position.y < 31.9f && ancoraCamera.position.y > 18f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 116.1f, 119.52f),
                Mathf.Clamp(ancoraCamera.position.y, 23.06f, 28.97f),
                transform.position.z);
        }
        // Lounge
        else if (ancoraCamera.position.x < 135.34f && ancoraCamera.position.x > 121f &&
                 ancoraCamera.position.y < 12.9f && ancoraCamera.position.y > 0f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 127.05f, 130.55f),
                Mathf.Clamp(ancoraCamera.position.y, 4.04f, 9.97f),
                transform.position.z);
        }
        // Mercado
        else if (ancoraCamera.position.x < 113.5f && ancoraCamera.position.x > 98f &&
                 ancoraCamera.position.y < 12f && ancoraCamera.position.y > -9f)
        {
            transform.position = new Vector3(
                Mathf.Clamp(ancoraCamera.position.x, 104.09f, 107.56f),
                Mathf.Clamp(ancoraCamera.position.y, -5.97f, 8.94f),
                transform.position.z);
        }
    }
}
