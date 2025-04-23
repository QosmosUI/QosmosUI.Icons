// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.VsCodeIcons;

public class VscGitPullRequestGoToChanges : ComponentBase
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
		builder.AddAttribute(16, "d", "M2.99994 10V14L3.99994 15H12.9999L13.9999 14V5L13.7099 4.29L10.7099 1.29L9.99994 1H8V2H9.99994L12.9999 5V14H3.99994V10H2.99994ZM11 6H9V4H8V6H6V7H8V9H9V7H11V6ZM6 11H11V12H6V11Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "fill-rule", "evenodd");
		builder.AddAttribute(19, "clip-rule", "evenodd");
		builder.AddAttribute(20, "d", "M7.06065 3.85356L4.91421 6L4.2071 5.29289L5.49999 4H2.5C2.10218 4 1.72064 4.15804 1.43934 4.43934C1.15804 4.72065 1 5.10218 1 5.5C1 5.89783 1.15804 6.27936 1.43934 6.56066C1.72064 6.84197 2.10218 7 2.5 7H3V8H2.5C1.83696 8 1.20107 7.73661 0.732233 7.26777C0.263392 6.79893 0 6.16305 0 5.5C0 4.83696 0.263392 4.20108 0.732233 3.73224C1.20107 3.2634 1.83696 3 2.5 3H5.49999L4.2071 1.70711L4.91421 1L7.06065 3.14645L7.06065 3.85356Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
