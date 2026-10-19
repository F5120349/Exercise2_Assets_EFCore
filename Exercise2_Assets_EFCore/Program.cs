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

var newAsset = new Assets("Printer", "Office", new DateOnly(2023, 3, 20), true, 500.00m);
db.Assets.Add(newAsset);

db.SaveChanges();