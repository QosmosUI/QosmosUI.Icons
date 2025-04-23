// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiRocketFlight : ComponentBase
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
		builder.AddAttribute(14, "d", "M482.22 44.844l-50.533 46.25-21.937 57.22c-34.637 15.445-47.955 24.442-61.47 74.874l39.564-17.657-1.875 32.095 37.342 14.344 21.75-24.5 17.625 39.56c24.52-42.467 25.663-63.24 4.282-96.78l21.936-57.22-6.687-68.186zM389.093 263.22c-16.33 25.16-38.017 48.57-63.063 68.217-.022.018-.038.045-.06.063-37.302 23.693-83.27 29.138-118.095 15.688 16.236 15.056 37.635 20.705 59.156 19.156-49.41 14.874-102.32 9.118-139.624-14.28 14.142 19.334 34.493 31.22 56.97 36.592-58.93 3.328-117.894-19.792-162.44-84l.002 168.03c65.91 28.65 135.148 19.62 196.218-11.56l-16.97 35.78 88.126-85.03h-.093c2-1.796 3.973-3.6 5.936-5.438l-11.28 43.937 59.812-99.438c19.668-27.56 35.253-57.384 45.406-87.718z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
