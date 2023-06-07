using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Image fillImage1;
    public Image fillImage2;

    private float hourRotationSpeed = 10f; // Saat mekanizmasının saat başına dönüş hızı (derece/saniye)
    private float minuteRotationSpeed = 60f; // Saat mekanizmasının dakika başına dönüş hızı (derece/saniye)
    private bool isDayTime = true; // Gündüz modu kontrolü
    private int HourCount = 0; // Akrep 6 pozisyonuna kaç kez geldiğini sayar

    private void Start()
    {
        // Saat mekanizmasının başlangıç açısını ayarla
        float startHourAngle = CalculateHourAngle(6); // 00:00 A.M. için akrep açısı hesapla
        float startMinuteAngle = CalculateMinuteAngle(0); // 00 dakika için yelkovan açısı hesapla

        hourHand.localRotation = Quaternion.Euler(0f, 0f, startHourAngle);
        minuteHand.localRotation = Quaternion.Euler(0f, 0f, startMinuteAngle);

        // Fill Image'ları sıfırla
        fillImage1.fillAmount = 0f;
        fillImage2.fillAmount = 0f;
    }

    private void Update()
    {
        // Saat mekanizmasının dönüş açısını hesapla
        float hourRotation = hourRotationSpeed * Time.deltaTime;
        float minuteRotation = minuteRotationSpeed * Time.deltaTime;

        // Akrep ve yelkovanı döndür
        hourHand.Rotate(Vector3.back, hourRotation);
        minuteHand.Rotate(Vector3.back, minuteRotation);

        // Fill Image'ları kontrol et
        CheckFillImages();
    }

    private void CheckFillImages()
    {
        // Akrep 18:00 pozisyonuna geldiğinde günü değiştir
        if (Mathf.Approximately(hourHand.localRotation.eulerAngles.z, 354f))
        {
            HourCount++;
            if (HourCount >= 2)
            {
                HourCount = 0;
                ToggleDayNight();
            }
        }
        
        // Saat 06:00 A.M ve 18:00 P.M arasında fill Image'ları kontrol et
        if (HourCount < 2)
        {
            
            // İkinci fill Image'ı sıfırla
            fillImage2.fillAmount = 0f;
            
            // İlk fill Image'ı orantılı olarak arttır
            float fillAmount1 = CalculateFillAmount(hourHand.localRotation.eulerAngles.z % 360);
            fillImage1.fillAmount = fillAmount1;

        }
        else
        {
            // İlk fill Image'ı sıfırla
            fillImage1.fillAmount = 0f;

            // İkinci fill Image'ı orantılı olarak doldur
            float fillAmount2 = CalculateFillAmount(hourHand.localRotation.eulerAngles.z % 360);
            fillImage2.fillAmount = fillAmount2;
            
        }

        
    }

    private void ToggleDayNight()
    {
        isDayTime = !isDayTime;
        Debug.Log(isDayTime ? "Day Time" : "Night Time");
    }

    private float CalculateHourAngle(int hour)
    {
        float hourAngle = hour * 30f;
        return hourAngle;
    }

    private float CalculateMinuteAngle(int minute)
    {
        float minuteAngle = minute * 6f;
        return minuteAngle;
    }

    private float CalculateFillAmount(float angle)
    {
        float fillAmount = (angle * 100) / 360f;
        return fillAmount;
    }
}
