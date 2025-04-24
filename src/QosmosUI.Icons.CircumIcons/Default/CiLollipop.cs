// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiLollipop : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Lollipop");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M18,6.565h-.19a6,6,0,0,0-11.62,0H6a1.5,1.5,0,1,0,0,3h.19a5.992,5.992,0,0,0,5.31,4.48v7.39a.5.5,0,0,0,.5.5.5.5,0,0,0,.5-.5v-7.39a6.013,6.013,0,0,0,5.31-4.48H18a1.5,1.5,0,1,0,0-3Zm-6-3.5a4.991,4.991,0,0,1,4.77,3.5H7.23A4.991,4.991,0,0,1,12,3.065Zm0,10a4.991,4.991,0,0,1-4.77-3.5h9.54A4.991,4.991,0,0,1,12,13.065Zm6-4.5H6a.5.5,0,0,1-.5-.5.5.5,0,0,1,.5-.5H18a.5.5,0,0,1,.5.5A.508.508,0,0,1,18,8.565Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
