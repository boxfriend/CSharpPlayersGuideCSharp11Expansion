var map = new TileType[4, 8]
    {
        { TileType.Water, TileType.Land, TileType.City, TileType.Land, TileType.Water, TileType.Land, TileType.Water, TileType.Water },
        { TileType.Mountain, TileType.Land, TileType.Land, TileType.Land, TileType.Water, TileType.Land, TileType.Land, TileType.Water },
        { TileType.Water, TileType.Mountain, TileType.Land, TileType.Land, TileType.Land, TileType.Land, TileType.Land, TileType.Land },
        { TileType.Water, TileType.Water, TileType.Mountain, TileType.City, TileType.Mountain, TileType.Water, TileType.Water, TileType.Water }
    };

for(var i = 0; i < map.GetLength(0); i++)
{
    Console.Write("|");
    for(var j = 0; j < map.GetLength(1); j++)
    {
        Console.Write(TileString(map[i,j]));
        Console.Write("|");
    }
    Console.Write("\n");
}

static string TileString (TileType tile) => tile switch
{
    TileType.Water => "~~",
    TileType.Mountain => "^^",
    TileType.City => "()",
    _ => "  "
};

enum TileType { Water, Mountain, City, Land }