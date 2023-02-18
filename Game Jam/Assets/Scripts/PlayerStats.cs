using UnityEngine;
using System.Collections;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 250;

    public static int Lives;
    public int startLives;

    public static int Waves;
    // Start is called before the first frame update
    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        Waves = 0;
    }

   
}
