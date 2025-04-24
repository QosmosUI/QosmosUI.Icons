// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons.Default;

public class VscRepoFetch : ComponentBase
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
		builder.OpenElement(13, "rect");
		builder.AddAttribute(14, "x", "8");
		builder.AddAttribute(15, "y", "4");
		builder.AddAttribute(16, "width", "1");
		builder.AddAttribute(17, "height", "1");
		builder.AddAttribute(18, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(19, "rect");
		builder.AddAttribute(20, "x", "8");
		builder.AddAttribute(21, "y", "6");
		builder.AddAttribute(22, "width", "1");
		builder.AddAttribute(23, "height", "1");
		builder.AddAttribute(24, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(25, "rect");
		builder.AddAttribute(26, "x", "8");
		builder.AddAttribute(27, "y", "2");
		builder.AddAttribute(28, "width", "1");
		builder.AddAttribute(29, "height", "1");
		builder.AddAttribute(30, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(31, "rect");
		builder.AddAttribute(32, "x", "8");
		builder.AddAttribute(33, "width", "1");
		builder.AddAttribute(34, "height", "1");
		builder.AddAttribute(35, "rx", "0.5");
		builder.CloseElement();
		builder.OpenElement(36, "path");
		builder.AddAttribute(37, "fill-rule", "evenodd");
		builder.AddAttribute(38, "clip-rule", "evenodd");
		builder.AddAttribute(39, "d", "M8.00016 6.43935L9.00016 6.43935L12.6466 2.79291L13.3537 3.50001L8.85371 8.00001H8.14661L3.64661 3.50001L4.35371 2.79291L8.00016 6.43935Z");
		builder.CloseElement();
		builder.OpenElement(40, "path");
		builder.AddAttribute(41, "fill-rule", "evenodd");
		builder.AddAttribute(42, "clip-rule", "evenodd");
		builder.AddAttribute(43, "d", "M5.03544 12H2V13H5.03544C5.27806 14.6961 6.73676 16 8.5 16C10.2632 16 11.7219 14.6961 11.9646 13H15.0001V12H11.9646C11.7219 10.3039 10.2632 9 8.5 9C6.73676 9 5.27806 10.3039 5.03544 12ZM11 12.5C11 13.8807 9.88071 15 8.5 15C7.11929 15 6 13.8807 6 12.5C6 11.1193 7.11929 10 8.5 10C9.88071 10 11 11.1193 11 12.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
