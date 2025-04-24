// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiHole : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 151c-62.9 0-119.9 10.8-161.94 28.8-21.03 9.1-38.38 19.9-50.86 32.5C30.71 225 23 239.9 23 256s7.71 31 20.2 43.7c12.48 12.6 29.83 23.4 50.86 32.5C136.1 350.2 193.1 361 256 361c62.9 0 119.9-10.8 161.9-28.8 21.1-9.1 38.4-19.9 50.9-32.5C481.3 287 489 272.1 489 256s-7.7-31-20.2-43.7c-12.5-12.6-29.8-23.4-50.9-32.5-42-18-99-28.8-161.9-28.8zm0 43c82.7 0 165.5 21.2 215 63.6-.5 9.9-5.3 19.6-15 29.4-10.2 10.4-25.6 20.2-45.2 28.6-39 16.7-94 27.4-154.8 27.4-60.8 0-115.8-10.7-154.8-27.4-19.55-8.4-35.01-18.2-45.19-28.6-9.65-9.8-14.48-19.5-14.96-29.4C90.54 215.2 173.3 194 256 194z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
