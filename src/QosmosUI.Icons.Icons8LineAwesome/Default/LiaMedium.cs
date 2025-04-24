// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaMedium : ComponentBase
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
		builder.AddAttribute(14, "d", "M 26 10.359375 L 25.210938 10.359375 C 24.914063 10.359375 24.5 10.785156 24.5 11.058594 L 24.5 20.992188 C 24.5 21.269531 24.914063 21.640625 25.210938 21.640625 L 26 21.640625 L 26 24 L 18.832031 24 L 18.832031 21.640625 L 20.332031 21.640625 L 20.332031 11.199219 L 20.261719 11.199219 L 16.757813 24 L 14.046875 24 L 10.585938 11.199219 L 10.5 11.199219 L 10.5 21.640625 L 12 21.640625 L 12 24 L 6 24 L 6 21.640625 L 6.769531 21.640625 C 7.085938 21.640625 7.5 21.269531 7.5 20.992188 L 7.5 11.058594 C 7.5 10.785156 7.085938 10.359375 6.769531 10.359375 L 6 10.359375 L 6 8 L 13.503906 8 L 15.964844 17.261719 L 16.035156 17.261719 L 18.519531 8 L 26 8 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
