public enum AnimationName
{
    idleDown,
    idleUp,
    idleRight,
    idleLeft,
    walkUp,
    walkDown,
    walkRight,
    walkLeft,
    runUp,
    runDown,
    runRight,
    runLeft,
    useToolUp,
    useToolDown,
    useToolRight,
    useToolLeft,
    swingToolUp,
    swingToolDown,
    swingToolRight,
    swingToolLeft,
    liftToolUp,
    liftToolDown,
    liftToolRight,
    liftToolLeft,
    holdToolUp,
    holdToolDown,
    holdToolRight,
    holdToolLeft,
    pickDown,
    pickUp,
    pickRight,
    pickLeft,
    count
}
public enum Month //Season in Part 34
{
    Month1,
    Month2,
    Month3,
    Month4,
    none,
    count
}
public enum CharacterPartAnimator
{
    body,
    tool,
    count
}
public enum PartVariantColour
{
    none,
    count
}
public enum PartVariantType
{
    none,
    carry,
    hoe,
    hammer,
    axe,
    scythe,
    wateringCan,
    count
}
public enum GridBoolProperty
{
    diggable,
    canDropItem,
    canPlaceFurniture,
    isPath,
    isNPCObstacle
}
public enum InventoryLocation
{
    player,
    chest,
    count
}
public enum SceneName
{
    Scene1_Farm,
    Scene2_Town,
    Scene3_Cabin
}
public enum ToolEffect
{
    none,
    watering
}
public enum Direction
{
    up,
    down,
    left,
    right,
    none
}
public enum ItemType
{
    Seed,
    Commodity,
    Watering_tool,
    Hoeing_tool,
    Chopping_tool,
    Breaking_tool,
    Reaping_tool,
    Collecting_tool,
    Reapable_scenary,
    Furniture,
    none,
    count
}

public enum HarvestActionEffect
{
    deciduousLeavesFalling,
    pineConesFalling,
    choppingTreeTrunk,
    breakingStone,
    reaping,
    none
}