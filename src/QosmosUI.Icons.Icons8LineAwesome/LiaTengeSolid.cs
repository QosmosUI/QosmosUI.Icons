// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaTengeSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 6.6328125 5 C 6.2848125 5 6 5.2740937 6 5.6210938 L 6 8.3671875 C 6 8.7151875 6.2848125 9 6.6328125 9 L 25.378906 9 C 25.725906 9 26 8.7151875 26 8.3671875 L 26 5.6210938 C 26 5.2740938 25.725906 5 25.378906 5 L 6.6328125 5 z M 6.6328125 12 C 6.2848125 12 6 12.284094 6 12.621094 L 6 15.367188 C 6 15.715188 6.2848125 16 6.6328125 16 L 14 16 L 14 27.378906 C 14 27.725906 14.274094 28 14.621094 28 L 17.378906 28 C 17.725906 28 18 27.725906 18 27.378906 L 18 16 L 25.378906 16 C 25.725906 16 26 15.715187 26 15.367188 L 26 12.621094 C 26 12.284094 25.725906 12 25.378906 12 L 6.6328125 12 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
