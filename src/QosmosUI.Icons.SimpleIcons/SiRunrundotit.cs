// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons;

public class SiRunrundotit : ComponentBase
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
		builder.AddAttribute(15, "d", "M11.933 10.995c.289-1.241.554-2.402.715-3.377.293-1.762.364-2.985.28-4.197h.134c2.995 0 4.642 1.256 4.642 3.364 0 2.769-2.795 4.174-5.771 4.21Zm10.006 7.318c-.544.701-1.352 1.4-2.306 1.4-1.844 0-3.433-2.808-3.71-6.624 3.514-.662 6.575-3.086 6.575-6.823C22.498 3.18 19.313 0 13.55 0 6.478 0 .471 3.84.471 8.648c0 1.696.886 3.249 2.396 3.249.874 0 1.775-.345 2.36-1.167-.4-.767-.622-1.376-.575-2.277.086-1.613 1.982-3.354 3.734-4.198.029 2.846-.402 5.014-1.105 8.305-.755 3.537-1.747 6.57-1.747 9.087 0 1.073.502 2.353 1.773 2.353 1.351 0 2.533-.789 3.302-1.663-.199-1.552-.226-3.313.25-6.255a55.23 55.23 0 0 1 .636-3.187c.43 4.649 2.332 11.045 6.867 11.045 2.742 0 5.167-1.693 5.167-3.918 0-1.012-.636-1.83-1.59-1.709");
		builder.CloseElement();
		builder.CloseElement();
    }
}
