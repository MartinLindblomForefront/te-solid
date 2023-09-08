namespace DependencyInversion.Factory;

#region Factories

public class ChairFactory
{
    public static Chair CreateChair()
    {
        var legs = LegFactory.CreateLegs(4);
        var backrest = BackrestFactory.CreateBackrest(1);
        var seat = SeatFactory.CreateSeat(1);

        return new Chair(legs, backrest, seat);
    }
}

public class SofaFactory
{
    public static Sofa CreateSofa()
    {
        var legs = LegFactory.CreateLegs(6);
        var backrest = BackrestFactory.CreateBackrest(2);
        var seat = SeatFactory.CreateSeat(2);

        return new Sofa(legs, backrest, seat);
    }
}

public class TableFactory
{
    public static Table CreateTable()
    {
        var legs = LegFactory.CreateLegs(4);
        var tabletop = TabletopFactory.CreateTabletop();

        return new Table(legs, tabletop);
    }
}

public class LegFactory
{
    public static List<Leg> CreateLegs(int count)
    {
        return Enumerable.Repeat(new Leg(), count).ToList();
    }
}

public class BackrestFactory
{
    public static Backrest CreateBackrest(int width)
    {
        return new Backrest(width);
    }
}

public class SeatFactory
{
    public static Seat CreateSeat(int width)
    {
        return new Seat(width);
    }
}

public class TabletopFactory
{
    public static Tabletop CreateTabletop()
    {
        return new Tabletop();
    }
}

#endregion

#region Products

public class Furniture
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
}

public class Chair : Furniture
{
    public List<Leg> Legs { get; set; }
    public Backrest Backrest { get; set; }
    public Seat Seat { get; set; }

    public Chair(List<Leg> legs, Backrest backrest, Seat seat)
    {
        Legs = legs;
        Backrest = backrest;
        Seat = seat;
    }
}

public class Sofa : Furniture
{
    public List<Leg> Legs { get; set; }
    public Backrest Backrest { get; set; }
    public Seat Seat { get; set; }

    public Sofa(List<Leg> legs, Backrest backrest, Seat seat)
    {
        Legs = legs;
        Backrest = backrest;
        Seat = seat;
    }
}

public class Table : Furniture
{
    public List<Leg> Legs { get; set; }
    public Tabletop Tabletop { get; set; }

    public Table(List<Leg> legs, Tabletop tabletop)
    {
        Legs = legs;
        Tabletop = tabletop;
    }
}

#endregion

#region Parts

public class Leg
{

}

public class Backrest
{
    public int Width { get; set; }

    public Backrest(int width)
    {
        Width = width;
    }
}

public class Seat
{
    public int Width { get; set; }

    public Seat(int width)
    {
        Width = width;
    }
}

public class Armrest
{

}

public class Tabletop
{

}

#endregion