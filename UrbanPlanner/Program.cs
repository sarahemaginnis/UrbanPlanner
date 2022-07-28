using UrbanPlanner;

City city = new City("Gotham", 1);

Building FiveOneTwoEight = new Building("512 8th Avenue S")
{
    Width = 100,
    Depth = 2,
    Stories = 5
};

//FiveOneTwoEight.Width = 100;
//FiveOneTwoEight.Depth = 2;
//FiveOneTwoEight.Stories = 5;

FiveOneTwoEight.Construct();

FiveOneTwoEight.Purchase("Brennan Wills");

city.AddBuilding(FiveOneTwoEight);

//FiveOneTwoEight.DisplayInformation();

Building WolfOfWallStreet = new Building("Penthouse on Wall Street")
{
    Width = 300.5,
    Depth = 50.75,
    Stories = 79
};

WolfOfWallStreet.Construct();
WolfOfWallStreet.Purchase("Emily Schroeder");
city.AddBuilding(WolfOfWallStreet);
//WolfOfWallStreet.DisplayInformation();

Building TowerOfTerror = new Building("Tower in Disneyworld")
{
    Width = 175,
    Depth = 25,
    Stories = 50
};

TowerOfTerror.Construct();
TowerOfTerror.Purchase("Wes Westmoreland");
city.AddBuilding(TowerOfTerror);
//TowerOfTerror.DisplayInformation();

Building Hogwarts = new Building("North of Hogsmeade Village")
{
    Width = 500,
    Depth = 375,
    Stories = 13
};

Hogwarts.Construct();
Hogwarts.Purchase("Nicholas Stewart");
city.AddBuilding(Hogwarts);
//Hogwarts.DisplayInformation();

//city.AccessBuildingsList();

foreach (Building building in city.Buildings)
{
    building.DisplayInformation();
} ;