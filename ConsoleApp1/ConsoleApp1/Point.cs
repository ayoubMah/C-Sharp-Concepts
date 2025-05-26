namespace ConsoleApp1;

public class Point
{
    public int  x;
    public int y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void move(int x, int y)
    {
        this.x += x;
        this.y += y;
    }

    public void move(Point newPoint)
    {
        this.x = x + newPoint.x;
        this.y = y + newPoint.y;
    }
}