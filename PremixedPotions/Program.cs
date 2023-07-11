PotionType BrewPotion (List<PotionIngredient> ingredients) => ingredients switch
{
    //Did not assume water was a given, could have slightly simplified this if i had but oh well, too late now
    //also now treating water as purely an ingredient rather than as a potion itself
    [PotionIngredient.Water, PotionIngredient.Stardust] => PotionType.Elixir,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.SnakeVenom] => PotionType.Poison,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.DragonBreath] => PotionType.Flying,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.ShadowGlass] => PotionType.Invisibility,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.EyeshineGem] => PotionType.NightSight,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.EyeshineGem, PotionIngredient.ShadowGlass] => PotionType.CloudyBrew,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.ShadowGlass, PotionIngredient.EyeshineGem] => PotionType.CloudyBrew,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.ShadowGlass, PotionIngredient.EyeshineGem, PotionIngredient.Stardust] => PotionType.Wraith,
    [PotionIngredient.Water, PotionIngredient.Stardust, PotionIngredient.EyeshineGem, PotionIngredient.ShadowGlass, PotionIngredient.Stardust] => PotionType.Wraith,
    _ => PotionType.Ruined
};

//Local methods cannot be overloaded so needed a different name :(
PotionType BrewPotionWithPotion (PotionType potionBase, List<PotionIngredient> ingredients) => (potionBase, ingredients) switch
{
    (PotionType.Elixir, [PotionIngredient.SnakeVenom]) => PotionType.Poison,
    (PotionType.Elixir, [PotionIngredient.DragonBreath]) => PotionType.Flying,
    (PotionType.Elixir, [PotionIngredient.ShadowGlass]) => PotionType.Invisibility,
    (PotionType.Elixir, [PotionIngredient.EyeshineGem]) => PotionType.NightSight,

    (PotionType.NightSight, [PotionIngredient.ShadowGlass]) => PotionType.CloudyBrew,
    (PotionType.Elixir, [PotionIngredient.EyeshineGem, PotionIngredient.ShadowGlass]) => PotionType.CloudyBrew,
    (PotionType.Invisibility, [PotionIngredient.EyeshineGem]) => PotionType.CloudyBrew,
    (PotionType.Elixir, [PotionIngredient.ShadowGlass, PotionIngredient.EyeshineGem]) => PotionType.CloudyBrew,

    (PotionType.Invisibility, [PotionIngredient.EyeshineGem, PotionIngredient.Stardust]) => PotionType.Wraith,
    (PotionType.Elixir, [PotionIngredient.ShadowGlass, PotionIngredient.EyeshineGem, PotionIngredient.Stardust]) => PotionType.Wraith,
    (PotionType.NightSight, [PotionIngredient.ShadowGlass, PotionIngredient.Stardust]) => PotionType.Wraith,
    (PotionType.Elixir, [PotionIngredient.EyeshineGem, PotionIngredient.ShadowGlass, PotionIngredient.Stardust]) => PotionType.Wraith,
    (PotionType.CloudyBrew, [PotionIngredient.Stardust]) => PotionType.Wraith,
    _ => PotionType.Ruined
};

enum PotionType { Elixir, Poison, Flying, Invisibility, NightSight, CloudyBrew, Wraith, Ruined }
enum PotionIngredient
{
    Stardust, SnakeVenom, DragonBreath, ShadowGlass, EyeshineGem, Water
}