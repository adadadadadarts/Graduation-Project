using UnityEngine;
using UnityEngine.UI;

public class Dusman : MonoBehaviour
{
    public float maxCan = 100f;
    public float anlikCan;
    public float hasarMiktari = 20f;

    public Slider canSlider; // Can çubuğu UI öğesi

    private void Start()
    {
        anlikCan = maxCan;
        GuncelleCanUI();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Oyuncu"))
        {
            // Çarpışma nedeniyle düşman hasar alır
            HasarVer(hasarMiktari);
        }
    }

    private void HasarVer(float hasar)
    {
        anlikCan -= hasar;
        GuncelleCanUI();

        if (anlikCan <= 0f)
        {
            // Düşman öldüğünde yapılacak işlemler
            gameObject.SetActive(false);
        }
    }

    private void GuncelleCanUI()
    {
        canSlider.value = anlikCan / maxCan;
    }
}

