public class Line
{
    private Point? _begin;
    private Point? _end;

    public Line(int x1, int y1, int x2, int y2)
    {
        _begin = new Point(x1, y1);
        _end = new Point(x2, y2);
    }
    public Line(Point begin, Point end)
    {
        _begin = begin;
        _end = end;
    }
    public Point GetBegin()
    {
        return _begin;
    }
    public void SetBegin(Point begin)
    {
        _begin = begin;
    }
    public Point GetEnd()
    {
        return _end;
    }
    public void SetEnd(Point end)
    {
        _end = end;
    }
    public int GetBeginX()
    {
        return _begin.GetX();
    }
    public void SetBeginX(int x)
    {
        _begin.SetX(x);
    }
    public int GetBeginY()
    {
        return _begin.GetY();
    }
    public void SetBeginY(int y)
    {
        _begin.SetY(y);
    }
    public int[] GetBeginXY()
    {
        return _begin.GetXY();
    }
    public void SetBeginXY(int x, int y)
    {
        _begin.SetXY(x, y);
    }
    public int GetEndX()
    {
        return _end.GetX();
    }
    public void SetEndX(int x)
    {
        _end.SetX(x);
    }
    public int GetEndY()
    {
        return _end.GetY();
    }
    public void SetEndY(int y)
    {
        _end.SetY(y);
    }
    public int[] GetEndXY()
    {
        return _end.GetXY();
    }
    public void SetEndXY(int x, int y)
    {
        _end.SetXY(x, y);
    }
    public string ToString()
    {
        return $"Line[begin={_begin.ToString()}, end={_end.ToString()}]";
    }
    public double GetLenght()
    {
        return _end.Distance(_begin);
    }
}