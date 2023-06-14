using UnityEngine;

public class HedefTiklama : MonoBehaviour
{
    private bool hedefSecildi = false;
    private Vector3 hedefNokta;
    public float hiz = 5f;

    private void Update()
    {
        if (hedefSecildi)
        {
            // Hedefe doğru hareket et
            transform.position = Vector3.MoveTowards(transform.position, hedefNokta, hiz * Time.deltaTime);

            // Hedefe ulaşıldığında seçimi sıfırla
            if (transform.position == hedefNokta)
            {
                hedefSecildi = false;
            }
        }
    }

    private void OnMouseDown()
    {
        // Fare tıklama noktasını dünya koordinatlarına dönüştür
        Vector3 fareTiklamaNoktasi = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        fareTiklamaNoktasi.y = transform.position.y;
        hedefNokta = fareTiklamaNoktasi;

        // Hedefi seç ve hareketi etkinleştir
        hedefSecildi = true;
    }
}
