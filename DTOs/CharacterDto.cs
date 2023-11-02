namespace EntityFramework7Relationships.DTOs
{
    public record struct CharacterDto(
        string Name, 
        BackpackDto Backpack, 
        List<WeaponDto> Weapons,
        List<FactionDto> Factions);
}
