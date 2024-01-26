
## Task 4

As stated you can use the functions Move, Turn, Peek and AtGoal + variables, conditionals, arrays, 
loops and functions to get the car to the end.

**Submit**:   
Add task4.* to the repo.  
Commit to github. 

![alt](images/map4.png) 



List<(int, int)> crossroads = new List<(int, int)>();

bool teleported = false;

while (!AtGoal())
{
    int possibleRoads = SeeAlldirectins();

    if (possibleroads > 1)
    {
        crossroads.Add(CurrentPosition());

        MoveAvailableDirection();

        teleported = false;
    }
    else if (possibleroads == 1)
    {
        MoveAvailableDirection();

        teleported = false;
    }
    else
    {
        if (teleported)
        {
            crossroads.RemoveAt(crossroads.Count - 1);
            if (crossroads.Count > 0)
            {
                Teleport(crossroads[crossroads.Count - 1]);
            }
        }
        else
        {
            Teleport(crossroads[crossroads.Count - 1]);
            crossroads.RemoveAt(crossroads.Count - 1);
            teleported = true;
        }
    }
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    Mark();
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}


bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

#endregion

#region Created functions

int SeeAlldirectins()
{
    int turnCount = 0;
    int possibleroads = 0;

    while (turnCount < 4)
    {
        if (Peek())
        {
            // Add the current cell to the list of crossroads.
            crossroads.Add(CurrentPosition());
            possibleroads++;
        }
        Turn();
        turnCount++;
    }

    return possibleroads;
}

void Mark()
{
    // Paints the current cell. Making it a wall.
}

(int, int) CurrentPosition()
{
    // Returns the current cell Position.
    return (0, 0); // Just a placeholder value.
}

void Teleport((int, int) position)
{
    // Teleports the car to the given position.
}

void MoveAvailableDirection()
{
    while (!Peek())
    {
        Turn();
    }

    Move();
}