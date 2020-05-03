# Homework, week 6 question 1-2

question 1:
scene '3d-shield'
we added a shield around player when gathering the shileds:
	added sprite to plaer and set it enable(true) when shield is enable and vice versa 
shield are randomly spawned on map:
	add spawner and give him the map size to spawn inside it
	
question 2:
a. put visible borders- meteors in game that player can collide and bounce a little:
	set the riggid-body of player to dynamic with gravity at 0
b. invisable borders- make lasers and enemy despawn at touching the borders:
	jest make a collider and set only the the touching object to delete
c. round wall- put borders at the right and left sides of the map, when touching- teleporting to other side of map:
	just to colliders at the side, because camera at 0,0,0 we just set the new vector to -(old vector) at x value (if the border was at top and bottom the change was for y value)
	

