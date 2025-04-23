// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaChalkboardTeacherSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 4 6 L 4 8 L 26 8 L 26 24 L 12 24 L 12 26 L 30 26 L 30 24 L 28 24 L 28 6 L 4 6 z M 8.0019531 9 C 5.8032706 9 4 10.802666 4 13 C 4 15.198683 5.8040743 17 8.0019531 17 C 10.197134 17 12 15.198683 12 13 C 12 10.802666 10.19794 9 8.0019531 9 z M 14 10 L 14 12 L 19 12 L 19 10 L 14 10 z M 21 10 L 21 12 L 24 12 L 24 10 L 21 10 z M 8.0019531 11 C 9.1159662 11 10 11.883334 10 13 C 10 14.119317 9.1167719 15 8.0019531 15 C 6.881832 15 6 14.119317 6 13 C 6 11.883334 6.8826357 11 8.0019531 11 z M 14 14 L 14 16 L 24 16 L 24 14 L 14 14 z M 4 18 L 4 26 L 6 26 L 6 20 L 9 20 L 9 26 L 11 26 L 11 20.658203 L 13.064453 21.75 C 13.648752 22.060158 14.351587 22.058921 14.935547 21.75 L 14.935547 21.751953 L 18.466797 19.884766 L 17.533203 18.115234 L 14.001953 19.982422 L 10.90625 18.347656 C 10.475078 18.120046 9.9935054 18 9.5039062 18 L 4 18 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
