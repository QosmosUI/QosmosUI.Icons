// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGoogledisplayandvideo360 : ComponentBase
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
		builder.AddAttribute(15, "d", "M4.421.01a2.947 2.947 0 0 0-2.828 1.52 2.967 2.967 0 0 0 1.094 4.076l10.6 6.064 4.79-2.672a3.546 3.546 0 0 1 1.811-.443L5.701.424A2.947 2.947 0 0 0 4.42.01ZM1.164 4.768v14.484a3.474 3.474 0 0 1 2.972-1.687 3.47 3.47 0 0 1 2.961 1.672l.004-10.53L2.44 6.04a3.433 3.433 0 0 1-1.275-1.271Zm18.42 4.289a3.08 3.08 0 0 0-1.264.379L7.6 15.414c.003 1.873-.011 3.745.003 5.617 0 .4-.072.988-.396 1.606l12.548-7.227 1.487-.83a2.978 2.978 0 0 0 1.463-3.511 3.08 3.08 0 0 0-3.121-2.012ZM4.136 18.065A2.967 2.967 0 1 0 4.134 24a2.967 2.967 0 0 0 .002-5.935z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
