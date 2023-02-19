using UnityEngine;
using System.Collections;
using TMPro;


public class WaveSpawner : MonoBehaviour {

    public static int EneimesAlive = 0;

	public Wave[] waves;

    public Transform spawnPoint;

	public float timeBetweenWaves = 5f;
	private float countdown = 2f;

    public TextMeshProUGUI waveCountdownText;

	private int waveIndex = 0;

	void Update ()
	{
        if(EneimesAlive > 0)
        {
            return;
        }

		if (countdown <= 0f)
		{
            StartCoroutine(SpawnWave());
			countdown = timeBetweenWaves;
            return;
		}

		countdown -= Time.deltaTime;

        waveCountdownText.text = Mathf.Round(countdown).ToString();

	}

    IEnumerator SpawnWave()
    {
                PlayerStats.Waves++;

            Wave wave = waves[waveIndex];

            for (int i = 0; i < wave.count; i++)
            {
                SpawnEnemy(wave.enemy);
                yield return new WaitForSeconds(1f/wave.rate);
            }

            waveIndex++;
    }

    void SpawnEnemy(GameObject enemy)
    {
        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        EneimesAlive ++;
    }

}