// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillFishBone : ComponentBase
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
		builder.AddAttribute(14, "d", "M16.675 6.44l.118 .005a1 1 0 0 1 .232 .052l.032 .015l.273 .103c1.936 .771 3.69 2.27 5.253 4.476l.245 .355a1 1 0 0 1 0 1.12c-1.702 2.519 -3.636 4.176 -5.792 4.947a1 1 0 0 1 -1.093 -.288a7.97 7.97 0 0 1 -1.883 -4.225h-2.06v3a1 1 0 0 1 -2 0v-3h-2v1a1 1 0 0 1 -2 0v-1h-1.166l-.335 .324a39 39 0 0 0 -1.751 1.846a1 1 0 0 1 -1.496 -1.328q .593 -.667 1.214 -1.308l.522 -.528l-.523 -.529a42 42 0 0 1 -.613 -.648l-.6 -.661a1 1 0 1 1 1.496 -1.328a40 40 0 0 0 2.069 2.161l1.183 -.001v-1a1 1 0 1 1 2 0v1h2v-3a1 1 0 0 1 2 0v3h2.062a7.97 7.97 0 0 1 1.656 -3.953l.196 -.24l.075 -.081l.105 -.088l.068 -.048l.097 -.052l.069 -.03l.138 -.042l.091 -.017q .059 -.007 .118 -.009m1.325 3.56a1 1 0 0 0 -.993 .883l-.007 .127a1 1 0 0 0 1.993 .117l.007 -.127a1 1 0 0 0 -1 -1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
