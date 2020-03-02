using UnityEngine;

public class playerShipHealth : Health
{
    public GameObject gameOverScreen;

    public override void Die()
    {
        Time.timeScale = 0.0f;
        gameOverScreen.SetActive(true);
    }
}
