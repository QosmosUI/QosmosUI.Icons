// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscRepoForcePush : ComponentBase
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
		builder.AddAttribute(16, "d", "M8.00016 2.56065L8 3.5H9L9.00016 2.56065L12.6466 6.20709L13.3537 5.49999L8.85371 0.999986H8.14661L3.64661 5.49999L4.35371 6.20709L8.00016 2.56065Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "fill-rule", "evenodd");
		builder.AddAttribute(19, "clip-rule", "evenodd");
		builder.AddAttribute(20, "d", "M8.00016 5.56065V7.99999H9.00016V5.56065L12.6466 9.20709L13.3537 8.49999L8.85371 3.99999H8.14661L3.64661 8.49999L4.35371 9.20709L8.00016 5.56065Z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "fill-rule", "evenodd");
		builder.AddAttribute(23, "clip-rule", "evenodd");
		builder.AddAttribute(24, "d", "M5.03544 12H2V13H5.03544C5.27806 14.6961 6.73676 16 8.5 16C10.2632 16 11.7219 14.6961 11.9646 13H15.0001V12H11.9646C11.7219 10.3039 10.2632 9 8.5 9C6.73676 9 5.27806 10.3039 5.03544 12ZM11 12.5C11 13.8807 9.88071 15 8.5 15C7.11929 15 6 13.8807 6 12.5C6 11.1193 7.11929 10 8.5 10C9.88071 10 11 11.1193 11 12.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
