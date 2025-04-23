// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaNeos : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8.2871094 5 L 6 6.7011719 L 6 26 L 6.6679688 26 L 10.662109 26 L 14.003906 23.556641 L 14.001953 19.523438 L 18.367188 26 L 21.787109 26 L 25 24 L 25 5 L 20.337891 5 L 17 7.4199219 L 17 11.349609 L 12.767578 5 L 8.2871094 5 z M 9.3886719 6 L 12.232422 6 L 21 19.150391 L 21 6 L 24 6 L 24 23 L 20.720703 23 L 9.3886719 6 z M 8.328125 6.2148438 L 20.185547 24 L 23.041016 24 L 21.474609 25 L 18.984375 25 L 14 17.748047 L 14 17.734375 L 13.990234 17.734375 L 10 11.929688 L 10 22.25 L 7 24.5 L 7 7.203125 L 8.328125 6.2148438 z M 20 6.4804688 L 20 15.849609 L 18 12.849609 L 18 7.9296875 L 20 6.4804688 z M 11 15.070312 L 13 18.037109 L 13.003906 23.048828 L 10.337891 25 L 8 25 L 11 22.75 L 11 15.070312 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
