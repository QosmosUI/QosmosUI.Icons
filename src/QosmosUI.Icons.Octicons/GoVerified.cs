// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Octicons;

public class GoVerified : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M17.03 9.78a.75.75 0 0 0-1.06-1.06l-5.47 5.47-2.47-2.47a.75.75 0 0 0-1.06 1.06l3 3a.75.75 0 0 0 1.06 0l6-6Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "m14.136 1.2 1.375 1.01c.274.201.593.333.929.384l1.687.259a3.61 3.61 0 0 1 3.02 3.021l.259 1.686c.051.336.183.655.384.929l1.01 1.375a3.61 3.61 0 0 1 0 4.272l-1.01 1.375a2.106 2.106 0 0 0-.384.929l-.259 1.687a3.61 3.61 0 0 1-3.021 3.02l-1.686.259a2.106 2.106 0 0 0-.929.384l-1.375 1.01a3.61 3.61 0 0 1-4.272 0l-1.375-1.01a2.106 2.106 0 0 0-.929-.384l-1.687-.259a3.61 3.61 0 0 1-3.02-3.021l-.259-1.686a2.117 2.117 0 0 0-.384-.929L1.2 14.136a3.61 3.61 0 0 1 0-4.272l1.01-1.375c.201-.274.333-.593.384-.929l.259-1.687a3.61 3.61 0 0 1 3.021-3.02l1.686-.259c.336-.051.655-.183.929-.384L9.864 1.2a3.61 3.61 0 0 1 4.272 0Zm-3.384 1.209-1.375 1.01a3.614 3.614 0 0 1-1.59.658l-1.686.258a2.111 2.111 0 0 0-1.766 1.766l-.258 1.686a3.61 3.61 0 0 1-.658 1.589l-1.01 1.376a2.11 2.11 0 0 0 0 2.496l1.01 1.375c.344.469.57 1.015.658 1.59l.258 1.686c.14.911.855 1.626 1.766 1.766l1.686.258a3.61 3.61 0 0 1 1.589.658l1.376 1.01a2.11 2.11 0 0 0 2.496 0l1.375-1.01a3.613 3.613 0 0 1 1.59-.657l1.686-.26a2.11 2.11 0 0 0 1.766-1.765l.258-1.686a3.61 3.61 0 0 1 .658-1.589l1.01-1.376a2.11 2.11 0 0 0 0-2.496l-1.01-1.375a3.613 3.613 0 0 1-.657-1.59l-.26-1.686a2.11 2.11 0 0 0-1.765-1.766l-1.686-.258a3.61 3.61 0 0 1-1.589-.658l-1.376-1.01a2.11 2.11 0 0 0-2.496 0Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
