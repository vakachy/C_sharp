
double distance = 2500;
int firstFriendSpeed = 10;
int secondFriendSpeed = 5;
int dogsSpeed = 20;
int count = 0;
int friend = 1;
double time = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogsSpeed);
        friend = 2;
    }

    if (friend == 2)
    {
        time = distance / (secondFriendSpeed + dogsSpeed);
        friend = 2;
    }

    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}

Console.WriteLine(count);
