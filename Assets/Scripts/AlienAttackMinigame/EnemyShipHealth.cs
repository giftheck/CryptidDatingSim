public class EnemyShipHealth : Health
{
    //Public value to set the number of points given upon the destruction of the enemy
    public int pointsUponDestruction;

    //This will give points as per the points value above
    public override void Die()
    {
        base.Die();
    }
}
