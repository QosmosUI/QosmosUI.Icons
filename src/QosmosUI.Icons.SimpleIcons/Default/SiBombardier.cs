// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBombardier : ComponentBase
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
		builder.AddAttribute(15, "d", "m0 23.24 1.823-1.822c1.823-1.823 3.645-2.127 6.076-2.127h5.012c2.43 0 3.707-.152 5.681-1.519h.244l-3.342 3.342c-1.823 1.823-3.646 2.127-6.076 2.127H0ZM5.165 6.533l1.822 1.822c1.823 1.823 3.646 2.127 6.076 2.127h5.013c2.43 0 3.706.152 5.681 1.519-1.975 1.367-3.25 1.519-5.681 1.519h-5.013c-2.43 0-4.253.304-6.076 2.127l-1.822 1.822h9.417c2.43 0 4.254-.303 6.076-2.126L24 12l-3.342-3.342c-1.822-1.823-3.645-2.126-6.076-2.126H5.165ZM0 .759l1.823 1.823C3.646 4.405 5.468 4.71 7.899 4.71h5.012c2.43 0 3.707.152 5.681 1.519h.244l-3.342-3.342C13.67 1.063 11.848.76 9.418.76H0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
