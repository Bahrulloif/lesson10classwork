public class Point
{
    private int _x;
    private int _y;

    public Point()
    {

    }
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }
    public int GetX()
    {
        return _x;
    }
    public void SetX(int x)
    {
        _x = x;
    }
    public int GetY()
    {
        return _y;
    }
    public void SetY(int y)
    {
        _y = y;
    }
    public string ToString()
    {
        return $"({_x},{_y})";
    }
    public int[] GetXY()
    {
        int[] a = new int[] { _x, _y };
        return a;

    }
    public void SetXY(int x, int y)
    {
        _x = x;
        _y = y;
    }
    public double Distance(int x, int y)
    {
        return Math.Sqrt((x - _x) * (x - _x) + (y - _y) * (y - _y));
    }
    public double Distance(Point another)
    {
        return Math.Sqrt((_x - another._x) * (_x - another._x) + (_y - another._y) * (_y - another._y));
    }
    public double Distance()
    {
        return Math.Sqrt(_x * _x + _y * _y);
    }
}