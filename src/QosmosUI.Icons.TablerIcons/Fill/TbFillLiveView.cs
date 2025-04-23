// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.TablerIcons.Fill;

public class TbFillLiveView : ComponentBase
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
		builder.AddAttribute(14, "d", "M8 3a1 1 0 1 1 0 2h-2a1 1 0 0 0 -1 1v2a1 1 0 1 1 -2 0v-2a3 3 0 0 1 3 -3z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M4 15a1 1 0 0 1 1 1v2a1 1 0 0 0 1 1h2a1 1 0 0 1 0 2h-2a3 3 0 0 1 -3 -3v-2a1 1 0 0 1 1 -1");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M18 3a3 3 0 0 1 3 3v2a1 1 0 0 1 -2 0v-2a1 1 0 0 0 -1 -1h-2a1 1 0 0 1 0 -2z");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M20 15a1 1 0 0 1 1 1v2a3 3 0 0 1 -3 3h-2a1 1 0 0 1 0 -2h2a1 1 0 0 0 1 -1v-2a1 1 0 0 1 1 -1");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M15.19 7.214a5 5 0 0 1 1.185 6.27l-.056 .09l-3.484 4.976a1 1 0 0 1 -.077 .103l-.017 .019l-.057 .056l-.012 .013l-.019 .017a1 1 0 0 1 -.096 .073l-.053 .03l-.038 .024l-.011 .005a1 1 0 0 1 -.223 .083l-.045 .008l-.066 .012a1 1 0 0 1 -.242 0l-.061 -.011l-.05 -.01a1 1 0 0 1 -.234 -.087l-.047 -.028l-.044 -.026l-.011 -.008l-.032 -.025l-.053 -.04l-.01 -.01l-.009 -.007l-.034 -.035l-.035 -.034l-.007 -.01l-.01 -.009l-.037 -.05l-.024 -.03l-3.5 -5l-.056 -.089a5 5 0 0 1 7.566 -6.27m-3.191 2.786a1 1 0 0 0 -1 1v.01a1 1 0 0 0 2 0v-.01a1 1 0 0 0 -1 -1");
		builder.CloseElement();
		builder.CloseElement();
    }
}
