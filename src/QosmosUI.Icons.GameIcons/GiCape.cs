// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCape : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M257.1 18.46c-17 19.58-32.7 35.31-55.1 42.98 41.5 68.46 139.9 119.76 241.2 62.36 18-14.1 26.7-31.45 34.9-47.34-98.9-5.45-164.8-19.81-221-58zM225 111.1c-18.9 38.3-41 72.2-65.1 100.2-40.8 47.5-87.03 78.7-132.67 85.3 6.47 19.8 10.43 59.2 25.84 72.6 45.63 18.5 132.83-9.1 164.63-38.7 16.1-16.4 24-36.6 34.2-60.9-2 35.2-13.3 56.6-27.7 72.4-18.5 18.2-36.6 30.8-59 37.8 11.9 22.3 16.8 49.7 27.7 67.8 4.4 6.7 8 9.5 14.6 9.4 42-10.9 74.4-45.9 110.9-60.5 55.3-29.3 65.3-74 67-85.5-1.1 28.7-12.7 67.5-31.7 83.6 33.8 12.4 47.5 67.3 52.3 90.2 15.2-14 33.2-35.4 48.1-60.1C473 393.5 487 357.2 487 324.2c-.3-38.8-17-76.4-26.5-118.2-5-21.7-7.7-44.7-4.6-69.3-131.7 55.7-190.9 9.4-230.9-25.6z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
