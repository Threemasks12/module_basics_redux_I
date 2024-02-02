

## Task 5

As stated you can use the functions Move, Turn, Peek and AtGoal + variables, conditionals, arrays, loops and functions to get the car to the end.

**Submit**:   
Add task5.* to the repo.  
Commit to github. 

![alt](images/map5.png) 



while (!AtGoal())
{
    if (Peek())
    {
        Move();
        Mark();
    }
    else
    {
        Turn();
    }

    SeeAlldirectins();
}

#region Basic functions
// These functions are just her to make your intelisense work. 
// They only have a conceptual function.

void Move()
{
    // Moves the car 1 cell in the direction it is heading. 
}

void Turn()
{
    // Turns the car 90 deg counter clockwise.
}

bool Peek()
{
    // Returns true if the next cell is open, otherwise false.
    return true; // Just a placeholder value. 
}

#endregion

#region Created functions

void SeeAlldirectins()
{
    int turnCount = 0;

    while (turnCount < 4)
    {
        if (IsGoal())
        {
            Move();
        }

        Turn();

        turnCount++;
    }
}

bool IsGoal()
{
    // Returns true if the cell ahead is the goal cell.
    return true; // Just a placeholder value.
}

bool AtGoal()
{
    // Returns true if the current cell is the goal cell.
    return true; // just a placholder
}

