using VVibrantDynamicLayout.Client.Pages.PlaceholderComponents;

namespace VVibrantDynamicLayout.Client.Services;

public class ComponentRegistryService
{
    private readonly IReadOnlyDictionary<string, Type> _componentMap;

    public ComponentRegistryService()
    {
        _componentMap = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
        {
            ["Component-Logo"] = typeof(LogoComponent),
            ["Component-OpeningHours"] = typeof(OpeningHoursComponent),
            ["Component-ContactDetails"] = typeof(ContactDetailsComponent),
            ["Component-Menu"] = typeof(MenuComponent),
            ["Component-ProfileMenu"] = typeof(ProfileMenuComponent),
            ["Component-Search"] = typeof(SearchComponent),
            ["Component-QuickLinks"] = typeof(QuickLinksComponent),
            ["Component-Announcements"] = typeof(AnnouncementsComponent),
            ["Component-NewArrivals"] = typeof(NewArrivalsComponent),
            ["Component-Copyright"] = typeof(CopyrightComponent),
            ["Component-OtherInfo"] = typeof(OtherInfoComponent)
        };
    }

    public Type GetComponentType(string componentId) =>
        _componentMap.GetValueOrDefault(componentId, typeof(DefaultComponent));
}
