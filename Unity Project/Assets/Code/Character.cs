using UnityEngine;
using System.Collections;

public class Character : Entity
{
	public Bullet bullet;

    protected void Fire(Vector3 position, Quaternion direction)
    {
		Instantiate( bullet, position, direction );
    }
}
