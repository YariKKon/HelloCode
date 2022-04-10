int count = 0;
int distance = 10000;
int fFS = 1;
int sFS = 2;
int dogSpeed = 5;
int Friend = 2;
int time = 0;

while(distance > 10)
{
    if(Friend == 1)
    {
        time = distance / (fFS + dogSpeed);
        Friend = 2;

    }

    else
    {
        time = distance / (sFS + dogSpeed);
        Friend = 1;
    }

    distance = distance - (fFS + sFS) * time;
    count++;

}

Console.Write("count = ");
Console.WriteLine(count);
