// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Regular;

public class BiRegBxRfid : ComponentBase
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
		builder.AddAttribute(14, "d", "M4 22h16a1 1 0 0 0 1-1v-8h-2v7H5V4h5V2H4a1 1 0 0 0-1 1v18a1 1 0 0 0 1 1z");
		builder.CloseElement();
		builder.OpenElement(15, "circle");
		builder.AddAttribute(16, "cx", "12");
		builder.AddAttribute(17, "cy", "11");
		builder.AddAttribute(18, "r", "1");
		builder.CloseElement();
		builder.OpenElement(19, "path");
		builder.AddAttribute(20, "d", "M15 11h2a5 5 0 0 0-5-5v2a3 3 0 0 1 3 3z");
		builder.CloseElement();
		builder.OpenElement(21, "path");
		builder.AddAttribute(22, "d", "M19 11h2a9 9 0 0 0-9-9v2a7 7 0 0 1 7 7zM9.65 15.67a1 1 0 0 0-.14-.51.76.76 0 0 0-.38-.31 2.3 2.3 0 0 0-.75-.09H7V18h.65v-1.35h.14a1.31 1.31 0 0 1 .33 0 .58.58 0 0 1 .19.14 4.72 4.72 0 0 1 .35.48l.47.7h.78l-.39-.63a3.56 3.56 0 0 0-.38-.53 1.25 1.25 0 0 0-.35-.27 1 1 0 0 0 .64-.3.84.84 0 0 0 .22-.57zm-.74.33a.4.4 0 0 1-.18.14 2.36 2.36 0 0 1-.59 0h-.49v-.82h1a.4.4 0 0 1 .25.13.36.36 0 0 1 .09.26.43.43 0 0 1-.08.29zM10.92 16.62h1.36v-.54h-1.36v-.77h1.57v-.55h-2.22V18h.65v-1.38zM13.01 14.76h.65V18h-.65zM16.1 14.82a2.48 2.48 0 0 0-.62-.06h-1.2V18h1.24a1.76 1.76 0 0 0 .57-.07 1.07 1.07 0 0 0 .46-.26 1.35 1.35 0 0 0 .35-.57 2 2 0 0 0 .1-.69 2.35 2.35 0 0 0-.11-.76 1.33 1.33 0 0 0-.31-.53 1.09 1.09 0 0 0-.48-.3zm.16 2.18a.74.74 0 0 1-.17.31.57.57 0 0 1-.27.13 1.79 1.79 0 0 1-.39 0h-.49v-2.13h.29a3.06 3.06 0 0 1 .54 0 .71.71 0 0 1 .3.15.82.82 0 0 1 .19.32 2.05 2.05 0 0 1 .06.57 2.41 2.41 0 0 1-.06.65z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
