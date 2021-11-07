# Práctica 4: Uso de componentes en Unity3D 📌

### Esta práctica tiene objetivo aplicar interfaces naturales en componentes con Unity3D (cámara y micrófono). 
-----------------------------------
<br />

### **Primer ejercicio - Micrófono**

Se ha implementado un script, incluido en el [repositorio](./src/MicrophoneController.cs), para la obtención de sonido desde el micrófono del ordenador.

```csharp
public delegate void MicrophoneDelegate();
public class MicrophoneController : MonoBehaviour
{
    public float threshold = -50f;
    public static float MicVolume;
    public static event MicrophoneDelegate loudEvent;
    
    private AudioClip audioClip;
    private int sampleWindow = 128;

    void Start()
    {
        int min, max = 0;
        Microphone.GetDeviceCaps(null, out min, out max);
        Debug.Log(string.Format("Recording... (freq: {0})", max));
        audioClip = Microphone.Start(Microphone.devices[0], true, 999, 44100);
    }

    void Update()
    {
        MicVolume = 20 * Mathf.Log10(Mathf.Abs(calculateVolume()));
        if (MicVolume > threshold) loudEvent();        
    }

    float calculateVolume()
    {
        float levelMax = 0;
        float[] waveData = new float[sampleWindow];
        int micPosition = Microphone.GetPosition(null) - (sampleWindow + 1); // null means the first microphone
        if (micPosition < 0) return 0;
        audioClip.GetData(waveData, micPosition);
        // Getting a peak on the last 128 samples
        for (int i = 0; i < sampleWindow; i++) {
            float wavePeak = waveData[i] * waveData[i];
            if (levelMax < wavePeak) {
                levelMax = wavePeak;
            }
        }
        return levelMax;
    }
}
```
Este script se le ha asignado a un `GameManager`.

### **Segundo ejercicio - Cámara**