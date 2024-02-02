
As stated you can use the functions Move, Turn, Peek and AtGoal + variables, conditionals, arrays, loops and functions to get the car to the end.

**Submit**:   
Add task3.* to the repo.  
Commit to github. 

![alt](images/map3.png) 


while (!AtGoal())
{
    MoveOrTurn();
}

void MoveOrTurn();
{
    if(AtGoal())
    {
        return;
    }
    
    Peek();
    if (Peek())
    {
        Move();      
    }
    else
    {
        Turn();
        Peek();
        if(!Peek())
        {
            center();
            trunLeft();  
        }
          
    }
    
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

void center()
{
    Turn();
    Turn();
    Turn();
}

void trunLeft()
{
    Turn();
    Turn();
    Turn();
}