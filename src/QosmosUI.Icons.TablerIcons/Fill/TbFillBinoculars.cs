// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillBinoculars : ComponentBase
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
		builder.AddAttribute(14, "d", "M8.887 6.748c-.163 0 -.337 .016 -.506 .057c-.172 .041 -.582 .165 -.838 .562l-.014 .02l-.607 1.05c-.307 .205 -.534 .46 -.693 .717l-.014 .02l-2.572 4.65a4.009 4.009 0 0 0 -.274 .494l-.006 .01a3.99 3.99 0 0 0 -.363 1.672a4 4 0 0 0 8 0v-1h2v1a4 4 0 1 0 7.635 -1.67l-.004 -.012a4.008 4.008 0 0 0 -.274 -.494l-2.572 -4.65l-.014 -.02a2.337 2.337 0 0 0 -.693 -.716l-.607 -1.051l-.014 -.02c-.256 -.397 -.667 -.52 -.838 -.562a2.225 2.225 0 0 0 -.664 -.051a2.06 2.06 0 0 0 -.68 .156c-.184 .081 -.638 .327 -.754 .889l-.007 .037l-.14 1.1c-.22 .283 -.374 .64 -.374 1.064v1h-2v-1c0 -.424 -.154 -.781 -.373 -1.064l-.14 -1.1l-.008 -.037c-.116 -.562 -.57 -.808 -.754 -.889a2.06 2.06 0 0 0 -.68 -.156a2.374 2.374 0 0 0 -.158 -.006zm-1.887 7.252a2 2 0 1 1 -1.838 1.209l.19 -.342c.36 -.523 .964 -.867 1.648 -.867zm10 0c.684 0 1.288 .344 1.648 .867l.19 .342a2 2 0 1 1 -1.838 -1.209z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
