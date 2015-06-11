using UnityEngine;
using System.Collections;

public class Character : Entity
{
	public Bullet bullet;

    protected void Fire(Vector3 position, Quaternion direction)
    {
		Bullet fired = Instantiate( bullet, position, direction ) as Bullet;

		// tag the bullet with our ID
		fired.whoFiredMe = this;
    }
}
