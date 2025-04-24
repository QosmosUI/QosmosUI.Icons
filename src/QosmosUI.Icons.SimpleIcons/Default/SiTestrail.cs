// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiTestrail : ComponentBase
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
		builder.AddAttribute(15, "d", "M7.27 23.896 4.5 21.124a.352.352 0 0 1 0-.5l2.772-2.77a.352.352 0 0 1 .5 0l2.772 2.772a.352.352 0 0 1 0 .5l-2.772 2.77a.352.352 0 0 1-.5 0H7.27zm4.48-4.48-2.772-2.772a.352.352 0 0 1 0-.498l2.772-2.772a.352.352 0 0 1 .5 0l2.77 2.772a.352.352 0 0 1 0 .5l-2.77 2.77a.352.352 0 0 1-.499 0zm4.48-4.48-2.77-2.772a.352.352 0 0 1 0-.498l2.771-2.772a.352.352 0 0 1 .5 0l2.77 2.772a.352.352 0 0 1 0 .498l-2.772 2.772a.352.352 0 0 1-.5 0h.002zm-8.876.084-2.772-2.77a.352.352 0 0 1 0-.499l2.772-2.773a.352.352 0 0 1 .5 0l2.772 2.772a.352.352 0 0 1 0 .498l-2.772 2.774a.352.352 0 0 1-.5 0v-.002zm4.48-4.48L9.062 7.77a.352.352 0 0 1 0-.5l2.772-2.772a.352.352 0 0 1 .5 0l2.77 2.772a.352.352 0 0 1 0 .498l-2.77 2.772a.352.352 0 0 1-.499 0v-.002.001zM7.44 6.15 4.666 3.37a.352.352 0 0 1 0-.5L7.44.104a.352.352 0 0 1 .5 0l2.772 2.772a.352.352 0 0 1 0 .5L7.938 6.142a.352.352 0 0 1-.5 0l.002.006v.001z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
