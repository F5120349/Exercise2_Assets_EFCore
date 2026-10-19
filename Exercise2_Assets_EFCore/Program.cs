using Exercise2_Assets_EFCore.Data;

static void displayAssets(List<Assets> assets)
{
    foreach (var asset in assets)
    {
        Console.WriteLine(asset);
    }
}

using var db = new AssetsDbContext();

var assets = db.Assets.ToList();

displayAssets(assets);