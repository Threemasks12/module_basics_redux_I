

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


