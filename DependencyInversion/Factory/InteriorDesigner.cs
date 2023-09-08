namespace DependencyInversion.Factory;

public class InteriorDesigner
{
    public void FurnishRoom()
    {
        var sofa = SofaFactory.CreateSofa();
        var chair = ChairFactory.CreateChair();
        var table = TableFactory.CreateTable();

        PlaceFurniture(sofa, 2, 3);
        PlaceFurniture(chair, 4, 5);
        PlaceFurniture(table, 0, 0);
    }

    private static void PlaceFurniture(Furniture furniture, int x, int y)
    {
        furniture.X = x;
        furniture.Y = y;
    }
}