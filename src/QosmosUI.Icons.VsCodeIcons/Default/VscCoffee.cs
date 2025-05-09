// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscCoffee : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "16";

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
    public string ViewBox { get; set; } = "0 0 16 16";

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
		builder.AddAttribute(14, "d", "M3 1V1.5C3 1.96954 3.27449 2.20587 3.8 2.6L3.83977 2.62978C4.31392 2.98457 5 3.49793 5 4.5V5H4V4.5C4 4.03046 3.72551 3.79413 3.2 3.4L3.16023 3.37022C2.68608 3.01543 2 2.50207 2 1.5V1H3Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M6 1V1.5C6 1.96954 6.27449 2.20587 6.8 2.6L6.83977 2.62978C7.31392 2.98457 8 3.49793 8 4.5V5H7V4.5C7 4.03046 6.72551 3.79413 6.2 3.4L6.16023 3.37022C5.68608 3.01543 5 2.50207 5 1.5V1H6Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M9 1V1.5C9 1.96954 9.27449 2.20587 9.8 2.6L9.83977 2.62978C10.3139 2.98457 11 3.49793 11 4.5V5H10V4.5C10 4.03046 9.72551 3.79413 9.2 3.4L9.16023 3.37022C8.68608 3.01543 8 2.50207 8 1.5V1H9Z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "fill-rule", "evenodd");
		builder.AddAttribute(21, "clip-rule", "evenodd");
		builder.AddAttribute(22, "d", "M2 7L3 6H13.5C14.8807 6 16 7.11929 16 8.5C16 9.88071 14.8807 11 13.5 11H12.874C12.4299 12.7252 10.8638 14 9 14H6C3.79086 14 2 12.2091 2 10V7ZM12 10V7H3V10C3 11.6569 4.34315 13 6 13H9C10.6569 13 12 11.6569 12 10ZM13 7V10H13.5C14.3284 10 15 9.32843 15 8.5C15 7.67157 14.3284 7 13.5 7H13Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
