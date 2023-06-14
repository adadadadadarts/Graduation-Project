using UnityEngine;

public class DusmanTakip : MonoBehaviour
{
    public Transform hedef;  // Takip edilecek hedefin referansı
    public float hiz = 5f;  // Düşmanın hareket hızı

    private void Update()
    {
        // Hedefe doğru yönelme vektörü hesapla
        Vector3 yon = (hedef.position - transform.position).normalized;

        // Düşmanı hedefe doğru hareket ettir
        transform.Translate(yon * hiz * Time.deltaTime);
    }
}

