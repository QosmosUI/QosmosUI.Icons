// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiIledefrancemobilites : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M18.54.001A5.461 5.447 0 0 1 24 5.447v13.107A5.461 5.447 0 0 1 18.54 24H5.459A5.461 5.447 0 0 1 0 18.553V5.446A5.461 5.447 0 0 1 5.46 0h13.081Zm-9.781 15.26c-1.365 1.816-2.503 3.405-3.925 5.334-.34.454-.057.624.398.34.512-.34.967-.736 1.309-1.247.3-.421.857-1.175 1.448-1.977l.595-.808c.33-.445.646-.876.914-1.243.796-1.135 2.047-1.023 2.9.17a398.137 397.144 0 0 0 3.242 4.481c.739 1.02 2.957.851 3.924.794.17 0 .228-.17.17-.283a310.878 310.103 0 0 0-4.663-6.467c-2.047-2.894-4.606-1.42-6.312.907ZM17.8 7.32c-2.9 1.474-3.809 1.304-6.255 1.701-2.445.34-4.266.908-6.313 3.064-.51.567-.74 1.021.058.624 2.9-1.475 3.81-1.305 6.254-1.702 2.446-.34 4.267-.907 6.314-3.064.512-.566.796-1.02-.057-.623Zm-5.06-4.142c-.966-.454-2.218.17-2.786 1.419-.569 1.19-.228 2.553.74 3.007.966.454 2.217-.17 2.786-1.42.568-1.246.228-2.609-.74-3.006Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
