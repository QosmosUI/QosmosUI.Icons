// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiFlyingDagger : ComponentBase
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
		builder.AddAttribute(14, "d", "M133.53 10.47c51.747 30.872 96.318 71.166 131.94 119.093C199.33 72.05 115.217 33.942 19.22 21.406c12.584 96.38 50.948 180.807 108.843 247.063-47.45-35.09-87.475-78.907-118.313-129.783v31.219C65.264 272.953 147.488 356.6 249.28 413.812 159.164 375.9 78.843 322.91 10.813 257.375l-.468 38.125C134.828 408.824 300.18 479.697 493.75 494.688c-14.992-193.573-85.27-358.92-198.594-483.407l-41.812.44c64.677 66.753 117.25 145.417 155.28 233.624-57.55-99.84-140.81-180.403-242.937-234.875H133.53zm22.22 149.5c36.29 16.732 71.624 40.59 103.97 68.343l60.717-60.157 34.47 34.438-37.376 23.375c58.01 69.636 105.07 147.97 134.908 230.686-82.466-29.758-160.62-76.55-230.094-134.312l-23.938 36.78-35.062-34.468 60.75-60.72c-27.75-32.335-51.607-67.668-68.344-103.967z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
