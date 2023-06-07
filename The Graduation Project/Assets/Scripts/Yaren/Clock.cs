using UnityEngine;

public class Clock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;

    private float startingHourAngle = -90f;     // Saat mekanizmasının başlangıç açısı (12:00 için)
    private float hourRotationSpeed = 8f / 60f; // Saat mekanizmasının saat başına dönüş hızı (derece/saniye)
    private float minuteRotationSpeed = 4f / 60f;   // Saat mekanizmasının dakika başına dönüş hızı (derece/saniye)

    private void Start()
    {
        // Saat mekanizmasının başlangıç açısını ayarla
        hourHand.rotation = Quaternion.Euler(0f, 0f, startingHourAngle);
        minuteHand.rotation = Quaternion.identity;
    }

    private void Update()
    {
        // Saat mekanizmasının dönüş hızını hesapla
        float hourRotation = hourRotationSpeed * Time.deltaTime;
        float minuteRotation = minuteRotationSpeed * Time.deltaTime;

        // Akrep ve yelkovanı döndür
        hourHand.Rotate(0f, 0f, hourRotation);
        minuteHand.Rotate(0f, 0f, minuteRotation);
    }
}