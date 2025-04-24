// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.IcoMoonFree.Default;

public class ImKey2 : ComponentBase
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
		builder.AddAttribute(14, "d", "M15.658 4.91l-1.58-1.58c-0.387-0.387-1.021-1.021-1.409-1.409l-1.58-1.58c-0.387-0.387-1.077-0.456-1.533-0.152l-4.319 2.88c-0.456 0.304-0.628 0.954-0.383 1.444l1.101 2.203c0.034 0.067 0.073 0.139 0.115 0.213l-5.571 5.571-0.5 3.5h3v-1h2v-2h2v-2h2v-1.112c0.1 0.060 0.196 0.113 0.284 0.157l2.203 1.101c0.49 0.245 1.14 0.072 1.444-0.383l2.88-4.319c0.304-0.456 0.236-1.146-0.152-1.533zM2.354 13.354l-0.707-0.707 4.868-4.868 0.707 0.707-4.868 4.868zM14.328 6.621l-0.707 0.707c-0.194 0.194-0.513 0.194-0.707 0l-4.243-4.243c-0.194-0.194-0.194-0.513 0-0.707l0.707-0.707c0.194-0.194 0.513-0.194 0.707 0l4.243 4.243c0.194 0.194 0.194 0.513 0 0.707z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
