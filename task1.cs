

## Task 1

As stated you can use the functions Move, Turn, Peek and AtGoal + variables, conditionals, arrays, loops and functions to get the car to the end.

**Submit**:   
Add task1.*file to the repo.  
Commit to github. 

![alt] (images / map1.png)

while(!AtGoal())
{
    MoveOrTurn();
}

Void MoveOrTurn()
{
    if(AtGoal())
    {
        return;
    }
    if(Peek())
    {
        Move();
    }
    else 
    {
        Turn();
    }
}


void Move()
{
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