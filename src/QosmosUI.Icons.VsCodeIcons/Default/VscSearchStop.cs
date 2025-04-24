// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscSearchStop : ComponentBase
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
		builder.AddAttribute(14, "fill-rule", "evenodd");
		builder.AddAttribute(15, "clip-rule", "evenodd");
		builder.AddAttribute(16, "d", "M5.738 3.318a4.5 4.5 0 0 0-.877 5.123A4.48 4.48 0 0 0 6.1 10a4.62 4.62 0 0 0-.1 1v.17c-.16-.11-.32-.22-.47-.34L1.75 14.5 1 13.84l3.8-3.69a5.5 5.5 0 1 1 9.62-3.65c0 .268-.02.535-.06.8a5.232 5.232 0 0 0-.94-.68V6.5a4.5 4.5 0 0 0-7.682-3.182zm3.04 4.356a4 4 0 1 1 4.444 6.652 4 4 0 0 1-4.444-6.652zm.1 5.447A3 3 0 0 0 11 14a3 3 0 0 0 1.74-.55L8.55 9.26A3 3 0 0 0 8 11a3 3 0 0 0 .879 2.121zm.382-4.57l4.19 4.189A3 3 0 0 0 14 11a3 3 0 0 0-3-3 3 3 0 0 0-1.74.55z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
